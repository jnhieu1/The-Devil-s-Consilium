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
        //CourseList is for the initial population and it will contain every course
        static List<Courses> courseList;
        //SearchResultList will have searchresults and will modify the searchresults listbox
        List<Courses> searchResultList;
        //PlannerList is the representation of the whole planner in order of semester
        // Ex: plannerList[1] will contain a List of Course objects copied on add to exactly mirror each semester's contained courses.
        List<Courses>[] plannerList;
        //Item for using in drag drop
        Courses item = null;

        int selectedIndex = 0;


        public PlannerPage()
        {
            InitializeComponent();
            
            //Initializing Courses, courselist and planner list
            CourseCreator courseCreator = new CourseCreator();
            courseList = courseCreator.InitiateList();
            plannerList = new List<Courses>[12];

            for(int hello = 0; hello < plannerList.Length; hello++)
            {
                plannerList[hello] = new List<Courses>();
            }

            searchResultListBox.DisplayMember = "CourseNumber";
            yearOneFallListBox.DisplayMember = "CourseNumber";

            searchResultList = courseCreator.InitiateList();

            //Setting the items from courseList to the searchResultListBox
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

        //private void searchResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    courseInformationListBox.Items.Clear();
        //    courseInformationListBox.Items.Add(searchResultList[searchResultListBox.SelectedIndex].CourseNumber);
        //    courseInformationListBox.Items.Add(searchResultList[searchResultListBox.SelectedIndex].CourseName);
        //    courseInformationListBox.Items.Add(searchResultList[searchResultListBox.SelectedIndex].CourseDescription);
        //    courseInformationListBox.Items.Add(searchResultList[searchResultListBox.SelectedIndex].NumOfCredits);
        //    courseInformationListBox.Items.Add("L: " + searchResultList[searchResultListBox.SelectedIndex].L);
        //    courseInformationListBox.Items.Add("MA: " + searchResultList[searchResultListBox.SelectedIndex].MA);
        //    courseInformationListBox.Items.Add("CS: " + searchResultList[searchResultListBox.SelectedIndex].CS);
        //    courseInformationListBox.Items.Add("HU: " + searchResultList[searchResultListBox.SelectedIndex].HU);
        //    courseInformationListBox.Items.Add("SB: " + searchResultList[searchResultListBox.SelectedIndex].SB);
        //    courseInformationListBox.Items.Add("SQ: " + searchResultList[searchResultListBox.SelectedIndex].SQ);
        //    courseInformationListBox.Items.Add("SG: " + searchResultList[searchResultListBox.SelectedIndex].SG);
        //    courseInformationListBox.Items.Add("C: " + searchResultList[searchResultListBox.SelectedIndex].C);
        //    courseInformationListBox.Items.Add("G: " + searchResultList[searchResultListBox.SelectedIndex].G);
        //    courseInformationListBox.Items.Add("H: " + searchResultList[searchResultListBox.SelectedIndex].H);
        //}

        private void searchResultListBox_MouseDown(object sender, MouseEventArgs e)
        {
            item = null;
            courseInfoLabel.Text = "";

            courseInfoLabel.Text += "Number: " + searchResultList[searchResultListBox.SelectedIndex].CourseNumber;
            courseInfoLabel.Text += "\n\nName: " + searchResultList[searchResultListBox.SelectedIndex].CourseName;

            if (searchResultList[searchResultListBox.SelectedIndex].CourseDescription.Length >= 235)
            {
                courseInfoLabel.Text += "\n\nDescription: " + searchResultList[searchResultListBox.SelectedIndex].CourseDescription.Substring(0,235) + "...";
            }
            else
            {
                courseInfoLabel.Text += "\n\nDescription: " + searchResultList[searchResultListBox.SelectedIndex].CourseDescription;
            }

            courseInfoLabel.Text += "\n\nCredits: " + Convert.ToString(searchResultList[searchResultListBox.SelectedIndex].NumOfCredits);
            courseInfoLabel.Text += "\nGS: ";

            if (searchResultList[searchResultListBox.SelectedIndex].L == true)
            {
                courseInfoLabel.Text += " " + "L";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].MA == true)
            {
                courseInfoLabel.Text += " " + "MA";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].CS == true)
            {
                courseInfoLabel.Text += " " + "CS";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].HU == true)
            {
                courseInfoLabel.Text += " " + "HU";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].SB == true)
            {
                courseInfoLabel.Text += " " + "SB";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].SQ == true)
            {
                courseInfoLabel.Text += " " + "SQ";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].SG == true)
            {
                courseInfoLabel.Text += " " + "SG";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].C == true)
            {
                courseInfoLabel.Text += " " + "C";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].G == true)
            {
                courseInfoLabel.Text += " " + "G";
            }
            else if (searchResultList[searchResultListBox.SelectedIndex].MA == true)
            {
                courseInfoLabel.Text += " " + "H";
            }
            else
            {
                courseInfoLabel.Text += " " + "None";
            }

            item = (Courses)searchResultListBox.SelectedItem;
            selectedIndex = searchResultListBox.SelectedIndex;
            yearOneFallListBox.DoDragDrop(searchResultListBox.SelectedItem.ToString(), DragDropEffects.Copy);
            
        }

        

        private void yearOneFallListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }

            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void yearOneFallListBox_DragDrop(object sender, DragEventArgs e)
        {
            //item is a Course object stored when the mousebutton is pressed down in the searchResultListbox
            if (item != null)
            {
                yearOneFallListBox.Items.Add(item);

                plannerList[0].Add(item);

                searchResultListBox.Items.Remove(item);
                searchResultList.RemoveAt(selectedIndex);
                
                item = null;
                selectedIndex = 0;
            }
        }

        //private void PopulateDetails(Courses course)
        //{
        //    courseInformationListBox.Items.Clear();
        //    courseInformationListBox.Items.Add(course.CourseNumber);
        //    courseInformationListBox.Items.Add(course.CourseName);
        //    courseInformationListBox.Items.Add(course.CourseDescription);
        //    courseInformationListBox.Items.Add(course.NumOfCredits);
        //    courseInformationListBox.Items.Add("L: " + course.L);
        //    courseInformationListBox.Items.Add("MA: " + course.MA);
        //    courseInformationListBox.Items.Add("CS: " + course.CS);
        //    courseInformationListBox.Items.Add("HU: " + course.HU);
        //    courseInformationListBox.Items.Add("SB: " + course.SB);
        //    courseInformationListBox.Items.Add("SQ: " + course.SQ);
        //    courseInformationListBox.Items.Add("SG: " + course.SG);
        //    courseInformationListBox.Items.Add("C: " + course.C);
        //    courseInformationListBox.Items.Add("G: " + course.G);
        //    courseInformationListBox.Items.Add("H: " + course.H);
        //}

        //Method to search through plannerList, listAdded to represents current semster and courseToAdd is copy of course we want to add.
        private bool CanAddToCurrentSemester(int listAddedTo, Courses courseToAdd)
        {
            //Make a list to hold every pre-req string
            List<string> listForPreReqs = new List<string>();

            //Populate pre-req list
            for(int q = 0; q < courseToAdd.PreRecs.Length; q++)
            {
                listForPreReqs.Add(courseToAdd.PreRecs[q]);
            }

            //Looping through semester
            for(int i = 0; i < listAddedTo - 1; i++)
            {
                //Looping through Courses in the semester
                for(int j = 0; j < plannerList[i].Count; j++)
                {
                    //Loop through the pre-req list 
                    for(int k = 0; k < listForPreReqs.Count; k++)
                    {
                        //Loop through pre-req list to see if a single course is anywhere in the pre-req list
                        if (plannerList[i][j].CourseNumber == listForPreReqs[k])
                        {
                            //If the pre-req was found, remove it from the pre-req list
                            listForPreReqs.Remove(plannerList[i][j].CourseNumber);
                        }
                    }
                }
            }
            //If the pre-req list wasn't completely emptied return false
            if(listForPreReqs.Count > 0)
            {
                return false;
            }
            //If the list was emptied completely return true, signalling that the pre-reqs existed in past semesters
            else
            {
                return true;
            }
        }
    }
}
