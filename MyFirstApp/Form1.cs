using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        Timer Timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            Timer.Tick += Timer_Tick;

            Timer.Interval = 1000;

            Timer.Start();

            this.Text = DateTime.Now.ToLongTimeString();

        
            //add label 
            Label mylabel = new Label();
            mylabel.Location = new Point(130, 250);
            mylabel.ForeColor = Color.DeepSkyBlue;
            mylabel.Text = "Hello C#";
            mylabel.Font = new Font("Comic Sans MS", 36, FontStyle.Bold);
            mylabel.AutoSize = true;

            this.Controls.Add(mylabel);
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongTimeString();

            timeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.Orange;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.AliceBlue;
            }
            //string message = $"X : {e.X}  Y : {e.Y}";
            //MessageBox.Show(message);
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            if(sender is Button bt)
            {
                bt.Dispose();

                Button button = new Button();
                button.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                button.Text = "Click Me";
                button.AutoSize = true;
                button.Click += clickBtn_Click;

                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);
                button.Location = new Point(randomX, randomY);

                this.Controls.Add(button);




            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("Mouse Down");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Mouse Up");
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            //this.BackColor = Color.Red;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //this.BackColor = Color.Black;
        }

        private void clickBtn_MouseEnter(object sender, EventArgs e)
        {
            clickBtn.BackColor = Color.Blue;
        }
    }
}
