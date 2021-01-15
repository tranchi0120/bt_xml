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
    public partial class Form2 : Form
    {
        docgiaBLL bllsv;
        public Form2()
        {
            InitializeComponent();
            bllsv = new docgiaBLL();
        }
        public void showAlldocgia()
        {
            DataTable dt = bllsv.getALLdocgia();
            dataGridView1.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            showAlldocgia();

        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(madg.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                madg.Focus();
                return false;
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string value = txtensv.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllsv.Finddocgia(value);
                dataGridView1.DataSource = dt;
            }
            else
                showAlldocgia();

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Docgia a = new Docgia();
                a.madg = madg.Text;
                a.tendg  = tendg.Text;
                a.ngaysinh = ngsinh.Text;
                a.gioitinh = gioitinh.Text;
                a.cmnd = cmnd.Text;
                a.diachi = diachi.Text;
                a.sdt = sdt.Text;
                a.capnhat = capnhat.Text;
                if (bllsv.Insertdocgia(a))
                    showAlldocgia();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {

                Docgia a = new Docgia();
                madg.Enabled = false;
                a.madg = madg.Text;
                a.tendg = tendg.Text;
                a.ngaysinh = ngsinh.Text;
                a.gioitinh = gioitinh.Text;
                a.cmnd = cmnd.Text;
                a.diachi = diachi.Text;
                a.sdt = sdt.Text;
                a.capnhat = capnhat.Text;
                if (bllsv.Updatedocgia(a))
                    showAlldocgia();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa hay không??", "thông báo lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Docgia a= new Docgia();
                a.madg = madg.Text;

                if (bllsv.DELETEdocgia(a))
                    showAlldocgia();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtensv_TextChanged(object sender, EventArgs e)
        {
            string value = tendg.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllsv.Finddocgia(value);
                dataGridView1.DataSource = dt;
            }
            else
                showAlldocgia();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                madg.Text = dataGridView1.Rows[index].Cells["madg"].Value.ToString();
                tendg.Text = dataGridView1.Rows[index].Cells["tendg"].Value.ToString();
                ngsinh.Text = dataGridView1.Rows[index].Cells["ngaysinh"].Value.ToString();
                gioitinh.Text = dataGridView1.Rows[index].Cells["gioitinh"].Value.ToString();
                cmnd.Text = dataGridView1.Rows[index].Cells["cmnd"].Value.ToString();
                diachi.Text = dataGridView1.Rows[index].Cells["diachi"].Value.ToString();
                sdt.Text = dataGridView1.Rows[index].Cells["sdt"].Value.ToString();
                capnhat.Text = dataGridView1.Rows[index].Cells["capnhat"].Value.ToString();
                
            }
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            reportdocgia form = new reportdocgia ();
            form.ShowDialog();

        }
    }
}
