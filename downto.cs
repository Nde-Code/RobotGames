using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RobotGames
{
    public class downto
    {
        public int downPower = 30;
        public int currentLeft
        {
            get;
            set;
        }
        public int currentTop
        {
            get;
            set;
        }

        PictureBox downProj = new PictureBox();
        Timer clockRegDown = new Timer();

        public void DownPlayer(Form form)
        {
            downProj.Size = new Size(10, 10);
            downProj.Name = "LaunchDown";
            //downProj.BackColor = Color.Black;
            downProj.Left = currentLeft;
            downProj.Top = currentTop;
            downProj.BringToFront();

            form.Controls.Add(downProj);
            clockRegDown.Interval = 30;
            clockRegDown.Tick += new EventHandler(throwDown);
            clockRegDown.Start();
        }

        private void throwDown(object sender, EventArgs e)
        {
            downProj.Top += downPower;
            if (downProj.Top < 10 || downProj.Top > 830)
            {
                clockRegDown.Stop();
                downProj.Dispose();
                clockRegDown.Dispose();
                clockRegDown = null;
                downProj = null;
            }
        }
    }
}