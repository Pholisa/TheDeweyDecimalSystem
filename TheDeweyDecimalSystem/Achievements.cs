using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheDeweyDecimalSystem
{

    public partial class Achievements : Form
    {

        public Achievements()
        {
            InitializeComponent();

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//


        /*
       Reference:
       Rotating in c# Visual Studio By Rohit Programming Zone. Robit Programming Zone. 25 May 2021. Available at: https://www.youtube.com/watch?v=bpOzRUz5Fes [Accessed 25 September 2023].  
        */

        //these variables are created to for the image size, the position and the angle.
        int cx = 190, cy = 150, rx = 150, ry = 150;
        float angle;

        //accessing the image
        Bitmap image = Properties.Resources.badge;


        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Graphics gc = e.Graphics;

            gc.RotateTransform(angle, MatrixOrder.Append);
            //method to set the image position
            gc.TranslateTransform(cx, cy, MatrixOrder.Append);
           //method to allow drawing and set the image size
            gc.DrawImage(image, -rx/2, -ry/2, rx, ry);


        }

        private void btnGetBadge_Click_1(object sender, EventArgs e)
        {
            //when timer start, the image rotates
            theTimer.Start();
            btnGetBadge.Visible = false;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//


        private void theTimer_Tick(object sender, EventArgs e)
        {
            angle += 2;
            Invalidate();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnGetBadge_Click(object sender, EventArgs e)
        {

            btnGetBadge.Visible = false;
            theTimer.Start();


        }
    }
}
//----------------------------------------------End of file-------------------------------------------------------------------------------------------------------//
