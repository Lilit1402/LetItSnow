using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetItSnowNY
{
    class Snowflake : PictureBox
    {

        public Snowflake()
        {
            Create();
            MoveMe();
        }

        Random rd = new Random();

        void Create()
        {
            this.Location = new Point(rd.Next(0, Screen.PrimaryScreen.Bounds.Width), (rd.Next(0)));
            this.Size = new Size(10, 10);
            this.BackgroundImage = Image.FromFile(@"C:\Users\user\Desktop\LetItSnowNY\flake2.jpg");
        }

        void MoveMe()
        {
            Timer t = new Timer();
            t.Interval = 40;

            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            this.Location += new Size(0, 3);

            if (this.Location.X > Screen.PrimaryScreen.Bounds.Width || this.Location.Y > Screen.PrimaryScreen.Bounds.Height - 45)
            {
                this.Location = new Point(rd.Next(0, Screen.PrimaryScreen.Bounds.Width), (rd.Next(0)));
            }
        }
    }
}
