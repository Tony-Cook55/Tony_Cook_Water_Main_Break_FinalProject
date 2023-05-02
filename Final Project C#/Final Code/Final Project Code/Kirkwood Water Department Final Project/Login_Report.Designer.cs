namespace Kirkwood_Water_Department_Final_Project
{
    partial class Login_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Report));
            this.pbPipeBreakBackground = new System.Windows.Forms.PictureBox();
            this.pbWaterFlowGIF = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReportBreak = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbHUGE = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.pbKirkwoodLogoInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeBreakBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWaterFlowGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHUGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKirkwoodLogoInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPipeBreakBackground
            // 
            this.pbPipeBreakBackground.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbPipeBreakBackground.Image = global::Kirkwood_Water_Department_Final_Project.Properties.Resources.pipe_transparent_no_break;
            this.pbPipeBreakBackground.Location = new System.Drawing.Point(-1, -147);
            this.pbPipeBreakBackground.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPipeBreakBackground.Name = "pbPipeBreakBackground";
            this.pbPipeBreakBackground.Size = new System.Drawing.Size(1097, 1007);
            this.pbPipeBreakBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPipeBreakBackground.TabIndex = 0;
            this.pbPipeBreakBackground.TabStop = false;
            // 
            // pbWaterFlowGIF
            // 
            this.pbWaterFlowGIF.Image = global::Kirkwood_Water_Department_Final_Project.Properties.Resources.water_gif_transparent;
            this.pbWaterFlowGIF.Location = new System.Drawing.Point(503, 367);
            this.pbWaterFlowGIF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbWaterFlowGIF.Name = "pbWaterFlowGIF";
            this.pbWaterFlowGIF.Size = new System.Drawing.Size(196, 225);
            this.pbWaterFlowGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWaterFlowGIF.TabIndex = 1;
            this.pbWaterFlowGIF.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(329, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees Please Enter Work Login Credentials:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(368, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(372, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(476, 89);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 31);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(476, 149);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLogin.Location = new System.Drawing.Point(537, 235);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 47);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Enter += new System.EventHandler(this.Buttons_Enter_Focus);
            this.btnLogin.Leave += new System.EventHandler(this.Buttons_Leave_Focus);
            // 
            // btnReportBreak
            // 
            this.btnReportBreak.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReportBreak.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportBreak.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnReportBreak.Location = new System.Drawing.Point(474, 367);
            this.btnReportBreak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportBreak.Name = "btnReportBreak";
            this.btnReportBreak.Size = new System.Drawing.Size(237, 43);
            this.btnReportBreak.TabIndex = 4;
            this.btnReportBreak.Text = "Report Water Main Break";
            this.btnReportBreak.UseVisualStyleBackColor = false;
            this.btnReportBreak.Click += new System.EventHandler(this.btnReportBreak_Click);
            this.btnReportBreak.Enter += new System.EventHandler(this.Buttons_Enter_Focus);
            this.btnReportBreak.Leave += new System.EventHandler(this.Buttons_Leave_Focus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(309, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(630, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "To Report a Water Main Break Please Click The Button";
            // 
            // pbHUGE
            // 
            this.pbHUGE.Location = new System.Drawing.Point(-1, -5);
            this.pbHUGE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbHUGE.Name = "pbHUGE";
            this.pbHUGE.Size = new System.Drawing.Size(1097, 915);
            this.pbHUGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHUGE.TabIndex = 11;
            this.pbHUGE.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(436, 195);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(332, 25);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Invalid Username or Password Entered";
            this.lblError.Visible = false;
            // 
            // pbKirkwoodLogoInfo
            // 
            this.pbKirkwoodLogoInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbKirkwoodLogoInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbKirkwoodLogoInfo.Image")));
            this.pbKirkwoodLogoInfo.Location = new System.Drawing.Point(946, 12);
            this.pbKirkwoodLogoInfo.Name = "pbKirkwoodLogoInfo";
            this.pbKirkwoodLogoInfo.Size = new System.Drawing.Size(132, 129);
            this.pbKirkwoodLogoInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKirkwoodLogoInfo.TabIndex = 16;
            this.pbKirkwoodLogoInfo.TabStop = false;
            this.pbKirkwoodLogoInfo.Click += new System.EventHandler(this.pbKirkwoodLogoInfo_Click);
            // 
            // Login_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 762);
            this.Controls.Add(this.pbKirkwoodLogoInfo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReportBreak);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbWaterFlowGIF);
            this.Controls.Add(this.pbPipeBreakBackground);
            this.Controls.Add(this.pbHUGE);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Login_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Login - Report Water Main Break";
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeBreakBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWaterFlowGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHUGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKirkwoodLogoInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbPipeBreakBackground;
        private PictureBox pbWaterFlowGIF;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnReportBreak;
        private Label label4;
        private PictureBox pbHUGE;
        private Label lblError;
        private PictureBox pbKirkwoodLogoInfo;
    }
}