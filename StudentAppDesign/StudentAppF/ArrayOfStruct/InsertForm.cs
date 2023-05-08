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
    public partial class insertForm : Form
    {
        public insertForm()
        {
            InitializeComponent();
        }
        public struct student
        {
            public int id;
            public string name;
        };

        public static List<student> studList = new List<student>();
     
        private void addBtn_Click(object sender, EventArgs e)
        {
           
        }        
        
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
  
    }
}
