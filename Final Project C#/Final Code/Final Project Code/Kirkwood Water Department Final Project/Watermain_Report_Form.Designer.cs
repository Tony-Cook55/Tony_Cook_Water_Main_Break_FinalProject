namespace Kirkwood_Water_Department_Final_Project
{
    partial class Watermain_Report_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Watermain_Report_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVisableProblem = new System.Windows.Forms.ComboBox();
            this.pbStreetMap = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPleaseSelectARoad = new System.Windows.Forms.Label();
            this.rbMcCullough_Ave = new System.Windows.Forms.RadioButton();
            this.rbMonroe_Ave = new System.Windows.Forms.RadioButton();
            this.rbScott_Ave = new System.Windows.Forms.RadioButton();
            this.rbWoodbine_Ave = new System.Windows.Forms.RadioButton();
            this.rbClinton_Pl = new System.Windows.Forms.RadioButton();
            this.rbLillian_Ave = new System.Windows.Forms.RadioButton();
            this.rbRose_Ln = new System.Windows.Forms.RadioButton();
            this.rbLee_Ave = new System.Windows.Forms.RadioButton();
            this.rbRose_Hill_Ave = new System.Windows.Forms.RadioButton();
            this.rbMidway_Ave = new System.Windows.Forms.RadioButton();
            this.rbElliott_Ave = new System.Windows.Forms.RadioButton();
            this.lblErrorFillInfo = new System.Windows.Forms.Label();
            this.btnSubmitForm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.cbWhoIsReportingBreak = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStreetMap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(367, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Fill Out All Fields To Report a Water Main Break";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(70, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(70, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 31);
            this.txtName.TabIndex = 1;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(248, 179);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(320, 31);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(70, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Who is reporting the Break?";
            // 
            // cbVisableProblem
            // 
            this.cbVisableProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisableProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVisableProblem.FormattingEnabled = true;
            this.cbVisableProblem.Items.AddRange(new object[] {
            "Water leaking out of Fire Hydrant",
            "Water on Road",
            "Pipe Outburst",
            "No running water in household",
            "Overflooded street or sewers",
            "Other"});
            this.cbVisableProblem.Location = new System.Drawing.Point(70, 499);
            this.cbVisableProblem.Name = "cbVisableProblem";
            this.cbVisableProblem.Size = new System.Drawing.Size(402, 33);
            this.cbVisableProblem.TabIndex = 4;
            this.cbVisableProblem.Enter += new System.EventHandler(this.cbVisableProblem_Enter);
            this.cbVisableProblem.Leave += new System.EventHandler(this.cbVisableProblem_Leave);
            // 
            // pbStreetMap
            // 
            this.pbStreetMap.Image = global::Kirkwood_Water_Department_Final_Project.Properties.Resources.Kirkwood_Street_View_With_Names___Copy;
            this.pbStreetMap.Location = new System.Drawing.Point(666, 130);
            this.pbStreetMap.Name = "pbStreetMap";
            this.pbStreetMap.Size = new System.Drawing.Size(459, 626);
            this.pbStreetMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStreetMap.TabIndex = 10;
            this.pbStreetMap.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(70, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "What seems to be the visible problem?";
            // 
            // lblPleaseSelectARoad
            // 
            this.lblPleaseSelectARoad.AutoSize = true;
            this.lblPleaseSelectARoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPleaseSelectARoad.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPleaseSelectARoad.Location = new System.Drawing.Point(586, 102);
            this.lblPleaseSelectARoad.Name = "lblPleaseSelectARoad";
            this.lblPleaseSelectARoad.Size = new System.Drawing.Size(605, 25);
            this.lblPleaseSelectARoad.TabIndex = 14;
            this.lblPleaseSelectARoad.Text = "Where is the Main Break located? Please Select a Road From the Map:\r\n";
            // 
            // rbMcCullough_Ave
            // 
            this.rbMcCullough_Ave.AutoSize = true;
            this.rbMcCullough_Ave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbMcCullough_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMcCullough_Ave.Location = new System.Drawing.Point(685, 282);
            this.rbMcCullough_Ave.Name = "rbMcCullough_Ave";
            this.rbMcCullough_Ave.Size = new System.Drawing.Size(149, 25);
            this.rbMcCullough_Ave.TabIndex = 5;
            this.rbMcCullough_Ave.Text = "McCullough Ave";
            this.rbMcCullough_Ave.UseVisualStyleBackColor = false;
            // 
            // rbMonroe_Ave
            // 
            this.rbMonroe_Ave.AutoSize = true;
            this.rbMonroe_Ave.BackColor = System.Drawing.Color.White;
            this.rbMonroe_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMonroe_Ave.Location = new System.Drawing.Point(1023, 260);
            this.rbMonroe_Ave.Name = "rbMonroe_Ave";
            this.rbMonroe_Ave.Size = new System.Drawing.Size(90, 25);
            this.rbMonroe_Ave.TabIndex = 11;
            this.rbMonroe_Ave.Text = "Monroe";
            this.rbMonroe_Ave.UseVisualStyleBackColor = false;
            // 
            // rbScott_Ave
            // 
            this.rbScott_Ave.AutoSize = true;
            this.rbScott_Ave.BackColor = System.Drawing.Color.White;
            this.rbScott_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbScott_Ave.Location = new System.Drawing.Point(1035, 292);
            this.rbScott_Ave.Name = "rbScott_Ave";
            this.rbScott_Ave.Size = new System.Drawing.Size(70, 25);
            this.rbScott_Ave.TabIndex = 12;
            this.rbScott_Ave.Text = "Scott";
            this.rbScott_Ave.UseVisualStyleBackColor = false;
            // 
            // rbWoodbine_Ave
            // 
            this.rbWoodbine_Ave.AutoSize = true;
            this.rbWoodbine_Ave.BackColor = System.Drawing.Color.White;
            this.rbWoodbine_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbWoodbine_Ave.Location = new System.Drawing.Point(715, 370);
            this.rbWoodbine_Ave.Name = "rbWoodbine_Ave";
            this.rbWoodbine_Ave.Size = new System.Drawing.Size(136, 25);
            this.rbWoodbine_Ave.TabIndex = 6;
            this.rbWoodbine_Ave.Text = "Woodbine Ave";
            this.rbWoodbine_Ave.UseVisualStyleBackColor = false;
            // 
            // rbClinton_Pl
            // 
            this.rbClinton_Pl.AutoSize = true;
            this.rbClinton_Pl.BackColor = System.Drawing.Color.White;
            this.rbClinton_Pl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbClinton_Pl.Location = new System.Drawing.Point(951, 349);
            this.rbClinton_Pl.Name = "rbClinton_Pl";
            this.rbClinton_Pl.Size = new System.Drawing.Size(102, 25);
            this.rbClinton_Pl.TabIndex = 13;
            this.rbClinton_Pl.Text = "Clinton Pl";
            this.rbClinton_Pl.UseVisualStyleBackColor = false;
            // 
            // rbLillian_Ave
            // 
            this.rbLillian_Ave.AutoSize = true;
            this.rbLillian_Ave.BackColor = System.Drawing.Color.White;
            this.rbLillian_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLillian_Ave.Location = new System.Drawing.Point(874, 401);
            this.rbLillian_Ave.Name = "rbLillian_Ave";
            this.rbLillian_Ave.Size = new System.Drawing.Size(106, 25);
            this.rbLillian_Ave.TabIndex = 15;
            this.rbLillian_Ave.Text = "Lillian Ave";
            this.rbLillian_Ave.UseVisualStyleBackColor = false;
            // 
            // rbRose_Ln
            // 
            this.rbRose_Ln.AutoSize = true;
            this.rbRose_Ln.BackColor = System.Drawing.Color.White;
            this.rbRose_Ln.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbRose_Ln.Location = new System.Drawing.Point(697, 401);
            this.rbRose_Ln.Name = "rbRose_Ln";
            this.rbRose_Ln.Size = new System.Drawing.Size(90, 25);
            this.rbRose_Ln.TabIndex = 7;
            this.rbRose_Ln.Text = "Rose Ln";
            this.rbRose_Ln.UseVisualStyleBackColor = false;
            // 
            // rbLee_Ave
            // 
            this.rbLee_Ave.AutoSize = true;
            this.rbLee_Ave.BackColor = System.Drawing.Color.White;
            this.rbLee_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLee_Ave.Location = new System.Drawing.Point(685, 432);
            this.rbLee_Ave.Name = "rbLee_Ave";
            this.rbLee_Ave.Size = new System.Drawing.Size(89, 25);
            this.rbLee_Ave.TabIndex = 8;
            this.rbLee_Ave.Text = "Lee Ave";
            this.rbLee_Ave.UseVisualStyleBackColor = false;
            // 
            // rbRose_Hill_Ave
            // 
            this.rbRose_Hill_Ave.AutoSize = true;
            this.rbRose_Hill_Ave.BackColor = System.Drawing.Color.White;
            this.rbRose_Hill_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbRose_Hill_Ave.Location = new System.Drawing.Point(715, 463);
            this.rbRose_Hill_Ave.Name = "rbRose_Hill_Ave";
            this.rbRose_Hill_Ave.Size = new System.Drawing.Size(126, 25);
            this.rbRose_Hill_Ave.TabIndex = 9;
            this.rbRose_Hill_Ave.Text = "Rose Hill Ave";
            this.rbRose_Hill_Ave.UseVisualStyleBackColor = false;
            // 
            // rbMidway_Ave
            // 
            this.rbMidway_Ave.AutoSize = true;
            this.rbMidway_Ave.BackColor = System.Drawing.Color.White;
            this.rbMidway_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMidway_Ave.Location = new System.Drawing.Point(697, 494);
            this.rbMidway_Ave.Name = "rbMidway_Ave";
            this.rbMidway_Ave.Size = new System.Drawing.Size(120, 25);
            this.rbMidway_Ave.TabIndex = 10;
            this.rbMidway_Ave.Text = "Midway Ave";
            this.rbMidway_Ave.UseVisualStyleBackColor = false;
            // 
            // rbElliott_Ave
            // 
            this.rbElliott_Ave.AutoSize = true;
            this.rbElliott_Ave.BackColor = System.Drawing.Color.White;
            this.rbElliott_Ave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbElliott_Ave.Location = new System.Drawing.Point(1001, 380);
            this.rbElliott_Ave.Name = "rbElliott_Ave";
            this.rbElliott_Ave.Size = new System.Drawing.Size(104, 25);
            this.rbElliott_Ave.TabIndex = 14;
            this.rbElliott_Ave.Text = "Elliott Ave";
            this.rbElliott_Ave.UseVisualStyleBackColor = false;
            // 
            // lblErrorFillInfo
            // 
            this.lblErrorFillInfo.AutoSize = true;
            this.lblErrorFillInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorFillInfo.Location = new System.Drawing.Point(172, 726);
            this.lblErrorFillInfo.Name = "lblErrorFillInfo";
            this.lblErrorFillInfo.Size = new System.Drawing.Size(0, 30);
            this.lblErrorFillInfo.TabIndex = 31;
            // 
            // btnSubmitForm
            // 
            this.btnSubmitForm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitForm.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSubmitForm.Location = new System.Drawing.Point(210, 671);
            this.btnSubmitForm.Name = "btnSubmitForm";
            this.btnSubmitForm.Size = new System.Drawing.Size(163, 52);
            this.btnSubmitForm.TabIndex = 16;
            this.btnSubmitForm.Text = "Submit Form";
            this.btnSubmitForm.UseVisualStyleBackColor = false;
            this.btnSubmitForm.Click += new System.EventHandler(this.btnSubmitForm_Click);
            this.btnSubmitForm.Enter += new System.EventHandler(this.Buttons_Enter_Focus);
            this.btnSubmitForm.Leave += new System.EventHandler(this.Buttons_Leave_Focus);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(29, 624);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(539, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "Once All Fields Have Been Filled, Press Submit";
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReturnToMainForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturnToMainForm.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnReturnToMainForm.Location = new System.Drawing.Point(1159, 12);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(142, 34);
            this.btnReturnToMainForm.TabIndex = 34;
            this.btnReturnToMainForm.Text = "Return Home";
            this.btnReturnToMainForm.UseVisualStyleBackColor = false;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            this.btnReturnToMainForm.Enter += new System.EventHandler(this.Buttons_Enter_Focus);
            this.btnReturnToMainForm.Leave += new System.EventHandler(this.Buttons_Leave_Focus);
            // 
            // cbWhoIsReportingBreak
            // 
            this.cbWhoIsReportingBreak.BackColor = System.Drawing.SystemColors.Window;
            this.cbWhoIsReportingBreak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWhoIsReportingBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWhoIsReportingBreak.FormattingEnabled = true;
            this.cbWhoIsReportingBreak.Items.AddRange(new object[] {
            "Kirkwood Resident",
            "Citizen",
            "Water Department Employee",
            "Police Officer"});
            this.cbWhoIsReportingBreak.Location = new System.Drawing.Point(70, 308);
            this.cbWhoIsReportingBreak.Name = "cbWhoIsReportingBreak";
            this.cbWhoIsReportingBreak.Size = new System.Drawing.Size(264, 33);
            this.cbWhoIsReportingBreak.TabIndex = 3;
            this.cbWhoIsReportingBreak.Enter += new System.EventHandler(this.cbWhoIsReportingBreak_Enter);
            this.cbWhoIsReportingBreak.Leave += new System.EventHandler(this.cbWhoIsReportingBreak_Leave);
            // 
            // Watermain_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1313, 770);
            this.Controls.Add(this.cbWhoIsReportingBreak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSubmitForm);
            this.Controls.Add(this.lblErrorFillInfo);
            this.Controls.Add(this.rbElliott_Ave);
            this.Controls.Add(this.rbMidway_Ave);
            this.Controls.Add(this.rbRose_Hill_Ave);
            this.Controls.Add(this.rbLee_Ave);
            this.Controls.Add(this.rbRose_Ln);
            this.Controls.Add(this.rbLillian_Ave);
            this.Controls.Add(this.rbClinton_Pl);
            this.Controls.Add(this.rbWoodbine_Ave);
            this.Controls.Add(this.rbScott_Ave);
            this.Controls.Add(this.rbMonroe_Ave);
            this.Controls.Add(this.rbMcCullough_Ave);
            this.Controls.Add(this.lblPleaseSelectARoad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbStreetMap);
            this.Controls.Add(this.cbVisableProblem);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Watermain_Report_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report a Water Main Break Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbStreetMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPhoneNumber;
        private Label label5;
        private ComboBox cbVisableProblem;
        private PictureBox pbStreetMap;
        private Label label7;
        private Label lblPleaseSelectARoad;
        private RadioButton rbMcCullough_Ave;
        private RadioButton rbMonroe_Ave;
        private RadioButton rbScott_Ave;
        private RadioButton rbWoodbine_Ave;
        private RadioButton rbClinton_Pl;
        private RadioButton rbLillian_Ave;
        private RadioButton rbRose_Ln;
        private RadioButton rbLee_Ave;
        private RadioButton rbRose_Hill_Ave;
        private RadioButton rbMidway_Ave;
        private RadioButton rbElliott_Ave;
        private Label lblErrorFillInfo;
        private Button btnSubmitForm;
        private Label label9;
        private Button btnReturnToMainForm;
        private ComboBox cbWhoIsReportingBreak;
    }
}