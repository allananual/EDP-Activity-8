namespace Activity_8
{
    partial class employee_hr
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
            this.GetButton = new System.Windows.Forms.Button();
            this.PayrollRB = new System.Windows.Forms.RadioButton();
            this.ResearchRB = new System.Windows.Forms.RadioButton();
            this.TechRB = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PostButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HR_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HR_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetButton.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(15, 223);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(606, 48);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "GET";
            this.GetButton.UseVisualStyleBackColor = false;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // PayrollRB
            // 
            this.PayrollRB.AutoSize = true;
            this.PayrollRB.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayrollRB.Location = new System.Drawing.Point(263, 190);
            this.PayrollRB.Name = "PayrollRB";
            this.PayrollRB.Size = new System.Drawing.Size(68, 26);
            this.PayrollRB.TabIndex = 20;
            this.PayrollRB.TabStop = true;
            this.PayrollRB.Text = "Payroll";
            this.PayrollRB.UseVisualStyleBackColor = true;
            this.PayrollRB.CheckedChanged += new System.EventHandler(this.PayrollRB_CheckedChanged);
            // 
            // ResearchRB
            // 
            this.ResearchRB.AutoSize = true;
            this.ResearchRB.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResearchRB.Location = new System.Drawing.Point(263, 160);
            this.ResearchRB.Name = "ResearchRB";
            this.ResearchRB.Size = new System.Drawing.Size(82, 26);
            this.ResearchRB.TabIndex = 19;
            this.ResearchRB.TabStop = true;
            this.ResearchRB.Text = "Research";
            this.ResearchRB.UseVisualStyleBackColor = true;
            this.ResearchRB.CheckedChanged += new System.EventHandler(this.ResearchRB_CheckedChanged);
            // 
            // TechRB
            // 
            this.TechRB.AutoSize = true;
            this.TechRB.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechRB.Location = new System.Drawing.Point(263, 130);
            this.TechRB.Name = "TechRB";
            this.TechRB.Size = new System.Drawing.Size(106, 26);
            this.TechRB.TabIndex = 18;
            this.TechRB.TabStop = true;
            this.TechRB.Text = "Tech Support";
            this.TechRB.UseVisualStyleBackColor = true;
            this.TechRB.CheckedChanged += new System.EventHandler(this.TechRB_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HR_dataGridView);
            this.panel2.Controls.Add(this.GetButton);
            this.panel2.Location = new System.Drawing.Point(17, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 285);
            this.panel2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Salary";
            // 
            // SalaryTB
            // 
            this.SalaryTB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryTB.Location = new System.Drawing.Point(263, 232);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(230, 24);
            this.SalaryTB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department";
            // 
            // EmailTB
            // 
            this.EmailTB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTB.Location = new System.Drawing.Point(263, 93);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(230, 24);
            this.EmailTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(263, 54);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(230, 24);
            this.PasswordTB.TabIndex = 3;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.Location = new System.Drawing.Point(263, 15);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(230, 24);
            this.UsernameTB.TabIndex = 2;
            // 
            // PostButton
            // 
            this.PostButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PostButton.Font = new System.Drawing.Font("Glacial Indifference", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostButton.Location = new System.Drawing.Point(15, 279);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(606, 48);
            this.PostButton.TabIndex = 1;
            this.PostButton.Text = "POST";
            this.PostButton.UseVisualStyleBackColor = false;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PayrollRB);
            this.panel1.Controls.Add(this.ResearchRB);
            this.panel1.Controls.Add(this.TechRB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SalaryTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmailTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PasswordTB);
            this.panel1.Controls.Add(this.UsernameTB);
            this.panel1.Controls.Add(this.PostButton);
            this.panel1.Location = new System.Drawing.Point(17, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 338);
            this.panel1.TabIndex = 20;
            // 
            // HR_dataGridView
            // 
            this.HR_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HR_dataGridView.Location = new System.Drawing.Point(15, 12);
            this.HR_dataGridView.Name = "HR_dataGridView";
            this.HR_dataGridView.Size = new System.Drawing.Size(606, 195);
            this.HR_dataGridView.TabIndex = 2;
            // 
            // employee_hr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(675, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "employee_hr";
            this.Text = "employee_hr";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HR_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.RadioButton PayrollRB;
        private System.Windows.Forms.RadioButton ResearchRB;
        private System.Windows.Forms.RadioButton TechRB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView HR_dataGridView;
    }
}

