namespace Assignment5ABC
{
    partial class MainForm
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
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOfficePhone = new System.Windows.Forms.Label();
            this.labelOfficeEmail = new System.Windows.Forms.Label();
            this.labelContactDetails = new System.Windows.Forms.Label();
            this.labelContactResults = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 24;
            this.listBoxCustomers.Location = new System.Drawing.Point(46, 102);
            this.listBoxCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(1014, 508);
            this.listBoxCustomers.TabIndex = 0;
            this.listBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.listBoxCustomers_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelID.Location = new System.Drawing.Point(68, 50);
            this.labelID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 25);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelName.Location = new System.Drawing.Point(170, 50);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(242, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name (Surname, Name)";
            // 
            // labelOfficePhone
            // 
            this.labelOfficePhone.AutoSize = true;
            this.labelOfficePhone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelOfficePhone.Location = new System.Drawing.Point(518, 50);
            this.labelOfficePhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOfficePhone.Name = "labelOfficePhone";
            this.labelOfficePhone.Size = new System.Drawing.Size(136, 25);
            this.labelOfficePhone.TabIndex = 3;
            this.labelOfficePhone.Text = "Office Phone";
            // 
            // labelOfficeEmail
            // 
            this.labelOfficeEmail.AutoSize = true;
            this.labelOfficeEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelOfficeEmail.Location = new System.Drawing.Point(812, 50);
            this.labelOfficeEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOfficeEmail.Name = "labelOfficeEmail";
            this.labelOfficeEmail.Size = new System.Drawing.Size(134, 25);
            this.labelOfficeEmail.TabIndex = 4;
            this.labelOfficeEmail.Text = "Office E-mail";
            // 
            // labelContactDetails
            // 
            this.labelContactDetails.AutoSize = true;
            this.labelContactDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelContactDetails.Location = new System.Drawing.Point(1260, 50);
            this.labelContactDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelContactDetails.Name = "labelContactDetails";
            this.labelContactDetails.Size = new System.Drawing.Size(158, 25);
            this.labelContactDetails.TabIndex = 5;
            this.labelContactDetails.Text = "Contact Details";
            // 
            // labelContactResults
            // 
            this.labelContactResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelContactResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactResults.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelContactResults.Location = new System.Drawing.Point(1092, 102);
            this.labelContactResults.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelContactResults.Name = "labelContactResults";
            this.labelContactResults.Size = new System.Drawing.Size(492, 531);
            this.labelContactResults.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAdd.Location = new System.Drawing.Point(74, 673);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(210, 75);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEdit.Location = new System.Drawing.Point(446, 673);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(210, 75);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Location = new System.Drawing.Point(818, 673);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(210, 75);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 777);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelContactResults);
            this.Controls.Add(this.labelContactDetails);
            this.Controls.Add(this.labelOfficeEmail);
            this.Controls.Add(this.labelOfficePhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.listBoxCustomers);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Registry by Francisco Erazo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOfficePhone;
        private System.Windows.Forms.Label labelOfficeEmail;
        private System.Windows.Forms.Label labelContactDetails;
        private System.Windows.Forms.Label labelContactResults;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}

