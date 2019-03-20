namespace Project_LTUD_LeTuanAnh
{
    partial class frmPhieuMuon
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
            this.lstPhieuMuon = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.cboTimPhieuMuon = new System.Windows.Forms.ComboBox();
            this.btnTimPhieuMuon = new System.Windows.Forms.Button();
            this.txtTimPhieuMuon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPhieuMuon
            // 
            this.lstPhieuMuon.Location = new System.Drawing.Point(12, 58);
            this.lstPhieuMuon.Name = "lstPhieuMuon";
            this.lstPhieuMuon.Size = new System.Drawing.Size(400, 275);
            this.lstPhieuMuon.TabIndex = 0;
            this.lstPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lstPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.lstPhieuMuon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày mượn:";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMuon.Location = new System.Drawing.Point(552, 208);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(72, 16);
            this.lblNgayMuon.TabIndex = 5;
            this.lblNgayMuon.Text = "22/05/2018";
            // 
            // lblTenSach
            // 
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(552, 168);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(117, 40);
            this.lblTenSach.TabIndex = 6;
            this.lblTenSach.Text = "Không Gia Đình";
            // 
            // lblTenSV
            // 
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(552, 131);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(117, 37);
            this.lblTenSV.TabIndex = 7;
            this.lblTenSV.Text = "Lê Tuấn Anh";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraSach.Location = new System.Drawing.Point(486, 261);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(121, 41);
            this.btnTraSach.TabIndex = 8;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // cboTimPhieuMuon
            // 
            this.cboTimPhieuMuon.FormattingEnabled = true;
            this.cboTimPhieuMuon.Location = new System.Drawing.Point(115, 31);
            this.cboTimPhieuMuon.Name = "cboTimPhieuMuon";
            this.cboTimPhieuMuon.Size = new System.Drawing.Size(89, 21);
            this.cboTimPhieuMuon.TabIndex = 9;
            // 
            // btnTimPhieuMuon
            // 
            this.btnTimPhieuMuon.Location = new System.Drawing.Point(337, 29);
            this.btnTimPhieuMuon.Name = "btnTimPhieuMuon";
            this.btnTimPhieuMuon.Size = new System.Drawing.Size(75, 23);
            this.btnTimPhieuMuon.TabIndex = 10;
            this.btnTimPhieuMuon.Text = "Tìm";
            this.btnTimPhieuMuon.UseVisualStyleBackColor = true;
            this.btnTimPhieuMuon.Click += new System.EventHandler(this.btnTimPhieuMuon_Click);
            // 
            // txtTimPhieuMuon
            // 
            this.txtTimPhieuMuon.Location = new System.Drawing.Point(210, 31);
            this.txtTimPhieuMuon.Name = "txtTimPhieuMuon";
            this.txtTimPhieuMuon.Size = new System.Drawing.Size(121, 20);
            this.txtTimPhieuMuon.TabIndex = 11;
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 345);
            this.Controls.Add(this.txtTimPhieuMuon);
            this.Controls.Add(this.btnTimPhieuMuon);
            this.Controls.Add(this.cboTimPhieuMuon);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblNgayMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPhieuMuon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phiếu mượn";
            this.Load += new System.EventHandler(this.frmPhieuMuon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPhieuMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.ComboBox cboTimPhieuMuon;
        private System.Windows.Forms.Button btnTimPhieuMuon;
        private System.Windows.Forms.TextBox txtTimPhieuMuon;
    }
}