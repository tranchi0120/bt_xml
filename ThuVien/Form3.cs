using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class Form3 : Form
    {
        nhanvienBLL bllsv;
        public Form3()
        {
            InitializeComponent();
            bllsv = new nhanvienBLL();
        }
        public void showAllnhanvien()
        {
            DataTable dt = bllsv.getALLnhanvien();
            dataGridView1.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            showAllnhanvien();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtmanv.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
                return false;
            }
            return true;
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Nhanvien s = new Nhanvien();
                s.manv = txtmanv.Text;
                s.tennv = txttennv.Text;
                s.gioitinh = txtgioitinh.Text;
                s.diachi = txtdiachi.Text;
                s.cmnd = txtcmnd.Text;
                s.email = txtemail.Text;
                s.dienthoai = txtsdt.Text;
                s.capnhat = txtcapnhat.Text;
                if (bllsv.Insertnhanvien(s))
                    showAllnhanvien();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtmanv.Text = dataGridView1.Rows[index].Cells["manv"].Value.ToString();
                txttennv.Text = dataGridView1.Rows[index].Cells["tennv"].Value.ToString();
                txtgioitinh.Text = dataGridView1.Rows[index].Cells["gioitinh"].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[index].Cells["diachi"].Value.ToString();
                txtcmnd.Text = dataGridView1.Rows[index].Cells["cmnd"].Value.ToString();
                txtemail.Text = dataGridView1.Rows[index].Cells["email"].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[index].Cells["dienthoai"].Value.ToString();
                txtcapnhat.Text = dataGridView1.Rows[index].Cells["capnhat"].Value.ToString();
            }
        }






        private void txtensv_TextChanged(object sender, EventArgs e)
        {
            string value = txttennv.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllsv.Findnhanvien(value);
                dataGridView1.DataSource = dt;
            }
            else
                showAllnhanvien();
        }
        



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtmanv.Text = dataGridView1.Rows[index].Cells["manv"].Value.ToString();
                txttennv.Text = dataGridView1.Rows[index].Cells["tennv"].Value.ToString();
                txtgioitinh.Text = dataGridView1.Rows[index].Cells["gioitinh"].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[index].Cells["diachi"].Value.ToString();
                txtcmnd.Text = dataGridView1.Rows[index].Cells["cmnd"].Value.ToString();
                txtemail.Text = dataGridView1.Rows[index].Cells["email"].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[index].Cells["dienthoai"].Value.ToString();
                txtcapnhat.Text = dataGridView1.Rows[index].Cells["capnhat"].Value.ToString();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {

                Nhanvien s = new Nhanvien();
                txtmanv.Enabled = false;
                s.manv = txtmanv.Text;
                s.tennv = txttennv.Text;
                s.gioitinh = txtgioitinh.Text;
                s.diachi = txtdiachi.Text;
                s.cmnd = txtcmnd.Text;
                s.email = txtemail.Text;
                s.dienthoai = txtsdt.Text;
                s.capnhat = txtcapnhat.Text;
                if (bllsv.Updatenhanvien(s))
                    showAllnhanvien();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }



        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa hay không??", "thông báo lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Nhanvien s = new Nhanvien();
                s.manv = txtmanv.Text;

                if (bllsv.DELETEnhanvien(s))
                    showAllnhanvien();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtmanv.Text = dataGridView1.Rows[index].Cells["manv"].Value.ToString();
                txttennv.Text = dataGridView1.Rows[index].Cells["tennv"].Value.ToString();
                txtgioitinh.Text = dataGridView1.Rows[index].Cells["gioitinh"].Value.ToString();
                txtdiachi.Text = dataGridView1.Rows[index].Cells["diachi"].Value.ToString();
                txtcmnd.Text = dataGridView1.Rows[index].Cells["cmnd"].Value.ToString();
                txtemail.Text = dataGridView1.Rows[index].Cells["email"].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[index].Cells["dienthoai"].Value.ToString();
                txtcapnhat.Text = dataGridView1.Rows[index].Cells["capnhat"].Value.ToString();
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string value = txttennv.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllsv.Findnhanvien(value);
                dataGridView1.DataSource = dt;
            }
            else
                showAllnhanvien();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            reportNhanVien form = new reportNhanVien();
            form.ShowDialog();
        }
    }
}
