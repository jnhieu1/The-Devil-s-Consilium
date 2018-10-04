using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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

        Courses sItem = null;
        int sSelectedIndex = 0;
        ListBox sListBox;
        int sListBoxIndex = 0;


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
            yearOneSpringListBox.DisplayMember = "CourseNumber";
            yearOneSummerListBox.DisplayMember = "CourseNumber";
            yearTwoFallListBox.DisplayMember = "CourseNumber";
            yearTwoSpringListBox.DisplayMember = "CourseNumber";
            yearTwoSummerListBox.DisplayMember = "CourseNumber";
            yearThreeFallListBox.DisplayMember = "CourseNumber";
            yearThreeSpringListBox.DisplayMember = "CourseNumber";
            yearThreeSummerListBox.DisplayMember = "CourseNumber";
            yearFourFallListBox.DisplayMember = "CourseNumber";
            yearFourSpringListBox.DisplayMember = "CourseNumber";
            yearFourSummerListBox.DisplayMember = "CourseNumber";

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
                if(courseList[i].CourseNumber.Contains(searchText) && IsInPlanner(courseList[i].CourseNumber))
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
            courseInfoLabel.Text += "\nGS:";

            int counter = 0;

            if (searchResultList[searchResultListBox.SelectedIndex].L == true)
            {
                courseInfoLabel.Text += " " + "L";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].MA == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "MA";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].CS == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "CS";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].HU == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "HU";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].SB == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "SB";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].SQ == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "SQ";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].SG == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "SG";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].C == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "C";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].G == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "G";
                counter++;
            }
            if (searchResultList[searchResultListBox.SelectedIndex].MA == true)
            {
                if (counter >= 1)
                    courseInfoLabel.Text += " &&";
                courseInfoLabel.Text += " " + "H";
                counter++;
            }
            if (counter == 0)
            {
                courseInfoLabel.Text += " " + "None";
            }

            courseInfoLabel.Text += "\nPre-requisite(s): ";

            if (searchResultList[searchResultListBox.SelectedIndex].PreRecs != null)
            {
                counter = 0;
                foreach (string s in searchResultList[searchResultListBox.SelectedIndex].PreRecs)
                {
                    if (counter >= 1)
                        courseInfoLabel.Text += ", ";
                    courseInfoLabel.Text += s;
                    counter++;
                }
            }
            else
                courseInfoLabel.Text += "None";

            item = (Courses)searchResultListBox.SelectedItem;
            selectedIndex = searchResultListBox.SelectedIndex;


            //yearOneFallListBox.DoDragDrop(searchResultListBox.SelectedItem.ToString(), DragDropEffects.Copy);
            searchResultListBox.DoDragDrop(searchResultListBox.SelectedItem.ToString(), DragDropEffects.Copy);

        }

        private void semesterListBox_MouseDown(object sender, MouseEventArgs e)
        {
            sItem = null;

            var listBox = sender as ListBox;

            if (listBox.SelectedItem != null)
            {
                sItem = (Courses)listBox.SelectedItem;
                sSelectedIndex = listBox.SelectedIndex;
                //MessageBox.Show(Convert.ToString(sSelectedIndex));

                sListBox = listBox;
                sListBoxIndex = listBox.TabIndex;

                listBox.DoDragDrop(listBox.SelectedItem.ToString(), DragDropEffects.Copy);
            }
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
                var listBox = sender as ListBox;

                if (CanAddToCurrentSemester(listBox.TabIndex, item))
                {
                    listBox.Items.Add(item);

                    plannerList[listBox.TabIndex].Add(item);

                    searchResultListBox.Items.Remove(item);
                    searchResultList.RemoveAt(selectedIndex);

                    item = null;
                    selectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Cannot add course to this semester due to pre-rec mismatch.");
                }
            }
        }



        //Method to search through plannerList, listAdded to represents current semster and courseToAdd is copy of course we want to add.
        private bool CanAddToCurrentSemester(int listAddedTo, Courses courseToAdd)
        {
            //Make a list to hold every pre-req string
            List<string> listForPreReqs = new List<string>();
            if (courseToAdd.PreRecs != null)
            {
                //Populate pre-req list
                for (int q = 0; q < courseToAdd.PreRecs.Length; q++)
                {
                    listForPreReqs.Add(courseToAdd.PreRecs[q]);
                }

                //Looping through semester
                for (int i = 0; i <= listAddedTo - 1; i++)
                {
                    //Looping through Courses in the semester
                    for (int j = 0; j < plannerList[i].Count; j++)
                    {
                        //Loop through the pre-req list 
                        for (int k = 0; k < listForPreReqs.Count; k++)
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
                if (listForPreReqs.Count > 0)
                {
                    return false;
                }
                //If the list was emptied completely return true, signalling that the pre-reqs existed in past semesters
                else
                {
                    return true;
                }
            }
            return true;
        }

        private void searchResultListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (sItem != null)
            {
                var listBox = sender as ListBox;
                searchResultListBox.Items.Add(sItem);

                //plannerList[listBox.TabIndex].Add(item);
                searchResultList.Add(sItem);


                //searchResultListBox.Items.Remove(item);
                //searchResultList.RemoveAt(selectedIndex);
                
                sListBox.Items.Remove(sItem);

                
                plannerList[sListBoxIndex].RemoveAt(sSelectedIndex);

                sItem = null;
                sSelectedIndex = 0;
                sListBox = null;
                sListBoxIndex = 0;
            }
        }

        //Save button
        private void saveCourseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (plannerList != null)
            {
                //Try to put our courseList object in the data.bin file.
                try
                {
                    Stream stream = File.Open("data.bin", FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, plannerList);
                    stream.Close();
                }
                catch (IOException)
                {

                }
            }
        }

        //Load button function call for homepage
        public void LoadUpCourseList(List<Courses>[] list)
        {
            //Loop through every semester
            for(int i = 0; i < list.Count(); i++)
            {
                //Loop through every course in a semester
                for(int j = 0; j < list[i].Count(); j++)
                {
                    //Insert course into planner
                    plannerList[i].Add(list[i][j]);

                    //Adding the course to the semester listbox
                    DisplayAddedCourse(list[i][j], i);
                }
            }

            //Fix up searchresultlistbox
            SearchResultsFix(list);
        }

        //Course display on load
        public void DisplayAddedCourse(Courses toAdd, int semester)
        {
            switch(semester)
            {
                case 0:
                    yearOneFallListBox.Items.Add(toAdd);
                    break;
                case 1:
                    yearOneSpringListBox.Items.Add(toAdd);
                    break;
                case 2:
                    yearOneSummerListBox.Items.Add(toAdd);
                    break;
                case 3:
                    yearTwoFallListBox.Items.Add(toAdd);
                    break;
                case 4:
                    yearTwoSpringListBox.Items.Add(toAdd);
                    break;
                case 5:
                    yearTwoSummerListBox.Items.Add(toAdd);
                    break;
                case 6:
                    yearThreeFallListBox.Items.Add(toAdd);
                    break;
                case 7:
                    yearThreeSpringListBox.Items.Add(toAdd);
                    break;
                case 8:
                    yearThreeSummerListBox.Items.Add(toAdd);
                    break;
                case 9:
                    yearFourFallListBox.Items.Add(toAdd);
                    break;
                case 10:
                    yearFourSpringListBox.Items.Add(toAdd);
                    break;
                case 11:
                    yearFourSummerListBox.Items.Add(toAdd);
                    break;
            }
        }

        //Method to reorganize searchResultsListBox after load
        public void SearchResultsFix(List<Courses>[] list)
        {
            //Clear listbox and list
            searchResultListBox.Items.Clear();
            searchResultList.Clear();

            //Add courses back to search list if the course is not on the planner already.
            for (int i = 0; i < courseList.Count; i++)
            {
                if (IsInPlanner(courseList[i].CourseNumber))
                {
                    searchResultList.Add(courseList[i]);
                }
            }

            //Display the newly corrected list.
            for (int i = 0; i < searchResultList.Count(); i++)
            {
                searchResultListBox.Items.Add(searchResultList[i]);
            }
        }

        //Tells if the plannerList has a course in it given courseNum (to be used with searching to not redisplay courses in planner
        public bool IsInPlanner(string courseNum)
        {
            bool add = true;

            for(int i = 0; i < plannerList.Length; i++)
            {
                for(int j = 0; j < plannerList[i].Count(); j++)
                {
                    if (plannerList[i][j].CourseNumber == courseNum)
                    {
                        add = false;
                    }
                }
            }

            return add;
        }
    }
}
