
namespace Assignment
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSTNUM = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPNumber = new System.Windows.Forms.Label();
            this.labelPAddress = new System.Windows.Forms.Label();
            this.labelModuleCodes = new System.Windows.Forms.Label();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxPNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxModuleCode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE";
            // 
            // labelSTNUM
            // 
            this.labelSTNUM.AutoSize = true;
            this.labelSTNUM.Location = new System.Drawing.Point(18, 61);
            this.labelSTNUM.Name = "labelSTNUM";
            this.labelSTNUM.Size = new System.Drawing.Size(84, 13);
            this.labelSTNUM.TabIndex = 1;
            this.labelSTNUM.Text = "Student Number";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(18, 100);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(54, 13);
            this.labelFname.TabIndex = 2;
            this.labelFname.Text = "FirstName";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(18, 136);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(55, 13);
            this.labelLName.TabIndex = 3;
            this.labelLName.Text = "LastName";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(18, 175);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(68, 13);
            this.labelDOB.TabIndex = 4;
            this.labelDOB.Text = "Date Of Birth";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(18, 208);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Gender";
            // 
            // labelPNumber
            // 
            this.labelPNumber.AutoSize = true;
            this.labelPNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPNumber.Location = new System.Drawing.Point(21, 242);
            this.labelPNumber.Name = "labelPNumber";
            this.labelPNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPNumber.TabIndex = 6;
            this.labelPNumber.Text = "Phone Number";
            // 
            // labelPAddress
            // 
            this.labelPAddress.AutoSize = true;
            this.labelPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelPAddress.Location = new System.Drawing.Point(21, 278);
            this.labelPAddress.Name = "labelPAddress";
            this.labelPAddress.Size = new System.Drawing.Size(87, 13);
            this.labelPAddress.TabIndex = 7;
            this.labelPAddress.Text = "Physical Address";
            // 
            // labelModuleCodes
            // 
            this.labelModuleCodes.AutoSize = true;
            this.labelModuleCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelModuleCodes.Location = new System.Drawing.Point(24, 315);
            this.labelModuleCodes.Name = "labelModuleCodes";
            this.labelModuleCodes.Size = new System.Drawing.Size(75, 13);
            this.labelModuleCodes.TabIndex = 8;
            this.labelModuleCodes.Text = "Module Codes";
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Location = new System.Drawing.Point(183, 58);
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentNumber.TabIndex = 9;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Location = new System.Drawing.Point(183, 100);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(100, 20);
            this.textBoxFname.TabIndex = 10;
            this.textBoxFname.TextChanged += new System.EventHandler(this.textBoxFname_TextChanged);
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(183, 133);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLName.TabIndex = 11;
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Location = new System.Drawing.Point(183, 175);
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(100, 20);
            this.textBoxDOB.TabIndex = 12;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(183, 208);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(100, 20);
            this.textBoxGender.TabIndex = 13;
            // 
            // textBoxPNumber
            // 
            this.textBoxPNumber.Location = new System.Drawing.Point(183, 242);
            this.textBoxPNumber.Name = "textBoxPNumber";
            this.textBoxPNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPNumber.TabIndex = 14;
            this.textBoxPNumber.TextChanged += new System.EventHandler(this.textBoxPNumber_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(183, 278);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 15;
            // 
            // textBoxModuleCode
            // 
            this.textBoxModuleCode.Location = new System.Drawing.Point(183, 315);
            this.textBoxModuleCode.Name = "textBoxModuleCode";
            this.textBoxModuleCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxModuleCode.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(476, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 284);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(276, 360);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(156, 23);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxModuleCode);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPNumber);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxDOB);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.textBoxStudentNumber);
            this.Controls.Add(this.labelModuleCodes);
            this.Controls.Add(this.labelPAddress);
            this.Controls.Add(this.labelPNumber);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelSTNUM);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.textBoxAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSTNUM;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPNumber;
        private System.Windows.Forms.Label labelPAddress;
        private System.Windows.Forms.Label labelModuleCodes;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxPNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxModuleCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
    }
}