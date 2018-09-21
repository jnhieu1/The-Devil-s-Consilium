using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevilsConsilium
{
    public partial class PlannerPage : Form
    {
        List<Courses> courseList;

        public PlannerPage()
        {
            InitializeComponent();

            CourseCreator courseCreator = new CourseCreator();
            courseList = courseCreator.InitiateList();
            searchResultListBox.DisplayMember = "CourseNumber";

            for(int i = 0; i < courseList.Count; i++)
            {
                searchResultListBox.Items.Add(courseList[i]);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = "";
            searchText = searchTextBox.Text;
        }

        private void searchResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseInformationListBox.Items.Clear();
            courseInformationListBox.Items.Add(courseList[searchResultListBox.SelectedIndex].CourseNumber);
            courseInformationListBox.Items.Add(courseList[searchResultListBox.SelectedIndex].CourseName);
            courseInformationListBox.Items.Add(courseList[searchResultListBox.SelectedIndex].CourseDescription);
            courseInformationListBox.Items.Add(courseList[searchResultListBox.SelectedIndex].NumOfCredits);
            courseInformationListBox.Items.Add("L: " + courseList[searchResultListBox.SelectedIndex].L);
            courseInformationListBox.Items.Add("MA: " + courseList[searchResultListBox.SelectedIndex].MA);
            courseInformationListBox.Items.Add("CS: " + courseList[searchResultListBox.SelectedIndex].CS);
            courseInformationListBox.Items.Add("HU: " + courseList[searchResultListBox.SelectedIndex].HU);
            courseInformationListBox.Items.Add("SB: " + courseList[searchResultListBox.SelectedIndex].SB);
            courseInformationListBox.Items.Add("SQ: " + courseList[searchResultListBox.SelectedIndex].SQ);
            courseInformationListBox.Items.Add("SG: " + courseList[searchResultListBox.SelectedIndex].SG);
            courseInformationListBox.Items.Add("C: " + courseList[searchResultListBox.SelectedIndex].C);
            courseInformationListBox.Items.Add("G: " + courseList[searchResultListBox.SelectedIndex].G);
            courseInformationListBox.Items.Add("H: " + courseList[searchResultListBox.SelectedIndex].H);




        }
    }
}
