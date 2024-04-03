
namespace Khachhang
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
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtcoquan = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblcoquan = new System.Windows.Forms.Label();
            this.lblns = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.radioButtonnu = new System.Windows.Forms.RadioButton();
            this.radioButtonnam = new System.Windows.Forms.RadioButton();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KhachhangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stencoquan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(133, 6);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(177, 22);
            this.txthoten.TabIndex = 0;
            this.txthoten.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(133, 95);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(469, 22);
            this.txtdiachi.TabIndex = 1;
            // 
            // txtcoquan
            // 
            this.txtcoquan.Location = new System.Drawing.Point(133, 130);
            this.txtcoquan.Name = "txtcoquan";
            this.txtcoquan.Size = new System.Drawing.Size(469, 22);
            this.txtcoquan.TabIndex = 2;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(445, 42);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(157, 22);
            this.txtdienthoai.TabIndex = 3;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(35, 11);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(55, 17);
            this.lblhoten.TabIndex = 4;
            this.lblhoten.Text = "Họ Tên";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(30, 51);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(60, 17);
            this.lblgioitinh.TabIndex = 5;
            this.lblgioitinh.Text = "Giới tính";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(30, 95);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(51, 17);
            this.lbldiachi.TabIndex = 6;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblcoquan
            // 
            this.lblcoquan.AutoSize = true;
            this.lblcoquan.Location = new System.Drawing.Point(30, 130);
            this.lblcoquan.Name = "lblcoquan";
            this.lblcoquan.Size = new System.Drawing.Size(88, 17);
            this.lblcoquan.TabIndex = 7;
            this.lblcoquan.Text = "Tên cơ quan";
            // 
            // lblns
            // 
            this.lblns.AutoSize = true;
            this.lblns.Location = new System.Drawing.Point(351, 6);
            this.lblns.Name = "lblns";
            this.lblns.Size = new System.Drawing.Size(71, 17);
            this.lblns.TabIndex = 8;
            this.lblns.Text = "Ngày sinh";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(351, 47);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(70, 17);
            this.lblsdt.TabIndex = 9;
            this.lblsdt.Text = "điện thoại";
            // 
            // radioButtonnu
            // 
            this.radioButtonnu.AutoSize = true;
            this.radioButtonnu.Location = new System.Drawing.Point(133, 45);
            this.radioButtonnu.Name = "radioButtonnu";
            this.radioButtonnu.Size = new System.Drawing.Size(45, 21);
            this.radioButtonnu.TabIndex = 10;
            this.radioButtonnu.TabStop = true;
            this.radioButtonnu.Text = "nữ";
            this.radioButtonnu.UseVisualStyleBackColor = true;
            // 
            // radioButtonnam
            // 
            this.radioButtonnam.AutoSize = true;
            this.radioButtonnam.Location = new System.Drawing.Point(206, 43);
            this.radioButtonnam.Name = "radioButtonnam";
            this.radioButtonnam.Size = new System.Drawing.Size(56, 21);
            this.radioButtonnam.TabIndex = 11;
            this.radioButtonnam.TabStop = true;
            this.radioButtonnam.Text = "nam";
            this.radioButtonnam.UseVisualStyleBackColor = true;
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(131, 187);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(75, 23);
            this.btnnhap.TabIndex = 13;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(223, 187);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 14;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(326, 187);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(429, 187);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 16;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachhangID,
            this.shoten,
            this.sDiachi,
            this.sDienthoai,
            this.bGioitinh,
            this.tNgaysinh,
            this.stencoquan});
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 261);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // KhachhangID
            // 
            this.KhachhangID.DataPropertyName = "KhachhangID";
            this.KhachhangID.HeaderText = "KhachhangID";
            this.KhachhangID.MinimumWidth = 6;
            this.KhachhangID.Name = "KhachhangID";
            this.KhachhangID.Width = 125;
            // 
            // shoten
            // 
            this.shoten.DataPropertyName = "sHoten";
            this.shoten.HeaderText = "shoten";
            this.shoten.MinimumWidth = 6;
            this.shoten.Name = "shoten";
            this.shoten.Width = 125;
            // 
            // sDiachi
            // 
            this.sDiachi.DataPropertyName = "sDiachi";
            this.sDiachi.HeaderText = "sdiachi";
            this.sDiachi.MinimumWidth = 6;
            this.sDiachi.Name = "sDiachi";
            this.sDiachi.Width = 125;
            // 
            // sDienthoai
            // 
            this.sDienthoai.DataPropertyName = "sDienthoai";
            this.sDienthoai.HeaderText = "sDienthoai";
            this.sDienthoai.MinimumWidth = 6;
            this.sDienthoai.Name = "sDienthoai";
            this.sDienthoai.Width = 125;
            // 
            // bGioitinh
            // 
            this.bGioitinh.DataPropertyName = "bGioitinh";
            this.bGioitinh.HeaderText = "bGioitinh";
            this.bGioitinh.MinimumWidth = 6;
            this.bGioitinh.Name = "bGioitinh";
            this.bGioitinh.Width = 125;
            // 
            // tNgaysinh
            // 
            this.tNgaysinh.DataPropertyName = "tNgaysinh";
            this.tNgaysinh.HeaderText = "tNgaysinh";
            this.tNgaysinh.MinimumWidth = 6;
            this.tNgaysinh.Name = "tNgaysinh";
            this.tNgaysinh.Width = 125;
            // 
            // stencoquan
            // 
            this.stencoquan.DataPropertyName = "sTencoquan";
            this.stencoquan.HeaderText = "stencoquan";
            this.stencoquan.MinimumWidth = 6;
            this.stencoquan.Name = "stencoquan";
            this.stencoquan.Width = 125;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(445, 8);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(157, 22);
            this.maskedTextBox1.TabIndex = 19;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskChanged += new System.EventHandler(this.txthoten_TextChanged);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(527, 187);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 514);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnnhap);
            this.Controls.Add(this.radioButtonnam);
            this.Controls.Add(this.radioButtonnu);
            this.Controls.Add(this.lblsdt);
            this.Controls.Add(this.lblns);
            this.Controls.Add(this.lblcoquan);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lblgioitinh);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txtcoquan);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txthoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.txthoten_TextChanged);
            this.TextChanged += new System.EventHandler(this.txthoten_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtcoquan;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblcoquan;
        private System.Windows.Forms.Label lblns;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.RadioButton radioButtonnu;
        private System.Windows.Forms.RadioButton radioButtonnam;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnboqua;
       
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachhangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn stencoquan;
    }
}

