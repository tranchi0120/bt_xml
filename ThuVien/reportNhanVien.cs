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
    public partial class reportNhanVien : Form
    {
        public reportNhanVien()
        {
            InitializeComponent();
        }

        private void reportNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibraryDbDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Fill(this.LibraryDbDataSet1.NHANVIEN);

            this.reportViewer1.RefreshReport();
        }
    }
}
