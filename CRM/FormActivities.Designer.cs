
namespace FontusHealthCRM
{
    partial class FormActivities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActivities));
            this.lblActivities = new System.Windows.Forms.Label();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblDateOf = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnEditActivity = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dtpDateOf = new System.Windows.Forms.DateTimePicker();
            this.comboContName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivities
            // 
            this.lblActivities.AutoSize = true;
            this.lblActivities.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivities.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblActivities.Location = new System.Drawing.Point(360, 48);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(128, 28);
            this.lblActivities.TabIndex = 34;
            this.lblActivities.Text = "Activities";
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(26, 128);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(693, 381);
            this.dgvActivities.TabIndex = 33;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.Location = new System.Drawing.Point(26, 28);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(132, 48);
            this.btnDash.TabIndex = 32;
            this.btnDash.Text = "Back To Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddActivity.Location = new System.Drawing.Point(26, 583);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(693, 34);
            this.btnAddActivity.TabIndex = 36;
            this.btnAddActivity.Text = "Add Activity";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(72, 523);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(78, 13);
            this.lblContactName.TabIndex = 38;
            this.lblContactName.Text = "Contact Name:";
            // 
            // lblDateOf
            // 
            this.lblDateOf.AutoSize = true;
            this.lblDateOf.Location = new System.Drawing.Point(250, 523);
            this.lblDateOf.Name = "lblDateOf";
            this.lblDateOf.Size = new System.Drawing.Size(82, 13);
            this.lblDateOf.TabIndex = 40;
            this.lblDateOf.Text = "Date of Activity:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(454, 523);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 42;
            this.lblType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(399, 544);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(140, 20);
            this.txtType.TabIndex = 41;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(637, 523);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 44;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(579, 544);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(140, 20);
            this.txtNotes.TabIndex = 43;
            // 
            // btnEditActivity
            // 
            this.btnEditActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditActivity.Location = new System.Drawing.Point(737, 427);
            this.btnEditActivity.Name = "btnEditActivity";
            this.btnEditActivity.Size = new System.Drawing.Size(79, 81);
            this.btnEditActivity.TabIndex = 45;
            this.btnEditActivity.Text = "Edit";
            this.btnEditActivity.UseVisualStyleBackColor = true;
            this.btnEditActivity.Click += new System.EventHandler(this.btnEditActivity_Click);
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(737, 523);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 41);
            this.btnOK.TabIndex = 46;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::FontusHealthCRM.Properties.Resources.refresh_symbol_1;
            this.picRefresh.Location = new System.Drawing.Point(174, 40);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(26, 26);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 47;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(647, 28);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(72, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 48;
            this.picLogo.TabStop = false;
            // 
            // dtpDateOf
            // 
            this.dtpDateOf.Location = new System.Drawing.Point(218, 544);
            this.dtpDateOf.Name = "dtpDateOf";
            this.dtpDateOf.Size = new System.Drawing.Size(140, 20);
            this.dtpDateOf.TabIndex = 49;
            // 
            // comboContName
            // 
            this.comboContName.FormattingEnabled = true;
            this.comboContName.Location = new System.Drawing.Point(35, 543);
            this.comboContName.Name = "comboContName";
            this.comboContName.Size = new System.Drawing.Size(140, 21);
            this.comboContName.TabIndex = 50;
            // 
            // FormActivities
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(837, 653);
            this.Controls.Add(this.comboContName);
            this.Controls.Add(this.dtpDateOf);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEditActivity);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblDateOf);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.lblActivities);
            this.Controls.Add(this.dgvActivities);
            this.Controls.Add(this.btnDash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormActivities";
            this.Text = "FormActivities";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblDateOf;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnEditActivity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DateTimePicker dtpDateOf;
        private System.Windows.Forms.ComboBox comboContName;
    }
}