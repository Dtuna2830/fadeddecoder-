using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FadedDecoder.Utils;

namespace FadedDecoder
{
    public partial class MainWindowForm : Form
    {
        bool useDecode = true;
        bool useEncode = false;
        public MainWindowForm()
        {
            InitializeComponent();
        }

        public void Output(string msg)
        {
            if (outputClearCheckbox.Checked) b64OutputBox.Clear();
            b64OutputBox.AppendText(msg + "\r\n");
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            if (this.Controls.ContainsKey("uc_foo"))
                this.Controls["uc_foo"].Dispose();

            string inputText = b64InputBox.Text;
            if (useDecode)
            {
                string decodedString = utils.DecodeBase64(inputText);
                Output(decodedString);
            }
            if (useEncode)
            {
                string encodedString = utils.EncodeBase64(inputText);
                Output(encodedString);
            }
        }

        private void encodeOption_CheckedChanged(object sender, EventArgs e)
        {
            if (encodingSwitcher.Checked)
            {
                decodeButton.Text = "Encode";
                useEncode = true;
                useDecode = false;
            } else
            {
                decodeButton.Text = "Decode";
                useDecode = true;
                useEncode = false;
            }
        }
       
        bool tutus;
        int fareX, fareY;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - fareX;
                this.Top = Cursor.Position.Y - fareY;

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            fareX = 0;
            fareY = 0;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            fareX = Cursor.Position.X - this.Left;
            fareY = Cursor.Position.Y - this.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
