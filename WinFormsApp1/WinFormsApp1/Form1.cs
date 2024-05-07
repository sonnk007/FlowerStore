using BusinessLogic.Feature;
using DataAccess.Entity;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        UserBusinessLogic business = new UserBusinessLogic();
        public Form1()
        {
            InitializeComponent();
        }


        private void AddEmp_Click(object sender, EventArgs e)
        {
            DataAccess.Entity.User user = new DataAccess.Entity.User()
            {
                Uid = int.Parse(tbUID.Text == null?"":tbUID.Text),
                Address = tbAddress.Text,
                Dob= dob.Value,
                Gender = male.Checked?true:false,
                Uname = tbName.Text
            };
            business.addUser(user);

        }

        private void EditEmp_Click(object sender, EventArgs e)
        {

        }

        private void DelEmp_Click(object sender, EventArgs e)
        {

        }

        private void LoadEmpData_Click(object sender, EventArgs e)
        {
            List<DataAccess.Entity.User> users = business.getAllUsers();
            DataTable dt = new DataTable();
            dt.Columns.Add("UID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("DOB", typeof(DateTime));
            dt.Columns.Add("Gender", typeof(string));

            foreach (DataAccess.Entity.User user in users)
            {
                dt.Rows.Add(user.Uid, user.Uname, user.Address,user.Dob,user.Gender == true?"Nam":"Nữ");
            }
            dataGridView1.DataSource = dt;
        }


        private void SearchEmp_Click(object sender, EventArgs e)
        {

        }
    }
}
