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
        static List<Courses> courseList;
        List<Courses> searchResultList;

        public PlannerPage()
        {
            InitializeComponent();

            CourseCreator courseCreator = new CourseCreator();
            courseList = courseCreator.InitiateList();
            searchResultListBox.DisplayMember = "CourseNumber";

            searchResultList = courseCreator.InitiateList();

            for (int i = 0; i < courseList.Count; i++)
            {
                searchResultListBox.Items.Add(courseList[i]);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResultListBox.Items.Clear();
            string searchText = "";
            searchText = searchTextBox.Text;
            searchText = searchText.ToUpper();

            //List<Courses> searchResultList;
            searchResultList.Clear();

            for (int i = 0; i<courseList.Count;i++)
            {
                if(courseList[i].CourseNumber.Contains(searchText))
                {
                    searchResultList.Add(courseList[i]);
                }
            }
            
            if (searchResultList.Count == 0)
            {
                MessageBox.Show("No Results Found");
            }
            else
            {
                for (int i = 0; i < searchResultList.Count; i++)
                {
                    searchResultListBox.Items.Add(searchResultList[i]);
                }
            }

        }

        private void searchResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            courseInformationListBox.Items.Clear();
            courseInformationListBox.Items.Add(searchResultList[searchResultListBox.SelectedIndex].CourseNumber);
            courseInformationListBox.Items.Add(searchResultList[searchResultListBox.SelectedIndex].CourseName);
            courseInformationListBox.Items.Add(searchResultList[searchResultListBox.SelectedIndex].CourseDescription);
            courseInformationListBox.Items.Add(searchResultList[searchResultListBox.SelectedIndex].NumOfCredits);
            courseInformationListBox.Items.Add("L: " + searchResultList[searchResultListBox.SelectedIndex].L);
            courseInformationListBox.Items.Add("MA: " + searchResultList[searchResultListBox.SelectedIndex].MA);
            courseInformationListBox.Items.Add("CS: " + searchResultList[searchResultListBox.SelectedIndex].CS);
            courseInformationListBox.Items.Add("HU: " + searchResultList[searchResultListBox.SelectedIndex].HU);
            courseInformationListBox.Items.Add("SB: " + searchResultList[searchResultListBox.SelectedIndex].SB);
            courseInformationListBox.Items.Add("SQ: " + searchResultList[searchResultListBox.SelectedIndex].SQ);
            courseInformationListBox.Items.Add("SG: " + searchResultList[searchResultListBox.SelectedIndex].SG);
            courseInformationListBox.Items.Add("C: " + searchResultList[searchResultListBox.SelectedIndex].C);
            courseInformationListBox.Items.Add("G: " + searchResultList[searchResultListBox.SelectedIndex].G);
            courseInformationListBox.Items.Add("H: " + searchResultList[searchResultListBox.SelectedIndex].H);




        }
    }
}
