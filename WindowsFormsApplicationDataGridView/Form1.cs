using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplicationDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void peopleDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("You clicked Row: " + e.RowIndex + "and the column is: " + e.ColumnIndex);
        }

         List<Person> peopleList = new List<Person>();

        private void Form1_Load(object sender, EventArgs e)
        {
            peopleDataGridView.AutoGenerateColumns = true;
            //set DataGrid columns and rows
            peopleDataGridView.RowCount = 5;
            peopleDataGridView.ColumnCount = 3;

            //create Persson
            var p1 = new Person();
            p1.createPerson("Azeez", "Odumosu", "Martorell", 23);
            var p2 = new Person();
            p1.createPerson("fdfdfdc", "nmhmhmh", "Martoreltrtrtrl", 23);
            var p3 = new Person();
            p1.createPerson("cxcxc", "7i7i7", "dddddvvv", 23);
            var p4 = new Person();
            p1.createPerson("rgrr", "o9o97", "Martvdvddvdvdorell", 23);
            var p5 = new Person();
            p1.createPerson("Azeez", "Odumosu", "dvrgttrv", 23);

            //ArrayList of people to populate in the datagridview
            peopleList.Add(p1);
            peopleList.Add(p2);
            peopleList.Add(p3);
            peopleList.Add(p4);
            peopleList.Add(p5);
            //peopleList.Add(new Person(){"asasasa", 1,Name = "XX"});

            //Display List in DatagridView
            //use binding source to hold dummy data
           

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                peopleDataGridView.DataSource = peopleList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
