
namespace ThuVien
{
    partial class reportdocgia
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
            this.LibraryDbDataSetDocgia = new ThuVien.LibraryDbDataSetDocgia();
            this.DOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DOCGIATableAdapter = new ThuVien.LibraryDbDataSetDocgiaTableAdapters.DOCGIATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDbDataSetDocgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetDocgia";
            reportDataSource1.Value = this.DOCGIABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThuVien.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1121, 625);
            this.reportViewer1.TabIndex = 1;
            // 
            // LibraryDbDataSetDocgia
            // 
            this.LibraryDbDataSetDocgia.DataSetName = "LibraryDbDataSetDocgia";
            this.LibraryDbDataSetDocgia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DOCGIABindingSource
            // 
            this.DOCGIABindingSource.DataMember = "DOCGIA";
            this.DOCGIABindingSource.DataSource = this.LibraryDbDataSetDocgia;
            // 
            // DOCGIATableAdapter
            // 
            this.DOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG THỐNG KÊ ĐỌC GIẢ";
            // 
            // reportdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 886);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportdocgia";
            this.Text = "reportdocgia";
            this.Load += new System.EventHandler(this.reportdocgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDbDataSetDocgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DOCGIABindingSource;
        private LibraryDbDataSetDocgia LibraryDbDataSetDocgia;
        private LibraryDbDataSetDocgiaTableAdapters.DOCGIATableAdapter DOCGIATableAdapter;
        private System.Windows.Forms.Label label1;
    }
}