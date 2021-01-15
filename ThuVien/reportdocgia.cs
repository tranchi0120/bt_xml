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
    public partial class reportdocgia : Form
    {
        public reportdocgia()
        {
            InitializeComponent();
        }

        private void reportdocgia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibraryDbDataSetDocgia.DOCGIA' table. You can move, or remove it, as needed.
            this.DOCGIATableAdapter.Fill(this.LibraryDbDataSetDocgia.DOCGIA);

            this.reportViewer1.RefreshReport();
        }
    }
}
