/*
 Copyright © 2015 Matusevich Yury
 Author: Matusevich Yury.
 
 Permission is hereby granted, free of charge, to any person obtaining
 a copy of this software and associated documentation files (the
 "Software"), to deal in the Software without restriction, including
 without limitation the rights to use, copy, modify, merge, publish,
 distribute, sublicense, and/or sell copies of the Software, and to
 permit persons to whom the Software is furnished to do so, subject to
 the following conditions:
 
 The above copyright notice and this permission notice shall be included
 in all copies or substantial portions of the Software.
 
 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
 CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
 TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
 SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA_Helper
{
    class Collection
    {
        private List<string> _responseCollection;
        private const string ApiVersion = "5.37";
        internal List<string> ContactsCollection
        {
            get;
            private set;
        }
        internal List<string> UrlList
        {
            get;
            private set;
            
        }

        private List<string> _membersCollection;
        private readonly decimal _minAge;
        private readonly decimal _maxAge;
        private readonly List<string> _countries;
        private readonly List<string> _genders;

        private readonly string _membersCount;
        private readonly string _groupId;
        private readonly ToolStripProgressBar _progressBar1;

        public Collection(List<string> countries, List<string> genders, decimal minAge, decimal maxAge, 
            string membersCount, string groupId, ToolStripProgressBar progressBar1)
        {
            _countries = countries;
            _genders = genders;
            _minAge = minAge;
            _maxAge = maxAge;
            _membersCount = membersCount;
            _groupId = groupId;
            _progressBar1 = progressBar1;
        }

        public async Task<bool> CollectMembers(CancellationToken ct)
        {
            var client = new HttpClient();
            _responseCollection = new List<string>();
            UrlList = SetUpUrlList();
            _progressBar1.Maximum = UrlList.ToArray().Length;
            foreach (var url in UrlList)
            {
                var response = await client.GetAsync(url, ct);
                _responseCollection.Add(await response.Content.ReadAsStringAsync());
                _progressBar1.Increment(1);
            }
            return _responseCollection.ToArray().Length == UrlList.ToArray().Length;
        }
        
        private List<string> SetUpUrlList()
        {
            var urls = new List<string>();
            var membersCountInt = Convert.ToInt32(_membersCount);
            var membersCountToThousand = membersCountInt + (1000 - (membersCountInt % 1000));

            for (var offset = 0; offset < membersCountToThousand; offset += 1000)
            {
                
                urls.Add(string.
                    Format("https://api.vk.com/method/groups.getMembers?group_id={0}&offset={1}&count={2}&fields={3}&v={4}&access_token={5}", 
                    _groupId, offset, "1000", "sex,bdate,country,contacts,connections,domain,relation", ApiVersion, VkAuthSettings.Default.token));
            }
            Console.WriteLine(urls);
            return urls;
        }

        public bool Parsing()
        {
            _membersCollection = new List<string>();
            ContactsCollection = new List<string>();
            _progressBar1.Maximum = Convert.ToInt32(_membersCount);
            return _responseCollection.Select(JObject.Parse).
                Where(json => json["response"] != null).Any(json => GetMemberFromResponseString(json["response"]["items"]));
        }

        private bool GetMemberFromResponseString(JToken memberstList)
        {
            foreach (var member in memberstList)
            {
                _progressBar1.Increment(1);
                if (CheckMember(member) == null) continue;
                _membersCollection.Add(member.ToString());
                GetContactsFromMember(member);
            }
            return true;
        }

        private void GetContactsFromMember(JToken member)
        {
            if (member["mobile_phone"] != null && member["mobile_phone"].ToString() != "")
                ContactsCollection.Add(member["mobile_phone"].ToString());
            if (member["skype"] != null && member["skype"].ToString() != "")
                ContactsCollection.Add("skype: " + member["skype"]);
            if (member["twitter"] != null && member["twitter"].ToString() != "")
                ContactsCollection.Add("twitter: " + member["twitter"]);
            if (member["instagram"] != null && member["instagram"].ToString() != "")
                ContactsCollection.Add("instagram: " + member["instagram"]);
            ContactsCollection.Add("___________________________________________");
        }

        private JToken CheckMember(JToken member)
        {
            if (CheckGeo(member) && CheckGender(member) && CheckAge(member)) return member;
            return null;
        }

        private bool CheckGeo(JToken member)
        {
            return member["country"] != null && _countries.Any(country => member["country"]["id"].ToString() == country);
        }

        private bool CheckGender(JToken member)
        {
            return member["sex"] != null && _genders.Any(gender => member["sex"].ToString() == gender);
        }

        private bool CheckAge(JToken member)
        {
            if (member["bdate"] == null || member["bdate"].ToString().Length <= 5) return false;
            var bdate = member["bdate"].ToString();
            var birthDayDate = DateTime.ParseExact(ConvertVkDate(bdate), "dd/MM/yyyy", new CultureInfo("ru-RU"));
            var age = GetAge(birthDayDate);
            return _minAge <= age && age <= _maxAge;
        }

        public decimal GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;
            return (a - b) / 10000;
        }

        private static string ConvertVkDate(string text)
        {
            var day = text.Split('.')[0].PadLeft(2, '0');
            var month = text.Split('.')[1].PadLeft(2, '0');
            var year = text.Split('.')[2];

            return $"{day}/{month}/{year}";
        }
    }
}
