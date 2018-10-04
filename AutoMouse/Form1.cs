using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace AutoMouse
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics x;
        Color[] colorPixel;
        Label lblSelectColor;

        int[] X, Y;
        byte[] keyASCII;

        int control;

        public Form1()
        {
            InitializeComponent();
            reset();           
        }

        private void reset() {
            bmp = new Bitmap(1, 1);
            x = Graphics.FromImage(bmp);

            sbyte qt = 3;

            colorPixel = new Color[qt];
            X = new int[qt];
            Y = new int[qt];
            keyASCII = new byte[qt];
        }

        private void lblSelectColor123_Click(object sender, EventArgs e)
        {            
            //captura qual componente foi selecionado
            lblSelectColor = (Label)sender;
            //control para identificar componentes nos vetores equivalente ao objeto
            control = Convert.ToInt32(lblSelectColor.Tag) - 1;
            lblInformation.Visible = true;
            timerCordenadas.Start();
        }

        //capture pixel color    
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        private void timerCordenadas_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F6) == -32767) //F6
            {
                timerCordenadas.Stop();
                lblInformation.Visible = false;
            }
            
            X[control] = Cursor.Position.X;
            Y[control] = Cursor.Position.Y;

            x.CopyFromScreen(new Point(X[control], Y[control]), new Point(0, 0), bmp.Size);

            //Inteligent color reference: https://www.flextool.com.br/tabela_cores.html Blue4 min 2 with 139 to white by Caio 
            lblSelectColor.ForeColor = colorPixel[control].R + colorPixel[control].G + colorPixel[control].B < 278 ? Color.White : Color.Black;
            
            colorPixel[control] = bmp.GetPixel(0, 0);
            string colorRgb = "R:" + colorPixel[control].R + " G:" + colorPixel[control].G + " B:" + colorPixel[control].B;
            string position = "X:" + Cursor.Position.X + " Y:" + Cursor.Position.Y;
            lblSelectColor.BackColor = colorPixel[control];
            lblSelectColor.Text = position +"\n"+ colorRgb;
        }

        private void txtKeyPress123_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txtKeyPress = (TextBox)sender;
            //pega o ultimo caracter do nome do botao que é numero
            int x = Convert.ToInt32(txtKeyPress.Tag) - 1;
            keyASCII[x] = (byte)e.KeyValue;
            txtKeyPress.Text = e.KeyCode.ToString() + "(" + keyASCII[x].ToString() + ")";
        }

        private void lblAtivar_Click(object sender, EventArgs e)
        {
            switch(lblAtivar.BorderStyle)
            {
                case Border3DStyle.Raised:
                    lblAtivar.BorderStyle = Border3DStyle.Sunken;
                    toolStripStatusLabel1.Text = "Status: Ativado";
                    
                    timerPressKey.Start();
                    break;
                case Border3DStyle.Sunken:
                    timerPressKey.Stop();

                    toolStripStatusLabel1.Text = "Status: Desativado";
                    lblAtivar.BorderStyle = Border3DStyle.Raised;
                    break;
                default:
                    break;
            }
        }
       
        int ticked;  //-------------ONLY VISUAL---------------
        int printed; //-------------ONLY VISUAL---------------
        int sendKey; //-------------ONLY VISUAL---------------
        private void timerPressKey_Tick(object sender, EventArgs e)
        {
            ++ticked;
            for (int i = 0; i < keyASCII.Length; i++)
            {
                //se tiver alguma tecla predefinida
                if (keyASCII[i] != 0) {
                    x.CopyFromScreen(new Point(X[i], Y[i]), new Point(0, 0), bmp.Size);
                    Color colorPixeln = bmp.GetPixel(0, 0);
                    ++printed;
                    //se houver aluma alteracao na cor antiga capturada com a cor atual
                    if (colorPixeln != colorPixel[i])
                    {
                        sendKeys(keyASCII[i]);
                        ++sendKey;
                    }
                }
            }
            lblPrinted.Text = "ticks: " + ticked+"\nprints: "+printed+"\nkeyPress: "+sendKey;
        }

        const uint KEYEVENTF_KEYUP = 0x0002;
        const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private void sendKeys(byte keyascii) {
            keybd_event(keyascii, 0, 0, 0);;
            keybd_event(keyascii, 0, KEYEVENTF_KEYUP, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)   
                if (ctrl is TextBox)                
                    (ctrl as TextBox).Enabled = !checkBox1.Checked;

            numericUpDown1.Enabled = !checkBox1.Checked;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timerPressKey.Interval = (int)numericUpDown1.Value;
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            timerPressKey.Interval = (int)numericUpDown1.Value;
        }

        private void lblTest_MouseClick(object sender, MouseEventArgs e)
        {
            new Form2test().Show();
        }
    }
}

/*
      melhorar: performace thead
              diminuir condicoes do laco for(para caso usar apenas 1 autoKey)
              acoplar o maximo em thead;
*/
