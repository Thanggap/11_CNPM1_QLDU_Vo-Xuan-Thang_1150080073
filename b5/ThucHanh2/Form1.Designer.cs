namespace ThucHanh2;

partial class Form1
{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private TextBox txtTenKH;
        private TextBox txtThanhTien;
        private CheckBox chkLayCaoRang;
        private CheckBox chkTayTrangRang;
        private CheckBox chkHanRang;
        private CheckBox chkBeRang;
        private CheckBox chkBocRang;
        private NumericUpDown nupHanRang;
        private NumericUpDown nupBeRang;
        private NumericUpDown nupBocRang;
        private Button btnTinhTien;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblTenKH;
        private Label lblDichVu;
        private Label lblThanhTien;
        private GroupBox grpDichVu;
        private ErrorProvider err;    /// <summary>
    ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTenKH = new TextBox();
            this.txtThanhTien = new TextBox();
            this.chkLayCaoRang = new CheckBox();
            this.chkTayTrangRang = new CheckBox();
            this.chkHanRang = new CheckBox();
            this.chkBeRang = new CheckBox();
            this.chkBocRang = new CheckBox();
            this.nupHanRang = new NumericUpDown();
            this.nupBeRang = new NumericUpDown();
            this.nupBocRang = new NumericUpDown();
            this.btnTinhTien = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();
            this.lblTenKH = new Label();
            this.lblDichVu = new Label();
            this.lblThanhTien = new Label();
            this.grpDichVu = new GroupBox();
            this.err = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).BeginInit();
            this.grpDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            
            // lblTenKH
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new Point(30, 30);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new Size(120, 20);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên khách hàng:";
            
            // txtTenKH
            this.txtTenKH.Location = new Point(160, 27);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new Size(200, 27);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKH_Validating);
            
            // grpDichVu
            this.grpDichVu.Controls.Add(this.nupBocRang);
            this.grpDichVu.Controls.Add(this.nupBeRang);
            this.grpDichVu.Controls.Add(this.nupHanRang);
            this.grpDichVu.Controls.Add(this.chkBocRang);
            this.grpDichVu.Controls.Add(this.chkBeRang);
            this.grpDichVu.Controls.Add(this.chkHanRang);
            this.grpDichVu.Controls.Add(this.chkTayTrangRang);
            this.grpDichVu.Controls.Add(this.chkLayCaoRang);
            this.grpDichVu.Location = new Point(30, 80);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new Size(400, 200);
            this.grpDichVu.TabIndex = 2;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "Dịch vụ";
            
            // chkLayCaoRang
            this.chkLayCaoRang.AutoSize = true;
            this.chkLayCaoRang.Location = new Point(20, 30);
            this.chkLayCaoRang.Name = "chkLayCaoRang";
            this.chkLayCaoRang.Size = new Size(183, 24);
            this.chkLayCaoRang.TabIndex = 0;
            this.chkLayCaoRang.Text = "Lấy cao răng (50.000đ)";
            this.chkLayCaoRang.UseVisualStyleBackColor = true;
            
            // chkTayTrangRang
            this.chkTayTrangRang.AutoSize = true;
            this.chkTayTrangRang.Location = new Point(20, 60);
            this.chkTayTrangRang.Name = "chkTayTrangRang";
            this.chkTayTrangRang.Size = new Size(196, 24);
            this.chkTayTrangRang.TabIndex = 1;
            this.chkTayTrangRang.Text = "Tẩy trắng răng (100.000đ)";
            this.chkTayTrangRang.UseVisualStyleBackColor = true;
            
            // chkHanRang
            this.chkHanRang.AutoSize = true;
            this.chkHanRang.Location = new Point(20, 90);
            this.chkHanRang.Name = "chkHanRang";
            this.chkHanRang.Size = new Size(187, 24);
            this.chkHanRang.TabIndex = 2;
            this.chkHanRang.Text = "Hàn răng (100.000đ/cái)";
            this.chkHanRang.UseVisualStyleBackColor = true;
            
            // nupHanRang
            this.nupHanRang.Location = new Point(250, 88);
            this.nupHanRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nupHanRang.Name = "nupHanRang";
            this.nupHanRang.Size = new Size(80, 27);
            this.nupHanRang.TabIndex = 3;
            this.nupHanRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            
            // chkBeRang
            this.chkBeRang.AutoSize = true;
            this.chkBeRang.Location = new Point(20, 120);
            this.chkBeRang.Name = "chkBeRang";
            this.chkBeRang.Size = new Size(173, 24);
            this.chkBeRang.TabIndex = 4;
            this.chkBeRang.Text = "Bẻ răng (10.000đ/cái)";
            this.chkBeRang.UseVisualStyleBackColor = true;
            
            // nupBeRang
            this.nupBeRang.Location = new Point(250, 118);
            this.nupBeRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nupBeRang.Name = "nupBeRang";
            this.nupBeRang.Size = new Size(80, 27);
            this.nupBeRang.TabIndex = 5;
            this.nupBeRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            
            // chkBocRang
            this.chkBocRang.AutoSize = true;
            this.chkBocRang.Location = new Point(20, 150);
            this.chkBocRang.Name = "chkBocRang";
            this.chkBocRang.Size = new Size(198, 24);
            this.chkBocRang.TabIndex = 6;
            this.chkBocRang.Text = "Bọc răng (1.000.000đ/cái)";
            this.chkBocRang.UseVisualStyleBackColor = true;
            
            // nupBocRang
            this.nupBocRang.Location = new Point(250, 148);
            this.nupBocRang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nupBocRang.Name = "nupBocRang";
            this.nupBocRang.Size = new Size(80, 27);
            this.nupBocRang.TabIndex = 7;
            this.nupBocRang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            
            // lblThanhTien
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new Point(30, 300);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new Size(88, 20);
            this.lblThanhTien.TabIndex = 3;
            this.lblThanhTien.Text = "Thành tiền:";
            
            // txtThanhTien
            this.txtThanhTien.Location = new Point(130, 297);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new Size(150, 27);
            this.txtThanhTien.TabIndex = 4;
            
            // btnTinhTien
            this.btnTinhTien.Location = new Point(100, 350);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new Size(90, 30);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new EventHandler(this.btnTinhTien_Click);
            
            // btnXoa
            this.btnXoa.Location = new Point(210, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(90, 30);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            
            // btnThoat
            this.btnThoat.Location = new Point(320, 350);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(90, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            
            // err
            this.err.ContainerControl = this;
            
            // Form1
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(480, 420);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblTenKH);
            this.Name = "Form1";
            this.Text = "Tính tiền phòng khám nha khoa";
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).EndInit();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
}
