using BasicWinform.Entities1;
using BasicWinForm.Entities1;
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
    public partial class frmLopHoc : Form
    {
        bool flag = true;
        public frmLopHoc()
        {
            InitializeComponent();
           /* List<String> lsKhoa = new List<String>();
            lsKhoa.Add("Khoa CNTT");
            lsKhoa.Add("Khoa Vật Lý");
            lsKhoa.Add("Khoa Hóa Học");
            lsKhoa.Add("Khoa Kiến Trúc");
            lsKhoa.Add("Khoa Toán");*/
            flag = false;
            cmbKhoa.DataSource = Faculty.GetList();
            cmbKhoa.DisplayMember = "Name";
            cmbKhoa.ValueMember = "Id";
            flag = true;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag = true)
            {
                var index = cmbKhoa.SelectedIndex;
                var item = cmbKhoa.SelectedItem as Faculty;
                var lsPerson = Person.GetList(item.Id);
                personBindingSource.DataSource = lsPerson;
                gridPerson.DataSource = personBindingSource;
                gridPerson.DataSource = lsPerson;

            }
        }

        private void Khoa_Click(object sender, EventArgs e)
        {

        }
    }
}
