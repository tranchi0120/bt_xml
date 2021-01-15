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
    public partial class reportSach : Form
    {
        public reportSach()
        {
            InitializeComponent();
        }

        private void reportSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibraryDbDataSet.SACH' table. You can move, or remove it, as needed.
            this.SACHTableAdapter.Fill(this.LibraryDbDataSet.SACH);

            this.reportViewer1.RefreshReport();
        }
    }
}
