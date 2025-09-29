namespace ThucHanh1;

partial class Form1
{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblA;
        private Label lblB;
        private Label lblKetQua;    /// <summary>
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
            this.txtA = new TextBox();
            this.txtB = new TextBox();
            this.txtKetQua = new TextBox();
            this.btnCong = new Button();
            this.btnTru = new Button();
            this.btnNhan = new Button();
            this.btnChia = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();
            this.lblA = new Label();
            this.lblB = new Label();
            this.lblKetQua = new Label();
            this.SuspendLayout();
            
            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new Point(50, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new Size(17, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";
            
            // txtA
            this.txtA.Location = new Point(100, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(200, 27);
            this.txtA.TabIndex = 1;
            
            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new Point(50, 70);
            this.lblB.Name = "lblB";
            this.lblB.Size = new Size(17, 20);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            
            // txtB
            this.txtB.Location = new Point(100, 67);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(200, 27);
            this.txtB.TabIndex = 3;
            
            // lblKetQua
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new Point(50, 110);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new Size(65, 20);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả:";
            
            // txtKetQua
            this.txtKetQua.Location = new Point(100, 107);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new Size(200, 27);
            this.txtKetQua.TabIndex = 5;
            
            // btnCong
            this.btnCong.Location = new Point(50, 160);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new Size(60, 30);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new EventHandler(this.btnCong_Click);
            
            // btnTru
            this.btnTru.Location = new Point(120, 160);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new Size(60, 30);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new EventHandler(this.btnTru_Click);
            
            // btnNhan
            this.btnNhan.Location = new Point(190, 160);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new Size(60, 30);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "×";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new EventHandler(this.btnNhan_Click);
            
            // btnChia
            this.btnChia.Location = new Point(260, 160);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new Size(60, 30);
            this.btnChia.TabIndex = 9;
            this.btnChia.Text = "÷";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new EventHandler(this.btnChia_Click);
            
            // btnXoa
            this.btnXoa.Location = new Point(120, 210);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(80, 30);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            
            // btnThoat
            this.btnThoat.Location = new Point(220, 210);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(80, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            
            // Form1
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Máy Tính Đơn Giản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
}
