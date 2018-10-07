using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DevilsConsilium
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

    

        private void newButton_Click(object sender, EventArgs e)
        {
            PlannerPage page = new PlannerPage();
            page.Show();
        }

        //Loading from data.bin file
        private void openButton_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open("data.bin", FileMode.Open);
            BinaryFormatter bin = new BinaryFormatter();
            //Putting saved courseList into temp variable.
            List<Courses>[] tmpCourseList = (List<Courses>[])bin.Deserialize(stream);

            //Make a new planner page
            PlannerPage page = new PlannerPage();
            page.LoadUpCourseList(tmpCourseList);
            stream.Close();

            page.Show();
        }

     
    }
}
