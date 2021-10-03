using BasicWinform.Entities1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinForm
{
    public partial class User : Form
    {
        Person person;
        public User(string idPerson = "1")
        {
            InitializeComponent();
            person = Person.Get(idPerson);
            if (person!= null)
            {
                //cach 1 
                txtHoTen.Text = $"{person.LastName} {person.FirstName} ";
                //cach 2 
                txtHoTen.Text = person.FullName;
                dtpNgaySinh.Value = person.DOB;
                if(person.Sex == EGioiTinh.Nam)
                    rdNam.Checked =true;
                else if (person.Sex == EGioiTinh.Nu)
                    rdNu.Checked = true;
                else 
                    rdKhac.Checked = true;

                txtQueQuan.Text = person.HomeTown;
              
            }
           var ds = History.GetList();
            historyBindingSource.DataSource = ds;
            gridSinhVien1.DataSource = historyBindingSource;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMau_Click(object sender, EventArgs e)
        {
            if (ThuVienColor.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = ThuVienColor.Color;
            }
        }
    }
}
