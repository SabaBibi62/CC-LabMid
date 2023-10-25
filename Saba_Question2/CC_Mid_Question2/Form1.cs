using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_Mid_Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            LL1Parser parser = new LL1Parser(input);
            parser.Parse();
            if (parser.currentPosition == input.Length)
            {
                ResultLabel.Text = "The input is valid.";
            }
            else
            {
                ResultLabel.Text = "The input is invalid.";
            }
        }
    }
}
