﻿using System;
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
        public PlannerPage()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = "";
            searchText = searchTextBox.Text;
        }
    }
}
