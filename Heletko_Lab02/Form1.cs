using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heletko_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            int intP = Convert.ToInt32(pEncTextBox.Text, 16);
            int intKey = Convert.ToInt32(keyEncTextBox.Text, 16);
            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16).ToUpper();
            cEncTextBox.Text = strC;
            cDecTextBox.Text = strC;
            keyDecTextBox.Text = keyEncTextBox.Text;
            intP = intC ^ intKey;
            string strP = Convert.ToString(intP, 16).ToUpper();
            pDecTextBox.Text = strP;
            hexLabel.Text = String.Format("16 формат: P = {0}, KEY = {1}, C = {2}", strP, keyEncTextBox.Text, strC);
            string decStrP = Convert.ToString(intP, 10);
            string decStrKey = Convert.ToString(intKey, 10);
            string decStrC = Convert.ToString(intC, 10);
            decLabel.Text = String.Format("10 формат: P = {0}, KEY = {1}, C = {2}", decStrP, decStrKey, decStrC);
            string binStrP = Convert.ToString(intP, 2);
            string binStrKey = Convert.ToString(intKey, 2);
            string binStrC = Convert.ToString(intC, 2);
            binLabel.Text = String.Format("2 формат: P = {0}, KEY = {1}, C = {2}", binStrP, binStrKey, binStrC);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pEncTextBox.Text = "";
            keyEncTextBox.Text = "";
            cEncTextBox.Text = "";
            pDecTextBox.Text = "";
            keyDecTextBox.Text = "";
            cDecTextBox.Text = "";
            binLabel.Text = "2 формат:";
            decLabel.Text = "10 формат:";
            hexLabel.Text = "16 формат:";
        }
    }
}
