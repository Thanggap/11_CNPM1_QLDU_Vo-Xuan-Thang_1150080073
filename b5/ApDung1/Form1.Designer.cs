namespace ApDung1;

partial class Form1
{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button btnTim;
        private Button btnThoat;
        private RadioButton rdoUSCLN;
        private RadioButton rdoBSCNN;
        private Label lblA;
        private Label lblB;
        private Label lblKetQua;
        private GroupBox grpTuyChon;    /// <summary>
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
            this.btnTim = new Button();
            this.btnThoat = new Button();
            this.rdoUSCLN = new RadioButton();
            this.rdoBSCNN = new RadioButton();
            this.lblA = new Label();
            this.lblB = new Label();
            this.lblKetQua = new Label();
            this.grpTuyChon = new GroupBox();
            this.grpTuyChon.SuspendLayout();
            this.SuspendLayout();
            
            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new Point(50, 30);
            this.lblA.Name = "lblA";
            this.lblA.Size = new Size(50, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Số A:";
            
            // txtA
            this.txtA.Location = new Point(120, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(150, 27);
            this.txtA.TabIndex = 1;
            
            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new Point(50, 70);
            this.lblB.Name = "lblB";
            this.lblB.Size = new Size(50, 20);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Số B:";
            
            // txtB
            this.txtB.Location = new Point(120, 67);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(150, 27);
            this.txtB.TabIndex = 3;
            
            // grpTuyChon
            this.grpTuyChon.Controls.Add(this.rdoBSCNN);
            this.grpTuyChon.Controls.Add(this.rdoUSCLN);
            this.grpTuyChon.Location = new Point(50, 110);
            this.grpTuyChon.Name = "grpTuyChon";
            this.grpTuyChon.Size = new Size(220, 80);
            this.grpTuyChon.TabIndex = 4;
            this.grpTuyChon.TabStop = false;
            this.grpTuyChon.Text = "Tùy chọn";
            
            // rdoUSCLN
            this.rdoUSCLN.AutoSize = true;
            this.rdoUSCLN.Checked = true;
            this.rdoUSCLN.Location = new Point(20, 30);
            this.rdoUSCLN.Name = "rdoUSCLN";
            this.rdoUSCLN.Size = new Size(181, 24);
            this.rdoUSCLN.TabIndex = 0;
            this.rdoUSCLN.TabStop = true;
            this.rdoUSCLN.Text = "Ước số chung lớn nhất";
            this.rdoUSCLN.UseVisualStyleBackColor = true;
            
            // rdoBSCNN
            this.rdoBSCNN.AutoSize = true;
            this.rdoBSCNN.Location = new Point(20, 50);
            this.rdoBSCNN.Name = "rdoBSCNN";
            this.rdoBSCNN.Size = new Size(177, 24);
            this.rdoBSCNN.TabIndex = 1;
            this.rdoBSCNN.Text = "Bội số chung nhỏ nhất";
            this.rdoBSCNN.UseVisualStyleBackColor = true;
            
            // lblKetQua
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new Point(50, 210);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new Size(65, 20);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "Kết quả:";
            
            // txtKetQua
            this.txtKetQua.Location = new Point(120, 207);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new Size(150, 27);
            this.txtKetQua.TabIndex = 6;
            
            // btnTim
            this.btnTim.Location = new Point(80, 260);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new Size(80, 30);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new EventHandler(this.btnTim_Click);
            
            // btnThoat
            this.btnThoat.Location = new Point(180, 260);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(80, 30);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            
            // Form1
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(350, 320);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.grpTuyChon);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN";
            this.grpTuyChon.ResumeLayout(false);
            this.grpTuyChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
}
