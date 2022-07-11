
namespace Assignment2
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
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblSal = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.gpemptp = new System.Windows.Forms.GroupBox();
            this.rbPr = new System.Windows.Forms.RadioButton();
            this.rbCons = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gpemptp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(135, 80);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(103, 20);
            this.lblEmpNo.TabIndex = 0;
            this.lblEmpNo.Text = "Employee No";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(135, 151);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(125, 20);
            this.lblEmpName.TabIndex = 1;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lblSal
            // 
            this.lblSal.AutoSize = true;
            this.lblSal.Location = new System.Drawing.Point(135, 227);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(53, 20);
            this.lblSal.TabIndex = 2;
            this.lblSal.Text = "Salary";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(271, 79);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(127, 26);
            this.txtEmpNo.TabIndex = 3;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(271, 151);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(127, 26);
            this.txtEmpName.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(271, 224);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(127, 26);
            this.txtSalary.TabIndex = 5;
            // 
            // gpemptp
            // 
            this.gpemptp.Controls.Add(this.rbCons);
            this.gpemptp.Controls.Add(this.rbPr);
            this.gpemptp.Location = new System.Drawing.Point(432, 98);
            this.gpemptp.Name = "gpemptp";
            this.gpemptp.Size = new System.Drawing.Size(275, 196);
            this.gpemptp.TabIndex = 9;
            this.gpemptp.TabStop = false;
            this.gpemptp.Text = "Employee Type";
            // 
            // rbPr
            // 
            this.rbPr.AutoSize = true;
            this.rbPr.Location = new System.Drawing.Point(22, 48);
            this.rbPr.Name = "rbPr";
            this.rbPr.Size = new System.Drawing.Size(80, 24);
            this.rbPr.TabIndex = 0;
            this.rbPr.TabStop = true;
            this.rbPr.Text = "Payroll";
            this.rbPr.UseVisualStyleBackColor = true;
            // 
            // rbCons
            // 
            this.rbCons.AutoSize = true;
            this.rbCons.Location = new System.Drawing.Point(22, 93);
            this.rbCons.Name = "rbCons";
            this.rbCons.Size = new System.Drawing.Size(111, 24);
            this.rbCons.TabIndex = 1;
            this.rbCons.TabStop = true;
            this.rbCons.Text = "Consultant";
            this.rbCons.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(333, 320);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gpemptp);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpNo);
            this.Controls.Add(this.lblSal);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpemptp.ResumeLayout(false);
            this.gpemptp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.GroupBox gpemptp;
        private System.Windows.Forms.RadioButton rbCons;
        private System.Windows.Forms.RadioButton rbPr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
    }
}

