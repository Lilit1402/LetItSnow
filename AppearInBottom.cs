using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LetItSnowNY
{
    class AppearInBottom : PictureBox
    {
        public AppearInBottom()
        {
            Appear();
        }

        Random rd = new Random();
        Snowflake sf = new Snowflake();

        void Appear()
        {
                this.Location = new Point(rd.Next(0, Screen.PrimaryScreen.Bounds.Width),
                                     ((Screen.PrimaryScreen.Bounds.Height - 45)));
                this.Size = new Size(10, 10);
                this.BackgroundImage = Image.FromFile(@"C:\Users\user\Desktop\LetItSnowNY\flake2.jpg");
        }
    }
}
