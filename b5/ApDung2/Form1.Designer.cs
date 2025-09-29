namespace ApDung2;

partial class Form1
{
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private TextBox txtPassword;
        private Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0;
        private Button btnClear;
        private Button btnEnter;
        private ListBox lstLog;
        private Label lblTitle;
        private Label lblPassword;    /// <summary>
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
            this.txtPassword = new TextBox();
            this.btn1 = new Button();
            this.btn2 = new Button();
            this.btn3 = new Button();
            this.btn4 = new Button();
            this.btn5 = new Button();
            this.btn6 = new Button();
            this.btn7 = new Button();
            this.btn8 = new Button();
            this.btn9 = new Button();
            this.btn0 = new Button();
            this.btnClear = new Button();
            this.btnEnter = new Button();
            this.lstLog = new ListBox();
            this.lblTitle = new Label();
            this.lblPassword = new Label();
            this.SuspendLayout();
            
            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            this.lblTitle.Location = new Point(120, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(130, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Security Panel";
            
            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(50, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(73, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            
            // txtPassword
            this.txtPassword.Location = new Point(140, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new Size(150, 27);
            this.txtPassword.TabIndex = 2;
            
            // Buttons 1-3
            this.btn1.Location = new Point(50, 120);
            this.btn1.Name = "btn1";
            this.btn1.Size = new Size(50, 50);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new EventHandler(this.btnNumber_Click);
            
            this.btn2.Location = new Point(120, 120);
            this.btn2.Name = "btn2";
            this.btn2.Size = new Size(50, 50);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new EventHandler(this.btnNumber_Click);
            
            this.btn3.Location = new Point(190, 120);
            this.btn3.Name = "btn3";
            this.btn3.Size = new Size(50, 50);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new EventHandler(this.btnNumber_Click);
            
            // Buttons 4-6
            this.btn4.Location = new Point(50, 180);
            this.btn4.Name = "btn4";
            this.btn4.Size = new Size(50, 50);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new EventHandler(this.btnNumber_Click);
            
            this.btn5.Location = new Point(120, 180);
            this.btn5.Name = "btn5";
            this.btn5.Size = new Size(50, 50);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new EventHandler(this.btnNumber_Click);
            
            this.btn6.Location = new Point(190, 180);
            this.btn6.Name = "btn6";
            this.btn6.Size = new Size(50, 50);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new EventHandler(this.btnNumber_Click);
            
            // Buttons 7-9
            this.btn7.Location = new Point(50, 240);
            this.btn7.Name = "btn7";
            this.btn7.Size = new Size(50, 50);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new EventHandler(this.btnNumber_Click);
            
            this.btn8.Location = new Point(120, 240);
            this.btn8.Name = "btn8";
            this.btn8.Size = new Size(50, 50);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new EventHandler(this.btnNumber_Click);
            
            this.btn9.Location = new Point(190, 240);
            this.btn9.Name = "btn9";
            this.btn9.Size = new Size(50, 50);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new EventHandler(this.btnNumber_Click);
            
            // Button 0, Clear, Enter
            this.btn0.Location = new Point(120, 300);
            this.btn0.Name = "btn0";
            this.btn0.Size = new Size(50, 50);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new EventHandler(this.btnNumber_Click);
            
            this.btnClear.Location = new Point(50, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(50, 50);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            
            this.btnEnter.Location = new Point(190, 300);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new Size(50, 50);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new EventHandler(this.btnEnter_Click);
            
            // lstLog
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new Point(50, 370);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new Size(350, 120);
            this.lstLog.TabIndex = 15;
            
            // Form1
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(450, 520);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Security Panel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

#endregion
}
