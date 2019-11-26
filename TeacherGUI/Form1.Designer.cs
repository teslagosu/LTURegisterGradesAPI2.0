namespace TeacherGUI
{
    partial class Form1
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
            this.button_register_grade = new System.Windows.Forms.Button();
            this.textBox_studid = new System.Windows.Forms.TextBox();
            this.label_studid = new System.Windows.Forms.Label();
            this.label_course_code = new System.Windows.Forms.Label();
            this.textBox_course_code = new System.Windows.Forms.TextBox();
            this.label_test_number = new System.Windows.Forms.Label();
            this.textBox_test_number = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label_grade = new System.Windows.Forms.Label();
            this.textBox_grade = new System.Windows.Forms.TextBox();
            this.Label_term = new System.Windows.Forms.Label();
            this.textBox_term = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_register_grade
            // 
            this.button_register_grade.Location = new System.Drawing.Point(91, 158);
            this.button_register_grade.Name = "button_register_grade";
            this.button_register_grade.Size = new System.Drawing.Size(368, 148);
            this.button_register_grade.TabIndex = 0;
            this.button_register_grade.Text = "Registrera betyg";
            this.button_register_grade.UseVisualStyleBackColor = true;
            this.button_register_grade.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_studid
            // 
            this.textBox_studid.Location = new System.Drawing.Point(12, 49);
            this.textBox_studid.Name = "textBox_studid";
            this.textBox_studid.Size = new System.Drawing.Size(103, 20);
            this.textBox_studid.TabIndex = 1;
            // 
            // label_studid
            // 
            this.label_studid.AutoSize = true;
            this.label_studid.Location = new System.Drawing.Point(12, 30);
            this.label_studid.Name = "label_studid";
            this.label_studid.Size = new System.Drawing.Size(53, 13);
            this.label_studid.TabIndex = 2;
            this.label_studid.Text = "student-id";
            // 
            // label_course_code
            // 
            this.label_course_code.AutoSize = true;
            this.label_course_code.Location = new System.Drawing.Point(142, 30);
            this.label_course_code.Name = "label_course_code";
            this.label_course_code.Size = new System.Drawing.Size(45, 13);
            this.label_course_code.TabIndex = 3;
            this.label_course_code.Text = "kurskod";
            // 
            // textBox_course_code
            // 
            this.textBox_course_code.Location = new System.Drawing.Point(145, 49);
            this.textBox_course_code.Name = "textBox_course_code";
            this.textBox_course_code.Size = new System.Drawing.Size(103, 20);
            this.textBox_course_code.TabIndex = 4;
            // 
            // label_test_number
            // 
            this.label_test_number.AutoSize = true;
            this.label_test_number.Location = new System.Drawing.Point(435, 30);
            this.label_test_number.Name = "label_test_number";
            this.label_test_number.Size = new System.Drawing.Size(65, 13);
            this.label_test_number.TabIndex = 5;
            this.label_test_number.Text = "provnummer";
            // 
            // textBox_test_number
            // 
            this.textBox_test_number.Location = new System.Drawing.Point(438, 49);
            this.textBox_test_number.Name = "textBox_test_number";
            this.textBox_test_number.Size = new System.Drawing.Size(103, 20);
            this.textBox_test_number.TabIndex = 6;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(571, 30);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(36, 13);
            this.label_date.TabIndex = 7;
            this.label_date.Text = "datum";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(574, 49);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(103, 20);
            this.textBox_date.TabIndex = 8;
            // 
            // label_grade
            // 
            this.label_grade.AutoSize = true;
            this.label_grade.Location = new System.Drawing.Point(700, 30);
            this.label_grade.Name = "label_grade";
            this.label_grade.Size = new System.Drawing.Size(33, 13);
            this.label_grade.TabIndex = 9;
            this.label_grade.Text = "betyg";
            // 
            // textBox_grade
            // 
            this.textBox_grade.Location = new System.Drawing.Point(703, 49);
            this.textBox_grade.Name = "textBox_grade";
            this.textBox_grade.Size = new System.Drawing.Size(43, 20);
            this.textBox_grade.TabIndex = 10;
            // 
            // Label_term
            // 
            this.Label_term.AutoSize = true;
            this.Label_term.Location = new System.Drawing.Point(266, 29);
            this.Label_term.Name = "Label_term";
            this.Label_term.Size = new System.Drawing.Size(35, 13);
            this.Label_term.TabIndex = 11;
            this.Label_term.Text = "termin";
            // 
            // textBox_term
            // 
            this.textBox_term.Location = new System.Drawing.Point(269, 49);
            this.textBox_term.Name = "textBox_term";
            this.textBox_term.Size = new System.Drawing.Size(107, 20);
            this.textBox_term.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 654);
            this.Controls.Add(this.textBox_term);
            this.Controls.Add(this.Label_term);
            this.Controls.Add(this.textBox_grade);
            this.Controls.Add(this.label_grade);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.textBox_test_number);
            this.Controls.Add(this.label_test_number);
            this.Controls.Add(this.textBox_course_code);
            this.Controls.Add(this.label_course_code);
            this.Controls.Add(this.label_studid);
            this.Controls.Add(this.textBox_studid);
            this.Controls.Add(this.button_register_grade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_register_grade;
        private System.Windows.Forms.TextBox textBox_studid;
        private System.Windows.Forms.Label label_studid;
        private System.Windows.Forms.Label label_course_code;
        private System.Windows.Forms.TextBox textBox_course_code;
        private System.Windows.Forms.Label label_test_number;
        private System.Windows.Forms.TextBox textBox_test_number;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label_grade;
        private System.Windows.Forms.TextBox textBox_grade;
        private System.Windows.Forms.Label Label_term;
        private System.Windows.Forms.TextBox textBox_term;
    }
}

