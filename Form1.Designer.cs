namespace Danhmuchanghoa
{
    partial class Form1
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
            this.lbname = new System.Windows.Forms.Label();
            this.lbmahang = new System.Windows.Forms.Label();
            this.lbtenhang = new System.Windows.Forms.Label();
            this.lbmamau = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.lbthoigianbaohanh = new System.Windows.Forms.Label();
            this.tbmahang = new System.Windows.Forms.TextBox();
            this.tbtenhang = new System.Windows.Forms.TextBox();
            this.tbsoluong = new System.Windows.Forms.TextBox();
            this.tbthoigian = new System.Windows.Forms.TextBox();
            this.dgvdanhmuchanghoa = new System.Windows.Forms.DataGridView();
            this.cbmamau = new System.Windows.Forms.ComboBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btboqua = new System.Windows.Forms.Button();
            this.btdong = new System.Windows.Forms.Button();
            this.quanlyhanghoaDataSet = new Danhmuchanghoa.QuanlyhanghoaDataSet();
            this.tblMausacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMausacTableAdapter = new Danhmuchanghoa.QuanlyhanghoaDataSetTableAdapters.tblMausacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhmuchanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhanghoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMausacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbname.Location = new System.Drawing.Point(183, 19);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(398, 38);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "DANH MỤC HÀNG HÓA";
            // 
            // lbmahang
            // 
            this.lbmahang.AutoSize = true;
            this.lbmahang.Location = new System.Drawing.Point(54, 86);
            this.lbmahang.Name = "lbmahang";
            this.lbmahang.Size = new System.Drawing.Size(62, 16);
            this.lbmahang.TabIndex = 1;
            this.lbmahang.Text = "Mã hàng:";
            // 
            // lbtenhang
            // 
            this.lbtenhang.AutoSize = true;
            this.lbtenhang.Location = new System.Drawing.Point(54, 137);
            this.lbtenhang.Name = "lbtenhang";
            this.lbtenhang.Size = new System.Drawing.Size(67, 16);
            this.lbtenhang.TabIndex = 2;
            this.lbtenhang.Text = "Tên hàng:";
            // 
            // lbmamau
            // 
            this.lbmamau.AutoSize = true;
            this.lbmamau.Location = new System.Drawing.Point(54, 191);
            this.lbmamau.Name = "lbmamau";
            this.lbmamau.Size = new System.Drawing.Size(58, 16);
            this.lbmamau.TabIndex = 3;
            this.lbmamau.Text = "Mã màu:";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(54, 241);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(63, 16);
            this.lbsoluong.TabIndex = 4;
            this.lbsoluong.Text = "Số lượng:";
            // 
            // lbthoigianbaohanh
            // 
            this.lbthoigianbaohanh.AutoSize = true;
            this.lbthoigianbaohanh.Location = new System.Drawing.Point(53, 291);
            this.lbthoigianbaohanh.Name = "lbthoigianbaohanh";
            this.lbthoigianbaohanh.Size = new System.Drawing.Size(125, 16);
            this.lbthoigianbaohanh.TabIndex = 5;
            this.lbthoigianbaohanh.Text = "Thời gian bảo hành:";
            // 
            // tbmahang
            // 
            this.tbmahang.Location = new System.Drawing.Point(206, 86);
            this.tbmahang.Name = "tbmahang";
            this.tbmahang.Size = new System.Drawing.Size(305, 22);
            this.tbmahang.TabIndex = 6;
            // 
            // tbtenhang
            // 
            this.tbtenhang.Location = new System.Drawing.Point(206, 137);
            this.tbtenhang.Name = "tbtenhang";
            this.tbtenhang.Size = new System.Drawing.Size(305, 22);
            this.tbtenhang.TabIndex = 7;
            // 
            // tbsoluong
            // 
            this.tbsoluong.Location = new System.Drawing.Point(206, 241);
            this.tbsoluong.Name = "tbsoluong";
            this.tbsoluong.Size = new System.Drawing.Size(305, 22);
            this.tbsoluong.TabIndex = 9;
            // 
            // tbthoigian
            // 
            this.tbthoigian.Location = new System.Drawing.Point(206, 288);
            this.tbthoigian.Name = "tbthoigian";
            this.tbthoigian.Size = new System.Drawing.Size(305, 22);
            this.tbthoigian.TabIndex = 10;
            // 
            // dgvdanhmuchanghoa
            // 
            this.dgvdanhmuchanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhmuchanghoa.Location = new System.Drawing.Point(57, 345);
            this.dgvdanhmuchanghoa.Name = "dgvdanhmuchanghoa";
            this.dgvdanhmuchanghoa.RowHeadersWidth = 51;
            this.dgvdanhmuchanghoa.RowTemplate.Height = 24;
            this.dgvdanhmuchanghoa.Size = new System.Drawing.Size(699, 150);
            this.dgvdanhmuchanghoa.TabIndex = 11;
            this.dgvdanhmuchanghoa.Click += new System.EventHandler(this.dgvdanhmuchanghoa_Click);
            // 
            // cbmamau
            // 
            this.cbmamau.DataSource = this.tblMausacBindingSource;
            this.cbmamau.DisplayMember = "Mamau";
            this.cbmamau.FormattingEnabled = true;
            this.cbmamau.Location = new System.Drawing.Point(206, 182);
            this.cbmamau.Name = "cbmamau";
            this.cbmamau.Size = new System.Drawing.Size(305, 24);
            this.cbmamau.TabIndex = 12;
            this.cbmamau.ValueMember = "Mamau";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(56, 513);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(96, 52);
            this.btthem.TabIndex = 13;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(176, 513);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(96, 52);
            this.btxoa.TabIndex = 14;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(307, 513);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(96, 52);
            this.btsua.TabIndex = 15;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(425, 513);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(96, 52);
            this.btluu.TabIndex = 16;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btboqua
            // 
            this.btboqua.Location = new System.Drawing.Point(545, 513);
            this.btboqua.Name = "btboqua";
            this.btboqua.Size = new System.Drawing.Size(96, 52);
            this.btboqua.TabIndex = 17;
            this.btboqua.Text = "Bỏ qua";
            this.btboqua.UseVisualStyleBackColor = true;
            this.btboqua.Click += new System.EventHandler(this.btboqua_Click);
            // 
            // btdong
            // 
            this.btdong.Location = new System.Drawing.Point(660, 513);
            this.btdong.Name = "btdong";
            this.btdong.Size = new System.Drawing.Size(96, 52);
            this.btdong.TabIndex = 18;
            this.btdong.Text = "Đóng";
            this.btdong.UseVisualStyleBackColor = true;
            this.btdong.Click += new System.EventHandler(this.btdong_Click);
            // 
            // quanlyhanghoaDataSet
            // 
            this.quanlyhanghoaDataSet.DataSetName = "QuanlyhanghoaDataSet";
            this.quanlyhanghoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMausacBindingSource
            // 
            this.tblMausacBindingSource.DataMember = "tblMausac";
            this.tblMausacBindingSource.DataSource = this.quanlyhanghoaDataSet;
            // 
            // tblMausacTableAdapter
            // 
            this.tblMausacTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 577);
            this.Controls.Add(this.btdong);
            this.Controls.Add(this.btboqua);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.cbmamau);
            this.Controls.Add(this.dgvdanhmuchanghoa);
            this.Controls.Add(this.tbthoigian);
            this.Controls.Add(this.tbsoluong);
            this.Controls.Add(this.tbtenhang);
            this.Controls.Add(this.tbmahang);
            this.Controls.Add(this.lbthoigianbaohanh);
            this.Controls.Add(this.lbsoluong);
            this.Controls.Add(this.lbmamau);
            this.Controls.Add(this.lbtenhang);
            this.Controls.Add(this.lbmahang);
            this.Controls.Add(this.lbname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ParentChanged += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhmuchanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhanghoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMausacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbmahang;
        private System.Windows.Forms.Label lbtenhang;
        private System.Windows.Forms.Label lbmamau;
        private System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Label lbthoigianbaohanh;
        private System.Windows.Forms.TextBox tbmahang;
        private System.Windows.Forms.TextBox tbtenhang;
        private System.Windows.Forms.TextBox tbsoluong;
        private System.Windows.Forms.TextBox tbthoigian;
        private System.Windows.Forms.DataGridView dgvdanhmuchanghoa;
        private System.Windows.Forms.ComboBox cbmamau;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btboqua;
        private System.Windows.Forms.Button btdong;
        private QuanlyhanghoaDataSet quanlyhanghoaDataSet;
        private System.Windows.Forms.BindingSource tblMausacBindingSource;
        private QuanlyhanghoaDataSetTableAdapters.tblMausacTableAdapter tblMausacTableAdapter;
    }
}

