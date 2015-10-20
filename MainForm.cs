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

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SPA_Helper
{
    public partial class SpaHelper : Form
    {
        private int _numNumberLenght;
        private int _numRepeats;
        private int _geoCountry;
        private TheFile _newFile;
        private string _groupId;
        private const string ApplicationId = "5109778";
        private const string ApiVersion = "5.37";

        private string _membersCount;
        private string _groupName;
        private string _groupPhotoLink;

        private decimal _minAge;
        private decimal _maxAge;
        private List<string> _countries;
        private List<string> _genders;
        private CancellationTokenSource _cts;
        

        public SpaHelper()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            comboBox1.SelectedIndex = 0;
        }

        private void CheckIsUserLogin()
        {
            if (VkAuthSettings.Default.token == "")
            {
                VKAuthButton.Enabled = true;
                failLabelVK.Visible = true;
                succesLabelVK.Visible = false;
                vkParamsGroupBox.Enabled = false;
                logoutButton.Enabled = false;
                StartParseButton.Enabled = false;
            }
            else
            {
                VKAuthButton.Enabled = false;
                failLabelVK.Visible = false;
                succesLabelVK.Visible = true;
                vkParamsGroupBox.Enabled = true;
                logoutButton.Enabled = true;
                StartParseButton.Enabled = true;
                SetStatusLabelText("Авторизация в VK прошла успешно");
            }
        }

        private void SetStripParams()
        {
            _numNumberLenght = Convert.ToInt32(numberLengthNumericUpDown.Value);
            _numRepeats = Convert.ToInt32(numberRepeatsNumericUpDown.Value);
            _geoCountry = comboBox1.SelectedIndex;
        }

        private static void SetLabelText(Control label, string text)
        {
            label.Text = text;
        }

        private void ResetLabelsText()
        {
            SetLabelText(deletedNumbersLabel, "?");
            SetLabelText(savedNumbersLabel, "?");
        }

        private void SetStatusLabelText(string text)
        {
            statusLabel.Text = text;
        }

        private void ResetCookiesAndTokens()
        {
            var theCookies = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            foreach (var currentFile in theCookies)
            {
                try
                {
                    File.Delete(currentFile);
                }
                catch (Exception)
                {
                    ShowMessageBox("Ошибка! Не удалось удалить Cookies!");
                }
            }
            VkAuthSettings.Default.token = "";
            VkAuthSettings.Default.auth = false;
            VkAuthSettings.Default.id = "";
            SetStatusLabelText("Выход из аккаунта прошел успешно");
        }

        private bool IsUrlAvailible(string url)
        {
            try
            {
                var response = SendRequest(url);
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch (Exception)
            {
                ShowMessageBox("Ошибка отправки запроса!");
                return false;
            }
        }

        private static void ShowMessageBox(string text)
        {
            MessageBox.Show(text, "Внимание!", MessageBoxButtons.OK);
        }

        private void SetVkParams()
        {
            _groupId = groupIdTextBox.Text;
            if (string.IsNullOrEmpty(_groupId))
                ShowMessageBox("Введите ID группы!");
            else
            {
                SetGender();
                SetGeo();
                SetAge();
                if (CheckGroup(ClearGroupId(_groupId))) StartParsing();
            }
        }

        private string ClearGroupId(string groupId)
        {
            if (groupId.Length >= 4 && groupId.Substring(0, 4) == "club") _groupId = groupId.Remove(0, 4);
            return _groupId;
        }

        private async void StartParsing()
        {
            BlockClicks(true);
            _cts = new CancellationTokenSource();
            progressBar1.Value = 0;
            SetStatusLabelText("Получение участников сообщества...");
            var collection = new Collection(_countries, _genders, _minAge, _maxAge, _membersCount,
                _groupId, progressBar1);
            try
            {
                if (!await collection.CollectMembers(_cts.Token)) return;
                progressBar1.Value = progressBar1.Maximum;
                SetStatusLabelText("Поиск участников подходящих запросу...");
                progressBar1.Value = 0;
                if (collection.Parsing())
                {
                    progressBar1.Value = progressBar1.Maximum;
                    SetStatusLabelText("Формирование файла...");
                    var parsedDataFile = new TheFile();
                    if (parsedDataFile.CreateFile(collection.ContactsCollection.ToArray()))
                    {
                        BlockClicks(false);
                        SetStatusLabelText("Файл сохранен...");
                    }
                }
                else
                    ShowMessageBox("Произошла ошибка парсинга. Обратитесь к издателю программы.");
                _cts = null;
            }
            catch (OperationCanceledException)
            {
                SetStatusLabelText("Отменено...");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!! Запрос");
                BlockClicks(false);
                progressBar1.Value = 0;
            }
            catch (Exception)
            {
                BlockClicks(false);
                ShowMessageBox("Произошла ошибка парсинга. Обратитесь к издателю программы.");
            }
        }

        private void BlockClicks(bool isBlocked)
        {
            stripPhonesRadioButton.Enabled = !isBlocked;
            authGroupBox.Enabled = !isBlocked;
            parseRadioButton.Enabled = !isBlocked;
            phoneStripingPanel.Enabled = !isBlocked;
            vkParamsGroupBox.Enabled = !isBlocked;
            StartParseButton.Enabled = !isBlocked;
        }

        private void SetGender()
        {
            _genders = new List<string>();

            if (maleGenderCheckBox.Checked) _genders.Add("2");
            if (femaleGenderCheckBox.Checked) _genders.Add("1");

            if (maleGenderCheckBox.Checked == false && femaleGenderCheckBox.Checked == false)
            {
                _genders.Add("1");
                _genders.Add("2");
            }
        }

        private void SetGeo()
        {
            _countries = new List<string>();
            if (russiaCheckBox.Checked) _countries.Add("1");
            if (ukraineCheckBox.Checked) _countries.Add("2");
            if (belarusCheckBox.Checked) _countries.Add("3");
            if (kazahstanCheckBox.Checked) _countries.Add("4");
            if (russiaCheckBox.Checked == false && ukraineCheckBox.Checked == false && belarusCheckBox.Checked == false &&
                kazahstanCheckBox.Checked == false)
            {
                _countries.Add("1");
                _countries.Add("2");
                _countries.Add("3");
                _countries.Add("4");
            }
        }

        private void SetAge()
        {
            _minAge = minAgeNumericUpDown.Value;
            _maxAge = maxAgeNumericUpDown.Value;
        }

        private bool CheckGroup(string groupId)
        {
            var response = SendRequest(
                $"https://api.vk.com/method/groups.getById?group_id={groupId}&fields={"name,members_count"}&v={"5.37"}");
            var webResponseStream = ((new StreamReader(response.GetResponseStream())).ReadToEnd());
            var json = JObject.Parse(webResponseStream);

            if (json["response"] != null && (json["response"][0]["deactivated"] == null ||
                                             json["response"][0]["deactivated"].ToString() != "banned"))
            {
                _membersCount = json["response"][0]["members_count"].ToString();
                _groupName = json["response"][0]["name"].ToString();
                _groupPhotoLink = json["response"][0]["photo_50"].ToString(); //Работает с версией API 5.37.
                SetGroupInfo(_groupPhotoLink, _membersCount, _groupName);
                return true;
            }
            ShowMessageBox("Не удалось найти группу с таким ID.");
            return false;
        }

        private void SetGroupInfo(string imageLink, string membersCount, string groupName)
        {
            groupImageBox.ImageLocation = imageLink;
            membersLabel.Visible = true;
            membersCountLabel.Text = membersCount;
            groupNameTextBox.Text = groupName;
        }

        private void ResetGroupInfo()
        {
            groupImageBox.ImageLocation = "";
            membersLabel.Visible = false;
            membersCountLabel.Text = "";
            groupNameTextBox.Text = "";
        }

        private static HttpWebResponse SendRequest(string url)
        {
            try
            {
                var request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "GET";
                var response = request.GetResponse() as HttpWebResponse;
                if (response.StatusCode == HttpStatusCode.OK)
                    return response;
                return null;
            }
            catch (Exception)
            {
                ShowMessageBox("Ошибка отправки запроса");
                return null;
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            _newFile = new TheFile();

            if (_newFile.Open())
            {
                SetLabelText(fileNameLabel, _newFile.GetTheFileName());
                SetLabelText(totalNumbersLabel, _newFile.GetTheFileLength());
                ResetLabelsText();
                SetStatusLabelText("Выбран файл " + _newFile.GetTheFileName());
                startStripButton.Enabled = true;
            }
            else
            {
                startStripButton.Enabled = false;
                SetStatusLabelText("Выберите файл");
                SetLabelText(fileNameLabel, "");
                SetLabelText(totalNumbersLabel, "?");
                ResetLabelsText();
            }
        }

        private void stripPhonesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            socialPanel.Enabled = false;
            phoneStripingPanel.Enabled = true;
        }

        private void parseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            socialPanel.Enabled = true;
            phoneStripingPanel.Enabled = false;
        }

        private void startStripButton_Click(object sender, EventArgs e)
        {
            SetStripParams();
            SetStatusLabelText("Старт обработки файла");
            _newFile.SetStripParams(_numNumberLenght, _numRepeats, _geoCountry);
            if (_newFile.IsFileCleened())
                SetStatusLabelText("Идет обработка файла");
            if (_newFile.CreateFile(_newFile.DoneFile))
            {
                SetStatusLabelText("Файл успешно сохранен");
                SetLabelText(deletedNumbersLabel, _newFile.GetDeletedLinesLength());
                SetLabelText(savedNumbersLabel, _newFile.GetDoneFileLength());
            }
            else SetStatusLabelText("Файл не был сохранен");

        }

        private void VKAuthButton_Click(object sender, EventArgs e)
        {
            if (IsUrlAvailible("https://vk.com"))
            {
                var vkAuthForm = new AuthForm
                {
                    Url = string.Format("https://oauth.vk.com/authorize?client_id={0}&" +
                                        "redirect_uri=https://oauth.vk.com/blank.html&display=popup&v={1}&response_type=token",
                        ApplicationId, ApiVersion)
                };
                vkAuthForm.FormClosed += vkAuthForm_FormClosed;
                vkAuthForm.Show();
                CheckIsUserLogin();
            }
            else
                ShowMessageBox("Не удалось подключиться к сайту vk.com. Возмонжо отсутствует подключение к интернету.");
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            ResetCookiesAndTokens();
            CheckIsUserLogin();
        }

        private void vkAuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckIsUserLogin();
        }

        private void SPAHelper_Load(object sender, EventArgs e)
        {
            CheckIsUserLogin();
        }

        private void StartParseButton_Click(object sender, EventArgs e)
        {
            SetVkParams();
        }

        private void groupIdTextBox_TextChanged(object sender, EventArgs e)
        {
            ResetGroupInfo();
        }

        private void cancelParseButton_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}