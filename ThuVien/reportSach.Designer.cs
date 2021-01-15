
namespace ThuVien
{
    partial class reportSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LibraryDbDataSet = new ThuVien.LibraryDbDataSet();
            this.SACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SACHTableAdapter = new ThuVien.LibraryDbDataSetTableAdapters.SACHTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetSach";
            reportDataSource1.Value = this.SACHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuVien.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(51, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1222, 604);
            this.reportViewer1.TabIndex = 0;
            // 
            // LibraryDbDataSet
            // 
            this.LibraryDbDataSet.DataSetName = "LibraryDbDataSet";
            this.LibraryDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SACHBindingSource
            // 
            this.SACHBindingSource.DataMember = "SACH";
            this.SACHBindingSource.DataSource = this.LibraryDbDataSet;
            // 
            // SACHTableAdapter
            // 
            this.SACHTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG THỐNG KÊ SÁCH";
            // 
            // reportSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportSach";
            this.Text = "reportSach";
            this.Load += new System.EventHandler(this.reportSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SACHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SACHBindingSource;
        private LibraryDbDataSet LibraryDbDataSet;
        private LibraryDbDataSetTableAdapters.SACHTableAdapter SACHTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}