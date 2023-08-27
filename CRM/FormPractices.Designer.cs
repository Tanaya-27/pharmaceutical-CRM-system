
namespace FontusHealthCRM
{
    partial class FormPractices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPractices));
            this.lblPractices = new System.Windows.Forms.Label();
            this.dgvPractices = new System.Windows.Forms.DataGridView();
            this.btnDash = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPractices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPractices
            // 
            this.lblPractices.AutoSize = true;
            this.lblPractices.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPractices.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPractices.Location = new System.Drawing.Point(294, 50);
            this.lblPractices.Name = "lblPractices";
            this.lblPractices.Size = new System.Drawing.Size(123, 28);
            this.lblPractices.TabIndex = 30;
            this.lblPractices.Text = "Practices";
            // 
            // dgvPractices
            // 
            this.dgvPractices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPractices.Location = new System.Drawing.Point(32, 134);
            this.dgvPractices.Name = "dgvPractices";
            this.dgvPractices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPractices.Size = new System.Drawing.Size(600, 500);
            this.dgvPractices.TabIndex = 25;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.Location = new System.Drawing.Point(32, 30);
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
            this.picLogo.Location = new System.Drawing.Point(552, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(72, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 31;
            this.picLogo.TabStop = false;
            // 
            // FormPractices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 660);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblPractices);
            this.Controls.Add(this.dgvPractices);
            this.Controls.Add(this.btnDash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPractices";
            this.Text = "FormPractices";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPractices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPractices;
        private System.Windows.Forms.DataGridView dgvPractices;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.PictureBox picLogo;
    }
}