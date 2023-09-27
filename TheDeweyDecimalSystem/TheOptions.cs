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
    public partial class TheOptions : Form
    {

        Thread theThread;
        public TheOptions()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnExit_Click(object sender, EventArgs e)
        { 
            this.Close();

        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnReplaceBooks_Click(object sender, EventArgs e)
        {

            theThread = new Thread(OpenReplacingForm);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();
            //ReplacingBooks replace = new ReplacingBooks();
            //replace.Show();
            //Visible = false;

        }

        private void OpenReplacingForm()
        {
            Application.Run(new ReplacingBooks());
        }


    }
}
//---------------------------------------------------------End Of File------------------------------------------------------------------------------------------------------//
