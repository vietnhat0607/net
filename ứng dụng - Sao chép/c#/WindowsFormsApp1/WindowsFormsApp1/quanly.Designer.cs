namespace WindowsFormsApp1
{
    partial class quanly
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
            this.tcadmin = new System.Windows.Forms.TabControl();
            this.tpdoanhmuc = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpmon = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvdisplay = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tpdoanhthu = new System.Windows.Forms.TabPage();
            this.tptaikhoan = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdanhmuc = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.cafeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nướcÉpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhTốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcadmin.SuspendLayout();
            this.tpdoanhmuc.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tpmon.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).BeginInit();
            this.panel4.SuspendLayout();
            this.tptaikhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcadmin
            // 
            this.tcadmin.Controls.Add(this.tpdoanhmuc);
            this.tcadmin.Controls.Add(this.tpmon);
            this.tcadmin.Controls.Add(this.tpdoanhthu);
            this.tcadmin.Controls.Add(this.tptaikhoan);
            this.tcadmin.Location = new System.Drawing.Point(12, 12);
            this.tcadmin.Name = "tcadmin";
            this.tcadmin.SelectedIndex = 0;
            this.tcadmin.Size = new System.Drawing.Size(785, 426);
            this.tcadmin.TabIndex = 1;
            // 
            // tpdoanhmuc
            // 
            this.tpdoanhmuc.Controls.Add(this.menuStrip1);
            this.tpdoanhmuc.Location = new System.Drawing.Point(4, 25);
            this.tpdoanhmuc.Name = "tpdoanhmuc";
            this.tpdoanhmuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpdoanhmuc.Size = new System.Drawing.Size(777, 397);
            this.tpdoanhmuc.TabIndex = 0;
            this.tpdoanhmuc.Text = "doanh mục ";
            this.tpdoanhmuc.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mónĂnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mónĂnToolStripMenuItem
            // 
            this.mónĂnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cafeToolStripMenuItem,
            this.nướcÉpToolStripMenuItem,
            this.sinhTốToolStripMenuItem});
            this.mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            this.mónĂnToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.mónĂnToolStripMenuItem.Text = "món ăn ";
            // 
            // tpmon
            // 
            this.tpmon.Controls.Add(this.panel6);
            this.tpmon.Controls.Add(this.panel5);
            this.tpmon.Controls.Add(this.panel4);
            this.tpmon.Location = new System.Drawing.Point(4, 25);
            this.tpmon.Name = "tpmon";
            this.tpmon.Padding = new System.Windows.Forms.Padding(3);
            this.tpmon.Size = new System.Drawing.Size(777, 397);
            this.tpmon.TabIndex = 1;
            this.tpmon.Text = "món ăn ";
            this.tpmon.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtgia);
            this.panel6.Controls.Add(this.txtdanhmuc);
            this.panel6.Controls.Add(this.txtname);
            this.panel6.Controls.Add(this.txtid);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(551, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 335);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvdisplay);
            this.panel5.Location = new System.Drawing.Point(6, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(539, 335);
            this.panel5.TabIndex = 2;
            // 
            // dgvdisplay
            // 
            this.dgvdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdisplay.Location = new System.Drawing.Point(0, 0);
            this.dgvdisplay.Name = "dgvdisplay";
            this.dgvdisplay.RowHeadersWidth = 51;
            this.dgvdisplay.RowTemplate.Height = 24;
            this.dgvdisplay.Size = new System.Drawing.Size(539, 335);
            this.dgvdisplay.TabIndex = 0;
            this.dgvdisplay.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdisplay_CellEnter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnexit);
            this.panel4.Controls.Add(this.btnsave);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 44);
            this.panel4.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(235, 2);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 32);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "exit ";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(158, 2);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(71, 32);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(77, 2);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(3, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Thêm";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tpdoanhthu
            // 
            this.tpdoanhthu.Location = new System.Drawing.Point(4, 25);
            this.tpdoanhthu.Name = "tpdoanhthu";
            this.tpdoanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tpdoanhthu.Size = new System.Drawing.Size(777, 397);
            this.tpdoanhthu.TabIndex = 2;
            this.tpdoanhthu.Text = "doanh thu ";
            this.tpdoanhthu.UseVisualStyleBackColor = true;
            // 
            // tptaikhoan
            // 
            this.tptaikhoan.Controls.Add(this.panel2);
            this.tptaikhoan.Controls.Add(this.panel3);
            this.tptaikhoan.Controls.Add(this.panel1);
            this.tptaikhoan.Location = new System.Drawing.Point(4, 25);
            this.tptaikhoan.Name = "tptaikhoan";
            this.tptaikhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tptaikhoan.Size = new System.Drawing.Size(777, 397);
            this.tptaikhoan.TabIndex = 3;
            this.tptaikhoan.Text = "tài khoản ";
            this.tptaikhoan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(9, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 44);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(582, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 335);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 335);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "id ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "tên đăng nhập ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "danh mục ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "giá ";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(39, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(182, 22);
            this.txtid.TabIndex = 6;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(102, 57);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(118, 22);
            this.txtname.TabIndex = 7;
            // 
            // txtdanhmuc
            // 
            this.txtdanhmuc.Location = new System.Drawing.Point(78, 106);
            this.txtdanhmuc.Name = "txtdanhmuc";
            this.txtdanhmuc.Size = new System.Drawing.Size(143, 22);
            this.txtdanhmuc.TabIndex = 8;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(38, 144);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(182, 22);
            this.txtgia.TabIndex = 9;
            // 
            // cafeToolStripMenuItem
            // 
            this.cafeToolStripMenuItem.Name = "cafeToolStripMenuItem";
            this.cafeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cafeToolStripMenuItem.Text = "cafe ";
            // 
            // nướcÉpToolStripMenuItem
            // 
            this.nướcÉpToolStripMenuItem.Name = "nướcÉpToolStripMenuItem";
            this.nướcÉpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nướcÉpToolStripMenuItem.Text = "nước ép ";
            // 
            // sinhTốToolStripMenuItem
            // 
            this.sinhTốToolStripMenuItem.Name = "sinhTốToolStripMenuItem";
            this.sinhTốToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sinhTốToolStripMenuItem.Text = "sinh tố ";
            // 
            // quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcadmin);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "quanly";
            this.Text = "display";
            this.Load += new System.EventHandler(this.quanly_Load);
            this.tcadmin.ResumeLayout(false);
            this.tpdoanhmuc.ResumeLayout(false);
            this.tpdoanhmuc.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tpmon.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdisplay)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tptaikhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcadmin;
        private System.Windows.Forms.TabPage tpdoanhmuc;
        private System.Windows.Forms.TabPage tpmon;
        private System.Windows.Forms.TabPage tpdoanhthu;
        private System.Windows.Forms.TabPage tptaikhoan;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvdisplay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mónĂnToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtdanhmuc;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ToolStripMenuItem cafeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nướcÉpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhTốToolStripMenuItem;
    }
}