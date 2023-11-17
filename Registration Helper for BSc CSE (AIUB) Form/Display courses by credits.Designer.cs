namespace Registration_Helper_for_BSc_CSE_AIUB_Form
{
    partial class Display_courses_by_credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display_courses_by_credits));
            this.dataGridViewForDisplaycoursesbycredits = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreRequisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForDisplaycoursesbycredits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForDisplaycoursesbycredits
            // 
            this.dataGridViewForDisplaycoursesbycredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForDisplaycoursesbycredits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.CourseDescription,
            this.PreRequisite,
            this.Credit});
            this.dataGridViewForDisplaycoursesbycredits.Location = new System.Drawing.Point(1, 92);
            this.dataGridViewForDisplaycoursesbycredits.Name = "dataGridViewForDisplaycoursesbycredits";
            this.dataGridViewForDisplaycoursesbycredits.RowHeadersWidth = 51;
            this.dataGridViewForDisplaycoursesbycredits.RowTemplate.Height = 24;
            this.dataGridViewForDisplaycoursesbycredits.Size = new System.Drawing.Size(1134, 740);
            this.dataGridViewForDisplaycoursesbycredits.TabIndex = 17;
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
            this.backbutton.Location = new System.Drawing.Point(997, 8);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(138, 35);
            this.backbutton.TabIndex = 19;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Display courses by credits";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(495, 58);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(153, 22);
            this.textBox.TabIndex = 20;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Info;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(668, 51);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(138, 35);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Input Credits";
            // 
            // Display_courses_by_credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dataGridViewForDisplaycoursesbycredits);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display_courses_by_credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display courses by credits";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForDisplaycoursesbycredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForDisplaycoursesbycredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreRequisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
    }
}