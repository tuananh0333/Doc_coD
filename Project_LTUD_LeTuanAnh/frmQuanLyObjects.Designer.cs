namespace Project_LTUD_LeTuanAnh
{
    partial class frmQuanLyObjects
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_NhaXuatBan = new System.Windows.Forms.DataGridView();
            this.dgv_TheLoai = new System.Windows.Forms.DataGridView();
            this.dgv_TacGia = new System.Windows.Forms.DataGridView();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnSuaNXB = new System.Windows.Forms.Button();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.btnLuuNXB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuuTheLoai = new System.Windows.Forms.Button();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.btnSuaTheLoai = new System.Windows.Forms.Button();
            this.btnXoaTheLoai = new System.Windows.Forms.Button();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLuuTacGia = new System.Windows.Forms.Button();
            this.btnThemTacGia = new System.Windows.Forms.Button();
            this.btnSuaTacGia = new System.Windows.Forms.Button();
            this.btnXoaTacGia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ XUẤT BẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÊ LOẠI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(870, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "TÁC GIẢ";
            // 
            // dgv_NhaXuatBan
            // 
            this.dgv_NhaXuatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhaXuatBan.Location = new System.Drawing.Point(12, 71);
            this.dgv_NhaXuatBan.Name = "dgv_NhaXuatBan";
            this.dgv_NhaXuatBan.Size = new System.Drawing.Size(342, 206);
            this.dgv_NhaXuatBan.TabIndex = 3;
            this.dgv_NhaXuatBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhaXuatBan_CellClick);
            // 
            // dgv_TheLoai
            // 
            this.dgv_TheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TheLoai.Location = new System.Drawing.Point(376, 71);
            this.dgv_TheLoai.Name = "dgv_TheLoai";
            this.dgv_TheLoai.Size = new System.Drawing.Size(342, 206);
            this.dgv_TheLoai.TabIndex = 4;
            this.dgv_TheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TheLoai_CellClick);
            // 
            // dgv_TacGia
            // 
            this.dgv_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TacGia.Location = new System.Drawing.Point(739, 71);
            this.dgv_TacGia.Name = "dgv_TacGia";
            this.dgv_TacGia.Size = new System.Drawing.Size(342, 206);
            this.dgv_TacGia.TabIndex = 5;
            this.dgv_TacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TacGia_CellClick);
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Location = new System.Drawing.Point(23, 296);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNXB.TabIndex = 9;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);
            // 
            // btnSuaNXB
            // 
            this.btnSuaNXB.Location = new System.Drawing.Point(104, 296);
            this.btnSuaNXB.Name = "btnSuaNXB";
            this.btnSuaNXB.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNXB.TabIndex = 10;
            this.btnSuaNXB.Text = "Sửa";
            this.btnSuaNXB.UseVisualStyleBackColor = true;
            this.btnSuaNXB.Click += new System.EventHandler(this.btnSuaNXB_Click);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(279, 296);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(75, 23);
            this.btnThemNXB.TabIndex = 11;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // btnLuuNXB
            // 
            this.btnLuuNXB.Location = new System.Drawing.Point(121, 415);
            this.btnLuuNXB.Name = "btnLuuNXB";
            this.btnLuuNXB.Size = new System.Drawing.Size(75, 23);
            this.btnLuuNXB.TabIndex = 12;
            this.btnLuuNXB.Text = "Lưu";
            this.btnLuuNXB.UseVisualStyleBackColor = true;
            this.btnLuuNXB.Click += new System.EventHandler(this.btnLuuNXB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mã Nhà Xuất Bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tên Nhà Xuất Bản:";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(121, 345);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(190, 20);
            this.txtMaNXB.TabIndex = 15;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(121, 375);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(190, 20);
            this.txtTenNXB.TabIndex = 16;
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Location = new System.Drawing.Point(485, 375);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(190, 20);
            this.txtTenTheLoai.TabIndex = 26;
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Location = new System.Drawing.Point(485, 345);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(190, 20);
            this.txtMaTheLoai.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tên Nhà Xuất Bản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mã Nhà Xuất Bản:";
            // 
            // btnLuuTheLoai
            // 
            this.btnLuuTheLoai.Location = new System.Drawing.Point(485, 415);
            this.btnLuuTheLoai.Name = "btnLuuTheLoai";
            this.btnLuuTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnLuuTheLoai.TabIndex = 22;
            this.btnLuuTheLoai.Text = "Lưu";
            this.btnLuuTheLoai.UseVisualStyleBackColor = true;
            this.btnLuuTheLoai.Click += new System.EventHandler(this.btnLuuTheLoai_Click);
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Location = new System.Drawing.Point(643, 296);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnThemTheLoai.TabIndex = 21;
            this.btnThemTheLoai.Text = "Thêm";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // btnSuaTheLoai
            // 
            this.btnSuaTheLoai.Location = new System.Drawing.Point(457, 296);
            this.btnSuaTheLoai.Name = "btnSuaTheLoai";
            this.btnSuaTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTheLoai.TabIndex = 20;
            this.btnSuaTheLoai.Text = "Sửa";
            this.btnSuaTheLoai.UseVisualStyleBackColor = true;
            this.btnSuaTheLoai.Click += new System.EventHandler(this.btnSuaTheLoai_Click);
            // 
            // btnXoaTheLoai
            // 
            this.btnXoaTheLoai.Location = new System.Drawing.Point(376, 296);
            this.btnXoaTheLoai.Name = "btnXoaTheLoai";
            this.btnXoaTheLoai.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTheLoai.TabIndex = 19;
            this.btnXoaTheLoai.Text = "Xóa";
            this.btnXoaTheLoai.UseVisualStyleBackColor = true;
            this.btnXoaTheLoai.Click += new System.EventHandler(this.btnXoaTheLoai_Click);
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(875, 375);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(190, 20);
            this.txtTenTacGia.TabIndex = 36;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(875, 345);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(190, 20);
            this.txtMaTacGia.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(770, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tên Nhà Xuất Bản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(774, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mã Nhà Xuất Bản:";
            // 
            // btnLuuTacGia
            // 
            this.btnLuuTacGia.Location = new System.Drawing.Point(875, 415);
            this.btnLuuTacGia.Name = "btnLuuTacGia";
            this.btnLuuTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnLuuTacGia.TabIndex = 32;
            this.btnLuuTacGia.Text = "Lưu";
            this.btnLuuTacGia.UseVisualStyleBackColor = true;
            this.btnLuuTacGia.Click += new System.EventHandler(this.btnLuuTacGia_Click);
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.Location = new System.Drawing.Point(1006, 296);
            this.btnThemTacGia.Name = "btnThemTacGia";
            this.btnThemTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnThemTacGia.TabIndex = 31;
            this.btnThemTacGia.Text = "Thêm";
            this.btnThemTacGia.UseVisualStyleBackColor = true;
            this.btnThemTacGia.Click += new System.EventHandler(this.btnThemTacGia_Click);
            // 
            // btnSuaTacGia
            // 
            this.btnSuaTacGia.Location = new System.Drawing.Point(820, 296);
            this.btnSuaTacGia.Name = "btnSuaTacGia";
            this.btnSuaTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTacGia.TabIndex = 30;
            this.btnSuaTacGia.Text = "Sửa";
            this.btnSuaTacGia.UseVisualStyleBackColor = true;
            this.btnSuaTacGia.Click += new System.EventHandler(this.btnSuaTacGia_Click);
            // 
            // btnXoaTacGia
            // 
            this.btnXoaTacGia.Location = new System.Drawing.Point(739, 296);
            this.btnXoaTacGia.Name = "btnXoaTacGia";
            this.btnXoaTacGia.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTacGia.TabIndex = 29;
            this.btnXoaTacGia.Text = "Xóa";
            this.btnXoaTacGia.UseVisualStyleBackColor = true;
            this.btnXoaTacGia.Click += new System.EventHandler(this.btnXoaTacGia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(360, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 424);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(723, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 424);
            this.panel2.TabIndex = 38;
            // 
            // frmQuanLyObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.txtMaTacGia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLuuTacGia);
            this.Controls.Add(this.btnThemTacGia);
            this.Controls.Add(this.btnSuaTacGia);
            this.Controls.Add(this.btnXoaTacGia);
            this.Controls.Add(this.txtTenTheLoai);
            this.Controls.Add(this.txtMaTheLoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLuuTheLoai);
            this.Controls.Add(this.btnThemTheLoai);
            this.Controls.Add(this.btnSuaTheLoai);
            this.Controls.Add(this.btnXoaTheLoai);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLuuNXB);
            this.Controls.Add(this.btnThemNXB);
            this.Controls.Add(this.btnSuaNXB);
            this.Controls.Add(this.btnXoaNXB);
            this.Controls.Add(this.dgv_TacGia);
            this.Controls.Add(this.dgv_TheLoai);
            this.Controls.Add(this.dgv_NhaXuatBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuanLyObjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doc@coD";
            this.Load += new System.EventHandler(this.frmQuanLyObjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_NhaXuatBan;
        private System.Windows.Forms.DataGridView dgv_TheLoai;
        private System.Windows.Forms.DataGridView dgv_TacGia;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.Button btnSuaNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.Button btnLuuNXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuuTheLoai;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.Button btnSuaTheLoai;
        private System.Windows.Forms.Button btnXoaTheLoai;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuuTacGia;
        private System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.Button btnSuaTacGia;
        private System.Windows.Forms.Button btnXoaTacGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}