
namespace FontusHealthCRM
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.btnSamples = new System.Windows.Forms.Button();
            this.btnPractices = new System.Windows.Forms.Button();
            this.btnCCGs = new System.Windows.Forms.Button();
            this.dgvSelectedTable = new System.Windows.Forms.DataGridView();
            this.lblSelectedTable = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(723, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(72, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 22;
            this.picLogo.TabStop = false;
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContacts.Location = new System.Drawing.Point(228, 33);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(75, 44);
            this.btnContacts.TabIndex = 27;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnActivities
            // 
            this.btnActivities.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivities.Location = new System.Drawing.Point(324, 33);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(80, 44);
            this.btnActivities.TabIndex = 26;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = false;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // btnSamples
            // 
            this.btnSamples.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSamples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSamples.Location = new System.Drawing.Point(427, 33);
            this.btnSamples.Name = "btnSamples";
            this.btnSamples.Size = new System.Drawing.Size(74, 44);
            this.btnSamples.TabIndex = 25;
            this.btnSamples.Text = "Samples";
            this.btnSamples.UseVisualStyleBackColor = false;
            this.btnSamples.Click += new System.EventHandler(this.btnSamples_Click);
            // 
            // btnPractices
            // 
            this.btnPractices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPractices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPractices.Location = new System.Drawing.Point(126, 33);
            this.btnPractices.Name = "btnPractices";
            this.btnPractices.Size = new System.Drawing.Size(78, 44);
            this.btnPractices.TabIndex = 24;
            this.btnPractices.Text = "Practices";
            this.btnPractices.UseVisualStyleBackColor = false;
            this.btnPractices.Click += new System.EventHandler(this.btnPractices_Click);
            // 
            // btnCCGs
            // 
            this.btnCCGs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCCGs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCCGs.ForeColor = System.Drawing.Color.Black;
            this.btnCCGs.Location = new System.Drawing.Point(28, 33);
            this.btnCCGs.Name = "btnCCGs";
            this.btnCCGs.Size = new System.Drawing.Size(80, 44);
            this.btnCCGs.TabIndex = 23;
            this.btnCCGs.Text = "CCGs";
            this.btnCCGs.UseVisualStyleBackColor = false;
            this.btnCCGs.Click += new System.EventHandler(this.btnCCGs_Click);
            // 
            // dgvSelectedTable
            // 
            this.dgvSelectedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedTable.Location = new System.Drawing.Point(28, 135);
            this.dgvSelectedTable.Name = "dgvSelectedTable";
            this.dgvSelectedTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedTable.Size = new System.Drawing.Size(666, 271);
            this.dgvSelectedTable.TabIndex = 28;
            // 
            // lblSelectedTable
            // 
            this.lblSelectedTable.AutoSize = true;
            this.lblSelectedTable.Font = new System.Drawing.Font("Century", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSelectedTable.Location = new System.Drawing.Point(29, 97);
            this.lblSelectedTable.Name = "lblSelectedTable";
            this.lblSelectedTable.Size = new System.Drawing.Size(270, 23);
            this.lblSelectedTable.TabIndex = 29;
            this.lblSelectedTable.Text = "PLEASE SELECT ABOVE";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(714, 363);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 43);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete Row";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNew.Enabled = false;
            this.btnCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.Location = new System.Drawing.Point(28, 423);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(783, 41);
            this.btnCreateNew.TabIndex = 31;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(714, 314);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 43);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit Row";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::FontusHealthCRM.Properties.Resources.refresh_symbol_1;
            this.picRefresh.Location = new System.Drawing.Point(324, 97);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(26, 26);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 48;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(562, 39);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(97, 37);
            this.btnUser.TabIndex = 49;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(823, 533);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSelectedTable);
            this.Controls.Add(this.dgvSelectedTable);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.btnSamples);
            this.Controls.Add(this.btnPractices);
            this.Controls.Add(this.btnCCGs);
            this.Controls.Add(this.picLogo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.Button btnSamples;
        private System.Windows.Forms.Button btnPractices;
        private System.Windows.Forms.Button btnCCGs;
        private System.Windows.Forms.DataGridView dgvSelectedTable;
        private System.Windows.Forms.Label lblSelectedTable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.Button btnUser;
    }
}