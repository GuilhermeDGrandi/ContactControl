namespace ContactControll
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
            lblLogin = new Label();
            lblPass = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(198, 136);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(52, 18);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPass.Location = new Point(198, 179);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(85, 18);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(291, 136);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(159, 23);
            txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(291, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(398, 208);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(52, 22);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnter);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblPass);
            Controls.Add(lblLogin);
            Name = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblPass;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnEnter;
    }
}