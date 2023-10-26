using RandomNumber;
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
    public partial class IdentifyAreaTwo : Form
    {
        Thread theThread;

        MatchingColumns mc = new MatchingColumns();

        private RadioButton[] buttons;


        private RadioButton[] buttonDescription;

        public string saveValue;
        public String saveDescription;



        public IdentifyAreaTwo()
        {

            InitializeComponent();
            Assigning();
            AssigningDescription(); 

        }
        public void Assigning()
        {

            // All button added to the array
            buttons = new RadioButton[]
            {
                rbtnButtonOne,
                rbtnButtonTwo,
                rbtnButtonThree,
                rbtnButtonFour

            };

            mc.GenerateDeweyNumbers();

            List<string> deweyNumber = mc.usedDeweyNumbers;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = deweyNumber[i];
            }


        }

       
        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        public void AssigningDescription()
        {


            // All button added to the array
            buttonDescription = new RadioButton[]
            {
                rbtnDescriptOne,
                rbtnDescriptTwo,
                rbtnDescriptThree,
                rbtnDescriptFour,
                rbtnDescriptFive,
                rbtnDescriptSix,
                rbtnDescriptSeven

            };


            mc.ShuffleMatchedDescriptions();

            List<string> descriptions = mc.descriptionsList;

            for (int i = 0; i < buttonDescription.Length; i++)
            {
                buttonDescription[i].Text = descriptions[i];
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (rbtnButtonOne.Checked )
            {
                saveValue = rbtnButtonOne.Text;
               
                MessageBox.Show("Number " + saveValue  );

            }
            else if (rbtnButtonTwo.Checked)
            {
                saveValue = rbtnButtonTwo.Text;

                MessageBox.Show("Number " + saveValue);
            }
            else if (rbtnButtonThree.Checked)
            {
                saveValue = rbtnButtonThree.Text;

                MessageBox.Show("Number " + saveValue);
            }
            else if (rbtnButtonFour.Checked)
            {
                saveValue = rbtnButtonFour.Text;

                MessageBox.Show("Number " + saveValue);
            }
            else
            {
                MessageBox.Show("Try again");
            }


        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//


        private void btnCaptureDesc_Click(object sender, EventArgs e)
        {
            mc.GenerateDeweyNumbers();


        RadioButton[] radioButtonArray = { rbtnDescriptOne, rbtnDescriptTwo, rbtnDescriptThree, rbtnDescriptFour };
        RadioButton[] buttonArray = { rbtnButtonOne, rbtnButtonTwo, rbtnButtonThree, rbtnButtonFour };

            if (rbtnDescriptFive.Checked || rbtnDescriptSix.Checked || rbtnDescriptSeven.Checked)
            {
                saveDescription = "Incorrect!";
                MessageBox.Show(saveDescription);
                return;
            }
            else {

                for (int i = 0; i < radioButtonArray.Length; i++)
                {
                    if (radioButtonArray[i].Checked)
                    {
                        saveValue = buttonArray[i].Text;
                        saveDescription = radioButtonArray[i].Text;

                        MessageBox.Show("Call Number: " + saveValue + "  Description: " + saveDescription);
                        MessageBox.Show("Your Match:" + "\n" + "Call Number: " + saveValue + "  Description: " + saveDescription
                                            + "\n" + "\n" + "Correct Match:" + "\n" + mc.thenumberAndDesc[i]);
                        break; // Assuming you want to exit the loop after finding the checked radio button.
                    }
                }
        }



    }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnOptions_Click(object sender, EventArgs e)
        {

            theThread = new Thread(OpenOptionsForm);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void OpenOptionsForm()
        {
            Application.Run(new TheOptions());
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnNew_Click(object sender, EventArgs e)
        {
            theThread = new Thread(OpenCallNumberMatch);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void OpenCallNumberMatch()
        {
            Application.Run(new IdentifyAreaTwo());
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            theThread = new Thread(OpenGame);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void OpenGame()
        {
            Application.Run(new Game());
        }
    }
        }


//-------------------------------------------------------------EndOfFile-------------------------------------------------------------------------------------//




