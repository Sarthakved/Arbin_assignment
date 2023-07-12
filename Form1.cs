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
using System.Data.SqlClient;

namespace Assignment
{
    public partial class Form1 : Form
    {
       
        string programming_language;

        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
  
       public void empty()
        {
            textName.Text = "";
            textNumber.Text = "";
            textHobbies.Text = "";

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string name = textName.Text;
            string number = textNumber.Text;
            string hobbies = textHobbies.Text;
            string gender;
            programming_language= cmbplanguage.Text;
            


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
           
            empty();

            //1. address of sql server and database
            string ConnectionString = "Data Source=LAPTOP-P1T1QA7E\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";

            //2. establish connection
            SqlConnection con = new SqlConnection(ConnectionString);

            //3. open connection
            con.Open();

            //4. prepare query
            string Query = "INSERT INTO Names (FirstName, Number, Gender, Programming_language, Hobbies) VALUES ('"+name+"', '"+number+"', '"+gender+"', '"+programming_language+"', '"+hobbies+"')";
            
            //5. execute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            //6. close connection
            con.Close();

            MessageBox.Show("Data has been saved");
           displayGrid();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbplanguage.Items.Add("C/C++");
            cmbplanguage.Items.Add("C#");
            cmbplanguage.Items.Add("VB");
            cmbplanguage.Items.Add("Delphi");

            
            displayGrid();
        }

        private void cmbplanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
          programming_language = cmbplanguage.SelectedItem.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBox();       
            
             
            
            
        }
        public void displayGrid()
        {
            string ConnectionString = "Data Source=LAPTOP-P1T1QA7E\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Names";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;            
            con.Close();

        }

        public void SearchBox()
        {
            string ConnectionString = "Data Source=LAPTOP-P1T1QA7E\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();
            String searchQuery = "SELECT * FROM Names WHERE FirstName = '" + textSearch.Text + "' or Number = '"+textSearch.Text+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-P1T1QA7E\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Names SET FirstName = '"+textSearch.Text+"' WHERE FirstName = '"+textName.Text+"'";
            cmd.ExecuteNonQuery(); 
            con.Close();
            displayGrid();
            MessageBox.Show("Updated succesfully");


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP-P1T1QA7E\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from Names WHERE FirstName = '" + textName.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displayGrid();
            MessageBox.Show("deleted succesfully");
        }
    }
}
