using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Ecc;
using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec.Util;

namespace qr_gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image QRGen(string input, int qrlevel)
        {
            string toenc = input;
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            // Level 12 L - max 367 alphanumerics
            qe.QRCodeVersion = qrlevel;
            System.Drawing.Bitmap bm = qe.Encode(toenc);
            return bm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            qr_pic.Image = QRGen(qrtext.Text, Convert.ToInt32(qrlev.Text));
        }

        private void qrtext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void qrlev_SelectedIndexChanged(object sender, EventArgs e)
        {
            int caseSwitch = Convert.ToInt32(qrlev.Text);
            switch (caseSwitch)
            {
               case  1:
	                qrtext.MaxLength = 17;
               break;
                case 2:
	                qrtext.MaxLength = 32;
               break;
                case 3:
	                qrtext.MaxLength = 53;
               break;
                case 4:
	                qrtext.MaxLength = 78;
               break;
                case 5:
	                qrtext.MaxLength = 108;
               break;
                case 6:
	                qrtext.MaxLength = 134;
               break;
                case 7:
	                qrtext.MaxLength = 154;
               break;
                case 8:
	                qrtext.MaxLength = 192;
               break;
                case 9:
	                qrtext.MaxLength = 230;
               break;
                case 10:
	                qrtext.MaxLength = 271;
               break;
                case 11:
	                qrtext.MaxLength = 321;
               break;
                case 12:
	                qrtext.MaxLength = 367;
               break;
                case 13:
	                qrtext.MaxLength = 425;
               break;
                case 14:
	                qrtext.MaxLength = 458;
               break;
                case 15:
	                qrtext.MaxLength = 520;
               break;
                case 16:
	                qrtext.MaxLength = 586;
               break;
                case 17:
	                qrtext.MaxLength = 644;
               break;
                case 18:
	                qrtext.MaxLength = 718;
               break;
                case 19:
	                qrtext.MaxLength = 792;
               break;
                case 20:
	                qrtext.MaxLength = 858;
               break;
            }
            tlen.Text = qrtext.MaxLength.ToString();
        }

        private void tlen_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            qr_pic.Image.Save(Application.StartupPath+@"\Code_" + DateTime.Now.ToString("d_MM_yy_HH_mm_ss") + ".png");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
