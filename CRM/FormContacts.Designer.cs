
namespace FontusHealthCRM
{
    partial class FormContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContacts));
            this.lblContacts = new System.Windows.Forms.Label();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.btnDash = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblContInsights = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContacts.Location = new System.Drawing.Point(292, 43);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(117, 28);
            this.lblContacts.TabIndex = 26;
            this.lblContacts.Text = "Contacts";
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(30, 122);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(600, 318);
            this.dgvContacts.TabIndex = 25;
            this.dgvContacts.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellMouseLeave);
            this.dgvContacts.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContacts_CellMouseMove);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.Location = new System.Drawing.Point(30, 23);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(132, 48);
            this.btnDash.TabIndex = 24;
            this.btnDash.Text = "Back To Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(551, 23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(72, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 27;
            this.picLogo.TabStop = false;
            // 
            // lblContInsights
            // 
            this.lblContInsights.AutoSize = true;
            this.lblContInsights.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblContInsights.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContInsights.Location = new System.Drawing.Point(27, 454);
            this.lblContInsights.Name = "lblContInsights";
            this.lblContInsights.Size = new System.Drawing.Size(220, 18);
            this.lblContInsights.TabIndex = 28;
            this.lblContInsights.Text = "HOVER TO VIEW INSIGHTS";
            // 
            // FormContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 705);
            this.Controls.Add(this.lblContInsights);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.btnDash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContacts";
            this.Text = "FormContacts";
            this.Load += new System.EventHandler(this.FormContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblContInsights;
    }
}