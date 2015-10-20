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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SPA_Helper
{
    class TheFile
    {
        private OpenFileDialog _openFileDialog;
        private Stream _myStream;
        private int _numNumberLenght;
        private int _numRepeats;
        private int _geoCountry;
        private string _fileName = "";
        private string[] _fileLines;
        private static readonly string[] NumBank = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

        internal string[] DoneFile
        {
            get;
            private set;
        }

        public bool Open()
        {
            _openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files | *.txt",
                Title = "Выберите файл с номерами телефонов",
                Multiselect = false,
                InitialDirectory = @"C:\"
            };

            if (_openFileDialog.ShowDialog() != DialogResult.OK) return false;
            ReadOpenedFile();
            return true;
        }

        private void ReadOpenedFile()
        {
            try
            {
                if ((_myStream = _openFileDialog.OpenFile()) != null)
                {
                    using (_myStream)
                    {
                        _fileName = _openFileDialog.SafeFileName;
                        _fileLines = File.ReadAllLines(_openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: Невозможно прочитать файл с диска. Оригинальный текст ошибки: " + ex.Message);
            }
        }
        public void SetStripParams(int numNumberLenght, int numRepeats,  int geoCountry)
        {
            _numNumberLenght = numNumberLenght;
            _numRepeats = numRepeats;
            _geoCountry = geoCountry;
        }

        public bool IsFileCleened()
        {
            CleanFile();
            if (DoneFile != null)
                return true;
            return false;
        }

        private void CleanFile()
        {
            var clearedFileLines = new List<string>();
            for (var i = 0; i < _fileLines.Length; i++)
            {
                var clearedLine = RemovePlusMinusSpaceFromLine(_fileLines[i]);
                if (IsSkipLine(clearedLine)) continue;
                var doneLine = clearedLine.Substring(clearedLine.Length - _numNumberLenght);
                clearedFileLines.Add(doneLine);
            }
            DoneFile = clearedFileLines.Distinct().ToArray();
        }

        private bool IsSkipLine(string line)
        {
            for (var i = 0; i < NumBank.Length; i++)
            {
                if (IsLineContainsRepeats(line) || line.Length < _numNumberLenght || IsLineContainsBadChars(line) || !IsGeoRight(line))
                    return true;
            }
            return false;
        }

        private bool IsGeoRight(string line)
        {
            if (GetGeoRightNumber(line) == _geoCountry) return true;
            if (GetGeoRightNumber(line) == 1234) return true;
            return false;
        }

        private static int GetGeoRightNumber(string line)
        {
            if (line.Length < 10) return 100;
            if (line.Substring(0, 2) == "79") return 0;
            if (line.First() == '0' || line.Substring(0, 2) == "38") return 1;
            if (line.Substring(0, 3) == "375") return 2;
            if (line.Substring(0, 2) == "77") return 3;
            return 1234;
        }

        private bool IsLineContainsRepeats(string line)
        {
            return NumBank.Any(t => line.Contains(new string(Convert.ToChar(t), _numRepeats)));
        }

        private static bool IsLineContainsBadChars(string line)
        {
            return !line.All(char.IsDigit);
        }

        private static string RemovePlusMinusSpaceFromLine(string input)
        {
            var charsToRemove = new[] { " ", "-", "+",  "(", ")", "/"};
            input = charsToRemove.Aggregate(input, (current, s) => current.Replace(s, ""));
            if (!Regex.IsMatch(input.Last().ToString(), @"^\d+$")) input = input.Replace(input.Last().ToString(), "");
            return input;
        }

        public bool CreateFile(string[] doneFile)
        {
            var saveFileDialog = new SaveFileDialog
            {
                OverwritePrompt = true,
                Filter = "Text Files |*.txt",
                Title = "Выберите имя и путь для файла",
                FileName = "Номера"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return false;
            var name = saveFileDialog.FileName;
            File.WriteAllLines(name, doneFile, Encoding.UTF8);
            return true;
        }

        public string GetTheFileName()
        {
            return _fileName;
        }

        public string GetTheFileLength()
        {
            return _fileLines.Length.ToString();
        }

        public string GetDoneFileLength()
        {
            return DoneFile.Length.ToString();
        }

        public string GetDeletedLinesLength()
        {
            return (Convert.ToInt32(_fileLines.Length) - Convert.ToInt32(DoneFile.Length)).ToString();
        }
    }
}
