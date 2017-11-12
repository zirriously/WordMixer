using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordMixer
{
    public class WordMixer
    {
        private List<string> _inputList = new List<string>();
        private string _output;

        public void MixWords(string inputString)
        {
            Char splitter = ' ';
            String[] subStrings = inputString.Split(splitter);
            foreach (string subString in subStrings)
            {
                _inputList.Add(subString);
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