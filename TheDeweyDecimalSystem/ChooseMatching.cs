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
    public partial class ChooseMatching : Form
    {


        Thread theThread;

        public ChooseMatching()
        {
            InitializeComponent();
        }

        private void btnFirstDesc_Click(object sender, EventArgs e)
        {

            theThread = new Thread(OpenDescriptionMatch);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();

        }

        private void OpenDescriptionMatch()
        {
            Application.Run(new IdentifyAreaOne());
        }

        private void btnFirstNum_Click(object sender, EventArgs e)
        {


            theThread = new Thread(OpenCallNumberMatch);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();

        }

        private void OpenCallNumberMatch()
        {
            Application.Run(new IdentifyAreaTwo());
        }

       
    }
}
