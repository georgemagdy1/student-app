using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArrayOfStruct
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
}
