namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    partial class Check_available_courses_based_on_completed_courses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_available_courses_based_on_completed_courses));
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreRequisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses
            // 
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.CourseDescription,
            this.PreRequisite,
            this.Credit});
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.Location = new System.Drawing.Point(7, 134);
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.Name = "dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses";
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.RowHeadersWidth = 51;
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.RowTemplate.Height = 24;
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.Size = new System.Drawing.Size(1134, 495);
            this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses.TabIndex = 23;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // CourseDescription
            // 
            this.CourseDescription.HeaderText = "CourseDescription";
            this.CourseDescription.MinimumWidth = 6;
            this.CourseDescription.Name = "CourseDescription";
            this.CourseDescription.Width = 350;
            // 
            // PreRequisite
            // 
            this.PreRequisite.HeaderText = "PreRequisite";
            this.PreRequisite.MinimumWidth = 6;
            this.PreRequisite.Name = "PreRequisite";
            this.PreRequisite.Width = 250;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.MinimumWidth = 6;
            this.Credit.Name = "Credit";
            this.Credit.Width = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Input Course Code";
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.SystemColors.Info;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.Location = new System.Drawing.Point(1003, 48);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(138, 35);
            this.CheckButton.TabIndex = 27;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(159, 55);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(838, 22);
            this.textBox.TabIndex = 26;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.Info;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(1003, 5);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(138, 35);
            this.backbutton.TabIndex = 25;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Display available courses based on completed courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(806, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Enter last semester completed course codes separated by commas (e.g. MAT1102,PHY1" +
    "101,PHY1102,ENG1101,CSC1101,CSC1103,CSC1102,......)\r\n";
            // 
            // Check_available_courses_based_on_completed_courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Check_available_courses_based_on_completed_courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check available courses based on completed courses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForCheckAvailableCoursesBasedOnCompletedCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreRequisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}