
namespace FontusHealthCRM
{
    partial class FormCCGs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCCGs));
            this.lblCCGs = new System.Windows.Forms.Label();
            this.dgvCCG = new System.Windows.Forms.DataGridView();
            this.btnDash = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCCGs
            // 
            this.lblCCGs.AutoSize = true;
            this.lblCCGs.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCGs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCCGs.Location = new System.Drawing.Point(306, 47);
            this.lblCCGs.Name = "lblCCGs";
            this.lblCCGs.Size = new System.Drawing.Size(80, 28);
            this.lblCCGs.TabIndex = 19;
            this.lblCCGs.Text = "CCGs";
            // 
            // dgvCCG
            // 
            this.dgvCCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCCG.Location = new System.Drawing.Point(35, 129);
            this.dgvCCG.Name = "dgvCCG";
            this.dgvCCG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCCG.Size = new System.Drawing.Size(600, 500);
            this.dgvCCG.TabIndex = 18;
            this.dgvCCG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCCG_CellContentClick);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.Location = new System.Drawing.Point(35, 25);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(132, 48);
            this.btnDash.TabIndex = 17;
            this.btnDash.Text = "Back To Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(563, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(72, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 22;
            this.picLogo.TabStop = false;
            // 
            // FormCCGs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 656);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblCCGs);
            this.Controls.Add(this.dgvCCG);
            this.Controls.Add(this.btnDash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCCGs";
            this.Text = "FormCCGs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCCGs;
        private System.Windows.Forms.DataGridView dgvCCG;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.PictureBox picLogo;
    }
}