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
    public partial class Form1 : Form
    {
        ThuVienBLL bllsv;
        public Form1()
        {
            InitializeComponent();
            bllsv = new ThuVienBLL();
        }
        public void showAllsach()
        {
            DataTable dt = bllsv.getALLsach();
            dataGridView1.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            showAllsach();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txmasach.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txmasach.Focus();
                return false;
            }
            return true;
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Tvien s = new Tvien();
                s.masach = txmasach.Text;
                s.tensach = txtensach.Text;
                s.theloai = txtheloai.Text;
                s.soluong = int.Parse(txsoluong.Text);
                s.mota = txmota.Text;
                s.namxb = txnamxb.Text;
                s.nhaxuatban = txnhaxuatban.Text;
                s.tacgia = txtacgia.Text;
                s.capnhat = txcapnhat.Text;
                if (bllsv.Insertsach(s))
                    showAllsach();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txmasach.Text = dataGridView1.Rows[index].Cells["masach"].Value.ToString();
                txtensach.Text = dataGridView1.Rows[index].Cells["tensach"].Value.ToString();
                txtheloai.Text = dataGridView1.Rows[index].Cells["theloai"].Value.ToString();
                txsoluong.Text = dataGridView1.Rows[index].Cells["soluong"].Value.ToString();
                txmota.Text = dataGridView1.Rows[index].Cells["mota"].Value.ToString();
                txnamxb.Text = dataGridView1.Rows[index].Cells["namxb"].Value.ToString();
                txnhaxuatban.Text = dataGridView1.Rows[index].Cells["nhaxuatban"].Value.ToString();
                txtacgia.Text = dataGridView1.Rows[index].Cells["tacgia"].Value.ToString();
                txcapnhat.Text = dataGridView1.Rows[index].Cells["capnhat"].Value.ToString();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {

            if (CheckData())
            {

                Tvien s = new Tvien();
                txmasach.Enabled = false;
                s.masach = txmasach.Text;
                s.tensach = txtensach.Text;
                s.theloai = txtheloai.Text;
                s.soluong = int.Parse(txsoluong.Text);
                s.mota = txmota.Text;
                s.namxb = txnamxb.Text;
                s.nhaxuatban = txnhaxuatban.Text;
                s.tacgia = txtacgia.Text;
                s.capnhat = txcapnhat.Text;
                if (bllsv.Updatesach(s))
                    showAllsach();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn xóa hay không??", "thông báo lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Tvien s = new Tvien();
                s.masach = txmasach.Text;

                if (bllsv.DELETEsach(s))
                    showAllsach();
                else
                    MessageBox.Show("lỗi, xin thử lại!", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tìmKiếmTheoTênSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txdiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txlop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txmasv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtensv_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txmasach.Text = dataGridView1.Rows[index].Cells["masach"].Value.ToString();
                txtensach.Text = dataGridView1.Rows[index].Cells["tensach"].Value.ToString();
                txtheloai.Text = dataGridView1.Rows[index].Cells["theloai"].Value.ToString();
                txsoluong.Text = dataGridView1.Rows[index].Cells["soluong"].Value.ToString();
                txmota.Text = dataGridView1.Rows[index].Cells["mota"].Value.ToString();
                txnamxb.Text = dataGridView1.Rows[index].Cells["namxb"].Value.ToString();
                txnhaxuatban.Text = dataGridView1.Rows[index].Cells["nhaxuatban"].Value.ToString();
                txtacgia.Text = dataGridView1.Rows[index].Cells["tacgia"].Value.ToString();
                txcapnhat.Text = dataGridView1.Rows[index].Cells["capnhat"].Value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tìmKiếmTheoTênSinhViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            showAllsach();
        }

        private void txcapnhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtensv_TextChanged_1(object sender, EventArgs e)
        {
            string value = txtensv.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllsv.Findsach(value);
                dataGridView1.DataSource = dt;
            }
            else
                showAllsach();
        }

        private void tìmKiếmTheoMaSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            reportSach form = new reportSach();
            form.ShowDialog();
        }
    }
}