using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetItSnowNY
{
    public partial class Form1 : Form
    {
        Timer t;
        Snowflake[] snowArray;
        AppearInBottom[] snowArray2; // = new AppearInBottom();
        int interval = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true; // above other layers
            this.Location = new Point(0, 0); // screen covering
            this.Size = Screen.PrimaryScreen.Bounds.Size + (new Size(20, 20));
            this.BackColor = Color.Black; // form background color is black to see white snowflakes
            this.TransparencyKey = Color.Black; // black background is transformed into transparent to see the desktop
            this.FormBorderStyle = FormBorderStyle.None; // no borders

            snowArray = new Snowflake[50]; // The whole number of snowflakes within each Timer
            snowArray2 = new AppearInBottom[50];

            t = new Timer();
            t.Interval = 1000;

            t.Tick += T_Tick; // when one is elapsed and another one is called
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (interval >= 50)
            {
                t.Stop();
                return;
            }

            snowArray[interval] = new Snowflake();
            snowArray2[interval] = new AppearInBottom();

            Controls.Add(snowArray[interval]); // adding snowflakes to the form
            Controls.Add(snowArray2[interval]);

            interval++;

        }
    }
}
