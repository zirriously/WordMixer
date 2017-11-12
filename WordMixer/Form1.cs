using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private WordMixer wm = new WordMixer();

        private void ConvertTextButton_Click(object sender, EventArgs e)
        {
            wm.MixWords(InputTextBox.Text);
            OutputTextBox.Text = wm.Output;
        }
    }
}
