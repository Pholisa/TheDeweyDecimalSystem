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


    public partial class IdentifyAreaOne : Form
    {

        Thread theThread;

        MatchingColumnsTwo mc = new MatchingColumnsTwo();

        private RadioButton[] buttons;

        private RadioButton[] buttonNumbers;

        public string saveValue;
        public String saveDescription;

        public IdentifyAreaOne()
        {
            InitializeComponent();
            Assigning();
            AssigningNumbers();

        }
        public void Assigning()
        {

            // All button added to the array
            buttons = new RadioButton[]
            {
                rbtnDescOne,
                rbtnDescTwo,
                rbtnDescThree,
                rbtnDescFour

            };

            mc.GenerateRandomDescriptionsAndNumbers();
            List<string> theDescription = mc.descriptionsList;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = theDescription[i];
            }



        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        public void AssigningNumbers()
        {


            // All button added to the array
            buttonNumbers = new RadioButton[]
            {
                rbtnNumberOne,
                rbtnNumberTwo,
                rbtnNumberThree,
                rbtnNumberFour,
                rbtnNumberFive,
                rbtnNumberSix,
                rbtnNumberSeven

            };

            mc.GenerateRandomDescriptionsAndNumbers();

            mc.ShuffleDeweyNumbers();   

            List <string> theDescription = mc.GetAllDeweyNumbers();

            for (int i = 0; i < buttonNumbers.Length; i++)
            {
                buttonNumbers[i].Text = theDescription[i];
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

            theThread = new Thread(OpenOptionsForm);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();

        }

        private void OpenOptionsForm()
        {
            Application.Run(new TheOptions());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            theThread = new Thread(OpenCallNumberMatch);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();
        }

        private void OpenCallNumberMatch()
        {
            Application.Run(new IdentifyAreaOne());
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (rbtnDescOne.Checked)
            {
                saveValue = rbtnDescOne.Text;

                MessageBox.Show("Description " + saveValue);

            }
            else if (rbtnDescTwo.Checked)
            {
                saveValue = rbtnDescTwo.Text;

                MessageBox.Show("Description " + saveValue);
            }
            else if (rbtnDescThree.Checked)
            {
                saveValue = rbtnDescThree.Text;

                MessageBox.Show("Description " + saveValue);
            }
            else if (rbtnDescFour.Checked)
            {
                saveValue = rbtnDescFour.Text;

                MessageBox.Show("Description " + saveValue);
            }
            else
            {
                MessageBox.Show("Try again");
            }
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

        private void btnCaptureDescript_Click(object sender, EventArgs e)
        {
          
                mc.DeweyDecimalGenerate();


                RadioButton[] radioButtonArray = {  rbtnDescOne,
                rbtnDescTwo,
                rbtnDescThree,
                rbtnDescFour };
                RadioButton[] buttonArray = { rbtnNumberOne,
                rbtnNumberTwo,
                rbtnNumberThree,
                rbtnNumberFour, };

                if (rbtnNumberFive.Checked || rbtnNumberSix.Checked || rbtnNumberSeven.Checked)
                {
                    saveDescription = "Incorrect!";
                    MessageBox.Show(saveDescription);
                    return;
                }
                else
                {

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
    }
}
