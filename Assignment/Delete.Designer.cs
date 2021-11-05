
namespace Assignment
{
    partial class Delete
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
            this.labelStudentNum = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxStudentNum = new System.Windows.Forms.TextBox();
            this.labelDeleteHeader = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudentNum
            // 
            this.labelStudentNum.AutoSize = true;
            this.labelStudentNum.Location = new System.Drawing.Point(12, 89);
            this.labelStudentNum.Name = "labelStudentNum";
            this.labelStudentNum.Size = new System.Drawing.Size(84, 13);
            this.labelStudentNum.TabIndex = 0;
            this.labelStudentNum.Text = "Student Number";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(14, 124);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(54, 13);
            this.labelFname.TabIndex = 1;
            this.labelFname.Text = "FirstName";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(13, 156);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(55, 13);
            this.labelLname.TabIndex = 2;
            this.labelLname.Text = "LastName";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(13, 222);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(68, 13);
            this.labelDOB.TabIndex = 3;
            this.labelDOB.Text = "Date Of Birth";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 259);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(87, 13);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Physical Address";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(13, 187);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(78, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone Number";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // textBoxStudentNum
            // 
            this.textBoxStudentNum.Location = new System.Drawing.Point(137, 89);
            this.textBoxStudentNum.Name = "textBoxStudentNum";
            this.textBoxStudentNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentNum.TabIndex = 6;
            // 
            // labelDeleteHeader
            // 
            this.labelDeleteHeader.AutoSize = true;
            this.labelDeleteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteHeader.Location = new System.Drawing.Point(233, 13);
            this.labelDeleteHeader.Name = "labelDeleteHeader";
            this.labelDeleteHeader.Size = new System.Drawing.Size(90, 29);
            this.labelDeleteHeader.TabIndex = 7;
            this.labelDeleteHeader.Text = "Delete";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(137, 124);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(100, 20);
            this.textBoxFname.TabIndex = 8;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(137, 156);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(100, 20);
            this.textBoxLname.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(137, 187);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 10;
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Location = new System.Drawing.Point(137, 222);
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(100, 20);
            this.textBoxDOB.TabIndex = 11;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(137, 259);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 12;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(238, 350);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxDOB);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.labelDeleteHeader);
            this.Controls.Add(this.textBoxStudentNum);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelStudentNum);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentNum;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxStudentNum;
        private System.Windows.Forms.Label labelDeleteHeader;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonDelete;
    }
}