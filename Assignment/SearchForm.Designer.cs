
namespace Assignment
{
    partial class SearchForm
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
            this.labelSearchHeading = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.StudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchHeading
            // 
            this.labelSearchHeading.AutoSize = true;
            this.labelSearchHeading.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchHeading.Location = new System.Drawing.Point(211, 13);
            this.labelSearchHeading.Name = "labelSearchHeading";
            this.labelSearchHeading.Size = new System.Drawing.Size(103, 37);
            this.labelSearchHeading.TabIndex = 0;
            this.labelSearchHeading.Text = "Search";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(1, 74);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(65, 13);
            this.labelStudentId.TabIndex = 1;
            this.labelStudentId.Text = "Student\'s ID";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(91, 67);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(282, 20);
            this.textBoxStudentID.TabIndex = 2;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNumber,
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnDOB,
            this.ColumnGender,
            this.ColumnPhone,
            this.ColumnAddress,
            this.ColumnModule});
            this.dataGridViewSearch.Location = new System.Drawing.Point(4, 142);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(841, 150);
            this.dataGridViewSearch.TabIndex = 3;
            this.dataGridViewSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearch_CellContentClick);
            // 
            // StudentNumber
            // 
            this.StudentNumber.HeaderText = "Student Number";
            this.StudentNumber.Name = "StudentNumber";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "Surname";
            this.ColumnSurname.Name = "ColumnSurname";
            // 
            // ColumnDOB
            // 
            this.ColumnDOB.HeaderText = "Date Of Birth";
            this.ColumnDOB.Name = "ColumnDOB";
            // 
            // ColumnGender
            // 
            this.ColumnGender.HeaderText = "Gender";
            this.ColumnGender.Name = "ColumnGender";
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "Phone Number";
            this.ColumnPhone.Name = "ColumnPhone";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // ColumnModule
            // 
            this.ColumnModule.HeaderText = "Module Description";
            this.ColumnModule.Name = "ColumnModule";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(457, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelSearchHeading);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchHeading;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModule;
        private System.Windows.Forms.Button buttonSearch;
    }
}