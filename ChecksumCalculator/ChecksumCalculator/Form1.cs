using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ChecksumCalculator
{
    public partial class ChecksumCalculator : Form
    {
        public ChecksumCalculator()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.favicon;
        }

        private void ButtonGetChecksum_Click(object sender, EventArgs e)
        {
            try
            {
                int total = 0;

                for (int i = 0; i < textBoxInput.Text.Length; i += 2)
                {
                    char[] charPair = new char[] { textBoxInput.Text[i], textBoxInput.Text[i + 1] };
                    total += Convert.ToInt32(new string(charPair), 16);
                }

                string fullResult = ((~(total & 0xFF)) + 1).ToString("X");
                Result.Text = new string(new char[] { fullResult[fullResult.Length - 2], fullResult[fullResult.Length - 1] });
            }
            catch(Exception ex)
            {
                Result.Text = ex.ToString();
            }
        }
    }
}
