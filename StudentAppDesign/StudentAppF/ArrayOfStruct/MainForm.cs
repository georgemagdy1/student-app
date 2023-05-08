using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ArrayOfStruct
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new insertForm().Show();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DisplayForm().Show();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchDeleteForm().Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void displayStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DisplayForm().Show();
        }
        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new insertForm().Show();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchDeleteForm().Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchDeleteForm().Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
