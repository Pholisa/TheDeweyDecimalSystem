using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDeweyDecimalSystem
{
    public partial class Form1 : Form
    {

        Thread theThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            theThread = new Thread(OpenOptionForm);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();


        }

        private void OpenOptionForm()
        {
            Application.Run(new TheOptions());
        }
    }
}
//--------------------------------------------------------End of File------------------------------------------------------------------------------------------//
