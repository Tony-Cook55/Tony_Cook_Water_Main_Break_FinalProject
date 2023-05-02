namespace Employee_Login___Report_Break
{
    partial class Succsessful_LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Succsessful_LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogoutUser = new System.Windows.Forms.Button();
            this.lblWelcomeNAME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reported Main Breaks:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(94, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 154);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(94, 349);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(269, 154);
            this.listBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees Working Today:";
            // 
            // btnLogoutUser
            // 
            this.btnLogoutUser.Location = new System.Drawing.Point(819, 12);
            this.btnLogoutUser.Name = "btnLogoutUser";
            this.btnLogoutUser.Size = new System.Drawing.Size(84, 34);
            this.btnLogoutUser.TabIndex = 4;
            this.btnLogoutUser.Text = "Logout";
            this.btnLogoutUser.UseVisualStyleBackColor = true;
            this.btnLogoutUser.Click += new System.EventHandler(this.btnLogoutUser_Click);
            // 
            // lblWelcomeNAME
            // 
            this.lblWelcomeNAME.AutoSize = true;
            this.lblWelcomeNAME.Location = new System.Drawing.Point(661, 21);
            this.lblWelcomeNAME.Name = "lblWelcomeNAME";
            this.lblWelcomeNAME.Size = new System.Drawing.Size(82, 25);
            this.lblWelcomeNAME.TabIndex = 5;
            this.lblWelcomeNAME.Text = "welcome";
            // 
            // Succsessful_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 554);
            this.Controls.Add(this.lblWelcomeNAME);
            this.Controls.Add(this.btnLogoutUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Succsessful_LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Succsessful_Login";
            this.Load += new System.EventHandler(this.Succsessful_LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Button btnLogoutUser;
        private Label lblWelcomeNAME;
    }
}