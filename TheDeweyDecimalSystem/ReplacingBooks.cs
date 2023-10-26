using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomNumber;

namespace TheDeweyDecimalSystem
{

    public partial class ReplacingBooks : Form
    {
        // Declare a variable to hold a reference to a thread object
        Thread theThread;

        GenerateRandom rn = new GenerateRandom();

        private Button[] buttons;

        private string[] originalOrder;

        public string view;
 
        public int score = 0 ;

        //Ability to enable dragging of items
        private bool isDragging = false;

        //coordinates
        private Point startPoint;
        private Control selectedButton = null;


        //--------------------------------------------------------------------------------------------------------------------------------------------------//
        public ReplacingBooks()
        {
            InitializeComponent();

            Moving();
            Assigning();

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//
        //Reference:
        //How to Move an Image using Drag and Drop in Windows Form and C#. Moo ICT. 17 April 2023. Available at: https://www.youtube.com/watch?v=hF0PuwdajNM [accessed 25 September 2023].

        //Enabling dragging of the button to move down
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
                selectedButton = sender as Control;


            }
        }

        //Enabling dragging of the button to move left or right 
        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Control movingButton = sender as Control;
                Point newLocation = this.PointToClient(Control.MousePosition);
                selectedButton.Location = new Point(newLocation.X - startPoint.X, newLocation.Y - startPoint.Y);


            }
        }

        //Enabling dragging of the button to move up
        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            selectedButton = null;

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        //Reference:
        //How to Move an Image using Drag and Drop in Windows Form and C#. Moo ICT. 17 April 2023. Available at: https://www.youtube.com/watch?v=hF0PuwdajNM [accessed 25 September 2023].
        public void Moving()
        {
            //Allowing the book buttons to be moved, book 1
            btnBookOne.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookOne.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookOne.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 2
            btnBookTwo.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookTwo.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookTwo.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 3
            btnBookThree.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookThree.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookThree.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 4
            btnBookFour.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookFour.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookFour.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 5
            btnBookFive.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookFive.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookFive.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 6
            btnBookSix.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookSix.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookSix.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 7
            btnBookSeven.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookSeven.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookSeven.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 8
            btnBookEight.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookEight.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookEight.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 9
            btnBookNine.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookNine.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookNine.MouseUp += new MouseEventHandler(button_MouseUp);

            //Allowing the book buttons to be moved, book 10
            btnBookTen.MouseDown += new MouseEventHandler(button_MouseDown);
            btnBookTen.MouseMove += new MouseEventHandler(button_MouseMove);
            btnBookTen.MouseUp += new MouseEventHandler(button_MouseUp);
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

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

        //--------------------------------------------------------------------------------------------------------------------------------------------------//


        private void btnExit_Click(object sender, EventArgs e)
        {
            //close programme
            this.Close();

        }


        //------------------------Redirecting to the Replacing Books Form------------------------------------------------------------------------------------------//
        //Reference
        //Fix Error! Could not Copy "obj\Debug\name.exe to bin\Debug\name.exe In visual Studio Program Run. Nour Karim Tech. 3 April 2022. Available at: https://www.youtube.com/watch?v=w0AoMXuKKvs [accessed 26 September 2023].
        private void btnGenerate_Click(object sender, EventArgs e)
        {

            theThread = new Thread(OpenReplaceForm);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
            this.Close();
        }

        //Calling the Replacing Books Form
        private void OpenReplaceForm()
        {
            Application.Run(new ReplacingBooks());
        }

        //---------------------Assidning the random numbers to the buttons and the listbox---------------------------------------------------------------------------------------------//
        public void Assigning()
        {
            // All button added to the array
            buttons = new Button[]
            {
                btnBookOne,
                btnBookTwo,
                btnBookThree,
                btnBookFour,
                btnBookFive,
                btnBookSix,
                btnBookSeven,
                btnBookEight,
                btnBookNine,
                btnBookTen

            };

            List<string> deweyNumbers = new List<string>();

            foreach (Button button in buttons)
            {
                // Generating a Dewey Decimal number
                string deweyNumber = rn.DeweyDecimalGenerate();

                // Assign the generated number to each button in the array
                button.Text = deweyNumber;

                // Adding the generated Dewey Decimal number to the list
                deweyNumbers.Add(deweyNumber);
            }

            // Using LINQ to sort the Dewey Decimal numbers.
            // The numbers will be sorted first then the letters.
            var sortedDeweyNumbers = deweyNumbers.OrderBy(number => number).ThenBy(number => number.Substring(7)).ToList();

            // Clear the items in listBox1, to avoid iteration
            listBox1.Items.Clear();

            // Adding the sorted Dewey Decimal numbers to the ListBox
            foreach (var sortedNumber in sortedDeweyNumbers)
            {
                listBox1.Items.Add(sortedNumber);
            }

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            //list box of the correct order will show once this button is clicked.
            listBox1.Visible = true;

            // Increase the user's score by one
            score++;

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        //Redirecting to the Manual One Form
        private void btnManual_Click(object sender, EventArgs e)
        {
            theThread = new Thread(OpenManualForm);
            theThread.SetApartmentState(ApartmentState.STA);
            theThread.Start();
        }

        //Calling the Manual One Form
        private void OpenManualForm()
        {
            Application.Run(new ManualOne());
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
                theThread = new Thread(OpenAchievementsForm);
                theThread.SetApartmentState(ApartmentState.STA);
                theThread.Start();
            }

            //Calling the Achievements Form
            private void OpenAchievementsForm()
            {
                Application.Run(new Achievements());


            }

        
    }
   
}
//------------------------------------------------------End Of File--------------------------------------------------------------------------------------------//
