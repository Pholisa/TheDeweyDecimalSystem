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
    public partial class ManualOne : Form
    {

        Thread theThread;
        public ManualOne()
        {
            InitializeComponent();
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        //Redirecting to the Manual Two Form
        private void btnNext_Click(object sender, EventArgs e)
        {
            theThread = new Thread(OpenManualForm);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();
        }

        //Calling the Manual Two Form
        private void OpenManualForm()
        {
            Application.Run(new ManualTwo());
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
//------------------------------------------------------------End of file--------------------------------------------------------------------------------------//
