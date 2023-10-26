using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDeweyDecimalSystem
{
    //References:
    //https://youtu.be/frDKP-A71W0?si=Ne9K5UtwqKYbgIEP
    public partial class Game : Form
    {

        Random random = new Random();

        //Assiging the icons using the webdings font
        List<string> icons = new List<string>()
        {
            "E", "E", "L", "L", "D", "D", "G", "G",
            "H" , "H" , "I" , "I" ,"P", "P" , "N" , "N"
        };

        //declaring variables
        Label firstClicked, secondClicked;
        public Game()
        {
            InitializeComponent();
            AssignIcons();
        }

        //allow clicking abilities
        private void clickLabel(object sender, EventArgs e)
        {

            if(firstClicked != null && secondClicked != null) return;
            Label labelClicked = sender as Label;

            if(labelClicked == null)
                return;

            //if clicked change color to  white color
            if(labelClicked.ForeColor == Color.White)
                return;

            if(firstClicked == null)
            {
                firstClicked = labelClicked;
                firstClicked.ForeColor = Color.White;
                return;
            }

            secondClicked = labelClicked;
            secondClicked.ForeColor = Color.White;

            CheckWinner();

            if(firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                //start the time
                timer1.Start();



        }

        // user has matched all the icons
        private void CheckWinner()
        {
            Label theLabels;
            for(int i = 0;i < tableLayoutPanel1.Controls.Count;i++)
            {
                theLabels = tableLayoutPanel1.Controls[i] as Label;
                if (theLabels != null && theLabels.ForeColor == theLabels.BackColor)
                    return;
            }
            MessageBox.Show("Congratulations!!!!"+"\n"+"You have managed to match all the ICONS!");
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void AssignIcons()
        {
            Label theLabel;
            int theRandomNumber;

            for(int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    theLabel = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                theRandomNumber = random.Next(0, icons.Count);
                theLabel.Text = icons[theRandomNumber];

                //remove clicked
                icons.RemoveAt(theRandomNumber);
            }

        }
    }
}


//---------------------------------------------------------------------EndOfFile-------------------------------------------------------------------------------------------------///