using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMouse
{
    public partial class Form2test : Form
    {      
        sbyte[] i;
        Bitmap[] bmp;
        Graphics g;
        int speed;
        bool gameRunning;

        public Form2test()
        {
            InitializeComponent();
            KeyPreview = true;
            speed = 100;
            resetGame();
        }     

        private void resetGame()
        {
            i = new sbyte[3];
            //create bitmap
            bmp = new Bitmap[3];
            //get bitmap pictureBox dimension
            bmp[0] = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp[1] = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            bmp[2] = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            
            paint_drawing(bmp[0], Color.Red, pictureBox1, 0);
            paint_drawing(bmp[1], Color.Green, pictureBox2, 1);
            paint_drawing(bmp[2], Color.Blue, pictureBox3, 2);
        }

        private void paint_drawing(Bitmap bmpp, Color color, PictureBox pcb, sbyte index)
        {   
            g = Graphics.FromImage(bmpp);
            g.Clear(color);
            g.FillRectangle(Brushes.CornflowerBlue, new Rectangle(0, 0, pcb.Width, (int)(i[index] * pcb.Height / 100.0)));

            pcb.Image = bmpp;

            i[index] += 3;
            if (i[index] > 100)
            {                
                g.Dispose();
                gameRunning = false;

                buttonsEnabled(false);

                paint_drawing(bmp[0], Color.Red, pictureBox1, 0);
                paint_drawing(bmp[1], Color.Green, pictureBox2, 1);
                paint_drawing(bmp[2], Color.Blue, pictureBox3, 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i[0] = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i[1] = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i[2] = 0;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {            
            resetGame();
            buttonsEnabled(true);

            if (!gameRunning)            
                startGame();
        }

        private async void startGame()
        {
            gameRunning = true;
            while (gameRunning)
            {
                paint_drawing(bmp[0], Color.Red, pictureBox1, 0);
                paint_drawing(bmp[1], Color.Green, pictureBox2, 1);
                paint_drawing(bmp[2], Color.Blue, pictureBox3, 2);
                await Task.Delay(speed);
            }
        }

        private void Form2test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1) 
                button1.PerformClick();            
            else if (e.KeyCode == Keys.D2) 
                button2.PerformClick();
            else if (e.KeyCode == Keys.D3) 
                button3.PerformClick();
        }

        private void buttonsEnabled(bool enabled)
        {
            button1.Enabled = enabled;
            button2.Enabled = enabled;
            button3.Enabled = enabled;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {            
            speed = Math.Abs((trackBar1.Value * 10 - 99) * 1);           
        }
    }
}
