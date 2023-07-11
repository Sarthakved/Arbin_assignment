using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Assignment
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        string name;
        string number;
        string hobbies;
        string gender;
        string programming_language;

        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


        public void display()
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Number");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Hobbies");
            dt.Columns.Add("Programming Language");

            DataRow dr = dt.NewRow();
            dr[0] = name;
            dr[1] = number;
            dr[2] = gender;
            dr[3] = programming_language;
            dr[4] = hobbies;

            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;
        }
        public void empty()
        {
            textName.Text = "";
            textNumber.Text = "";
            textHobbies.Text = "";

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            name = textName.Text;
            number = textNumber.Text;
            hobbies = textHobbies.Text;


            if (rbtmale.Checked)
            {
                gender = "Male";

            }
            else if (rbtfemale.Checked)
            {
                gender = "Female";

            }
            else
            {
                gender = "Other";
            }
            display();
            empty();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbplanguage.Items.Add("C/C++");
            cmbplanguage.Items.Add("C#");
            cmbplanguage.Items.Add("VB");
            cmbplanguage.Items.Add("Delphi");
        }

        private void cmbplanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
          programming_language = cmbplanguage.SelectedItem.ToString();
        }
    }
}
