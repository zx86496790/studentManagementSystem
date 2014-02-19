namespace StudentManagementSystem
{
    partial class formManagement
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numStudentInformationGPA = new System.Windows.Forms.NumericUpDown();
            this.calStudentInformationGraduationDate = new System.Windows.Forms.DateTimePicker();
            this.txtStudentInformationStudentProgram = new System.Windows.Forms.TextBox();
            this.txtStudentInformationPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtStudentInformationStudentName = new System.Windows.Forms.TextBox();
            this.lstStudentsInformation = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.calRecordModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.numChangeRecordStudentID = new System.Windows.Forms.NumericUpDown();
            this.numChangeRecordUserID = new System.Windows.Forms.NumericUpDown();
            this.lstChangeRecord = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.calLastLoginDate = new System.Windows.Forms.DateTimePicker();
            this.calUserCreatDate = new System.Windows.Forms.DateTimePicker();
            this.txtUserLevel = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStudentInformationGPA)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeRecordStudentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeRecordUserID)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(12, 18);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = ".";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(334, 278);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numStudentInformationGPA);
            this.tabPage1.Controls.Add(this.calStudentInformationGraduationDate);
            this.tabPage1.Controls.Add(this.txtStudentInformationStudentProgram);
            this.tabPage1.Controls.Add(this.txtStudentInformationPhoneNumber);
            this.tabPage1.Controls.Add(this.txtStudentInformationStudentName);
            this.tabPage1.Controls.Add(this.lstStudentsInformation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(326, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numStudentInformationGPA
            // 
            this.numStudentInformationGPA.Location = new System.Drawing.Point(178, 111);
            this.numStudentInformationGPA.Name = "numStudentInformationGPA";
            this.numStudentInformationGPA.Size = new System.Drawing.Size(142, 21);
            this.numStudentInformationGPA.TabIndex = 6;
            this.numStudentInformationGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calStudentInformationGraduationDate
            // 
            this.calStudentInformationGraduationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calStudentInformationGraduationDate.Location = new System.Drawing.Point(178, 146);
            this.calStudentInformationGraduationDate.Name = "calStudentInformationGraduationDate";
            this.calStudentInformationGraduationDate.Size = new System.Drawing.Size(142, 21);
            this.calStudentInformationGraduationDate.TabIndex = 5;
            // 
            // txtStudentInformationStudentProgram
            // 
            this.txtStudentInformationStudentProgram.Location = new System.Drawing.Point(178, 76);
            this.txtStudentInformationStudentProgram.MaxLength = 20;
            this.txtStudentInformationStudentProgram.Name = "txtStudentInformationStudentProgram";
            this.txtStudentInformationStudentProgram.Size = new System.Drawing.Size(142, 21);
            this.txtStudentInformationStudentProgram.TabIndex = 3;
            this.txtStudentInformationStudentProgram.Text = "student program";
            // 
            // txtStudentInformationPhoneNumber
            // 
            this.txtStudentInformationPhoneNumber.Location = new System.Drawing.Point(178, 41);
            this.txtStudentInformationPhoneNumber.MaxLength = 10;
            this.txtStudentInformationPhoneNumber.Name = "txtStudentInformationPhoneNumber";
            this.txtStudentInformationPhoneNumber.Size = new System.Drawing.Size(142, 21);
            this.txtStudentInformationPhoneNumber.TabIndex = 2;
            this.txtStudentInformationPhoneNumber.Text = "phone number";
            // 
            // txtStudentInformationStudentName
            // 
            this.txtStudentInformationStudentName.Location = new System.Drawing.Point(178, 6);
            this.txtStudentInformationStudentName.MaxLength = 20;
            this.txtStudentInformationStudentName.Name = "txtStudentInformationStudentName";
            this.txtStudentInformationStudentName.Size = new System.Drawing.Size(142, 21);
            this.txtStudentInformationStudentName.TabIndex = 1;
            this.txtStudentInformationStudentName.Text = "student name";
            // 
            // lstStudentsInformation
            // 
            this.lstStudentsInformation.FormattingEnabled = true;
            this.lstStudentsInformation.ItemHeight = 12;
            this.lstStudentsInformation.Location = new System.Drawing.Point(6, 4);
            this.lstStudentsInformation.Name = "lstStudentsInformation";
            this.lstStudentsInformation.Size = new System.Drawing.Size(166, 244);
            this.lstStudentsInformation.TabIndex = 0;
            this.lstStudentsInformation.SelectedIndexChanged += new System.EventHandler(this.lstStudentsInformation_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblStudentID);
            this.tabPage2.Controls.Add(this.lblUserID);
            this.tabPage2.Controls.Add(this.calRecordModifiedDate);
            this.tabPage2.Controls.Add(this.numChangeRecordStudentID);
            this.tabPage2.Controls.Add(this.numChangeRecordUserID);
            this.tabPage2.Controls.Add(this.lstChangeRecord);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Record";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(176, 65);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(77, 12);
            this.lblStudentID.TabIndex = 6;
            this.lblStudentID.Text = "Student ID :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(178, 11);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(59, 12);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "User ID :";
            // 
            // calRecordModifiedDate
            // 
            this.calRecordModifiedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calRecordModifiedDate.Location = new System.Drawing.Point(178, 118);
            this.calRecordModifiedDate.Name = "calRecordModifiedDate";
            this.calRecordModifiedDate.Size = new System.Drawing.Size(142, 21);
            this.calRecordModifiedDate.TabIndex = 4;
            // 
            // numChangeRecordStudentID
            // 
            this.numChangeRecordStudentID.Location = new System.Drawing.Point(259, 62);
            this.numChangeRecordStudentID.Name = "numChangeRecordStudentID";
            this.numChangeRecordStudentID.Size = new System.Drawing.Size(61, 21);
            this.numChangeRecordStudentID.TabIndex = 3;
            this.numChangeRecordStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numChangeRecordUserID
            // 
            this.numChangeRecordUserID.Location = new System.Drawing.Point(259, 6);
            this.numChangeRecordUserID.Name = "numChangeRecordUserID";
            this.numChangeRecordUserID.Size = new System.Drawing.Size(61, 21);
            this.numChangeRecordUserID.TabIndex = 2;
            this.numChangeRecordUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstChangeRecord
            // 
            this.lstChangeRecord.FormattingEnabled = true;
            this.lstChangeRecord.ItemHeight = 12;
            this.lstChangeRecord.Location = new System.Drawing.Point(6, 4);
            this.lstChangeRecord.Name = "lstChangeRecord";
            this.lstChangeRecord.Size = new System.Drawing.Size(166, 244);
            this.lstChangeRecord.TabIndex = 1;
            this.lstChangeRecord.SelectedIndexChanged += new System.EventHandler(this.lstChangeRecord_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.calLastLoginDate);
            this.tabPage3.Controls.Add(this.calUserCreatDate);
            this.tabPage3.Controls.Add(this.txtUserLevel);
            this.tabPage3.Controls.Add(this.txtUserName);
            this.tabPage3.Controls.Add(this.lstUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(326, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Users Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // calLastLoginDate
            // 
            this.calLastLoginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calLastLoginDate.Location = new System.Drawing.Point(178, 103);
            this.calLastLoginDate.Name = "calLastLoginDate";
            this.calLastLoginDate.Size = new System.Drawing.Size(143, 21);
            this.calLastLoginDate.TabIndex = 4;
            // 
            // calUserCreatDate
            // 
            this.calUserCreatDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calUserCreatDate.Location = new System.Drawing.Point(178, 71);
            this.calUserCreatDate.Name = "calUserCreatDate";
            this.calUserCreatDate.Size = new System.Drawing.Size(143, 21);
            this.calUserCreatDate.TabIndex = 3;
            // 
            // txtUserLevel
            // 
            this.txtUserLevel.Location = new System.Drawing.Point(178, 39);
            this.txtUserLevel.Name = "txtUserLevel";
            this.txtUserLevel.Size = new System.Drawing.Size(143, 21);
            this.txtUserLevel.TabIndex = 2;
            this.txtUserLevel.Text = "user level";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(178, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(143, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "user name";
            // 
            // lstUser
            // 
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 12;
            this.lstUser.Location = new System.Drawing.Point(3, 4);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(169, 244);
            this.lstUser.TabIndex = 0;
            this.lstUser.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(347, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(68, 18);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "label1";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(407, 52);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(114, 23);
            this.btnAddRecord.TabIndex = 3;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(407, 112);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(114, 23);
            this.btnUpdateRecord.TabIndex = 4;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(407, 172);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteRecord.TabIndex = 5;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(407, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // formManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(560, 320);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Management System";
            this.Load += new System.EventHandler(this.formManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStudentInformationGPA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeRecordStudentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeRecordUserID)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker calStudentInformationGraduationDate;
        private System.Windows.Forms.TextBox txtStudentInformationStudentProgram;
        private System.Windows.Forms.TextBox txtStudentInformationPhoneNumber;
        private System.Windows.Forms.TextBox txtStudentInformationStudentName;
        private System.Windows.Forms.ListBox lstStudentsInformation;
        private System.Windows.Forms.NumericUpDown numStudentInformationGPA;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.DateTimePicker calRecordModifiedDate;
        private System.Windows.Forms.NumericUpDown numChangeRecordStudentID;
        private System.Windows.Forms.NumericUpDown numChangeRecordUserID;
        private System.Windows.Forms.ListBox lstChangeRecord;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserLevel;
        private System.Windows.Forms.DateTimePicker calLastLoginDate;
        private System.Windows.Forms.DateTimePicker calUserCreatDate;
    }
}