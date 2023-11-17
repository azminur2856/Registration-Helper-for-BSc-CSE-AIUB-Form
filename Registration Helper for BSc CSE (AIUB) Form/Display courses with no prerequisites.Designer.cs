namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    partial class Display_courses_with_no_prerequisites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display_courses_with_no_prerequisites));
            this.dataGridViewForNoPrerequisites = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreRequisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForNoPrerequisites)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForNoPrerequisites
            // 
            this.dataGridViewForNoPrerequisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForNoPrerequisites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.CourseDescription,
            this.PreRequisite,
            this.Credit});
            this.dataGridViewForNoPrerequisites.Location = new System.Drawing.Point(6, 64);
            this.dataGridViewForNoPrerequisites.Name = "dataGridViewForNoPrerequisites";
            this.dataGridViewForNoPrerequisites.RowHeadersWidth = 51;
            this.dataGridViewForNoPrerequisites.RowTemplate.Height = 24;
            this.dataGridViewForNoPrerequisites.Size = new System.Drawing.Size(1134, 657);
            this.dataGridViewForNoPrerequisites.TabIndex = 14;
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
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.Info;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(1002, 18);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(138, 35);
            this.backbutton.TabIndex = 16;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Display courses with no prerequisites";
            // 
            // Display_courses_with_no_prerequisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 652);
            this.Controls.Add(this.dataGridViewForNoPrerequisites);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display_courses_with_no_prerequisites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display courses with no prerequisites";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForNoPrerequisites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForNoPrerequisites;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreRequisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label1;
    }
}