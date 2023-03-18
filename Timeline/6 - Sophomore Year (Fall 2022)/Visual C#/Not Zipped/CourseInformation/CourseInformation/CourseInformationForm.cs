using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CourseInformation
{
    public partial class CourseInformationForm : Form
    {
        protected struct Information // Able to holds information about a particular course
        {
            public string roomNumber, instructor, meetingTime;

            public Information(string rn, string inst, string mt) // Allows new instances of the stuct
            {                                                     // to automatically hold information
                roomNumber = rn;
                instructor = inst;
                meetingTime = mt;
            }
        }

        // Dictionary that will hold all course info
        private Dictionary<string, Information> courses = new Dictionary<string, Information>();

        public CourseInformationForm()
        {
            InitializeComponent();
            CreateCourseDictionary();

            // Adds the course numbers from the dictionary to the combobox options
            foreach (string courseNumber in courses.Keys)
            {
                if (courseNumber != "")
                {
                    courseNumberComboBox.Items.Add(courseNumber);
                }
            }
        }

        private void CreateCourseDictionary()
        {
            courses.Add("", new Information("", "", "")); // Used to clear the screen

            try
            {
                // Opens CourseInformation.txt
                StreamReader courseInfoTextFile = new StreamReader("CourseInformation.txt");

                // Takes the course information and adds it to the dictionary
                while (!courseInfoTextFile.EndOfStream)
                {
                    try
                    {
                        string[] info = courseInfoTextFile.ReadLine().Split(',');

                        courses.Add(info[0], new Information(info[1], info[2], info[3]));
                    }

                    catch // Tells the user if a line from the text file could not be read
                    {
                        MessageBox.Show("Due to an error, a course could not be added.");
                    }
                }

                courseInfoTextFile.Close(); // closes the text file
            }

            // If the app is unable to get the text file, the user will get an error message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void courseNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Holds information about the selected course
            Information information = courses[$"{courseNumberComboBox.SelectedItem}"];

            //Lines below display the selected course information to the user
            roomNumberOutputLabel.Text = information.roomNumber;
            instructorOutputLabel.Text = information.instructor;
            meetingTimeOutputLabel.Text = information.meetingTime;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            courseNumberComboBox.SelectedIndex = -1; // Makes it so that the combobox has nothing selected
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
