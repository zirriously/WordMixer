using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordMixer
{
    public class WordMixer
    {
        private List<string> _inputList = new List<string>();
        private string _output;
        Random _random = new Random(System.DateTime.Now.Millisecond);

        public void MixWords(string inputString)
        {
            _inputList.Clear();
            _output = "";
            // Splitting string into list _inputList
            Char splitter = ' ';
            String[] subStrings = inputString.Split(splitter);

            foreach (string subString in subStrings)
            {
                _inputList.Add(subString);
            }

            // Randomisation of each word, keeping first and last letter the same
            foreach (string value in _inputList)
            {
                Char firstChar = value[0];
                Char lastChar = value[value.Length - 1];

                for (int i = 1; i < value.Length -1; i++)
                {
                    
                }
            }

            foreach (var value in _inputList)
            {
                _output += " " + value;
            }
            

        }

        public string Output
        {
            get { return _output; }
        }
    }
}