
namespace FontusHealthCRM
{
    partial class FormSamples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSamples));
            this.dgvSamples = new System.Windows.Forms.DataGridView();
            this.btnDash = new System.Windows.Forms.Button();
            this.lblContactName = new System.Windows.Forms.Label();
            this.btnAddSample = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSamples = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lsbBasket = new System.Windows.Forms.ListBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboContName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSamples
            // 
            this.dgvSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSamples.Location = new System.Drawing.Point(35, 136);
            this.dgvSamples.Name = "dgvSamples";
            this.dgvSamples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSamples.Size = new System.Drawing.Size(455, 381);
            this.dgvSamples.TabIndex = 33;
            this.dgvSamples.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.Location = new System.Drawing.Point(35, 36);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(132, 48);
            this.btnDash.TabIndex = 32;
            this.btnDash.Text = "Back To Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(72, 528);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(78, 13);
            this.lblContactName.TabIndex = 47;
            this.lblContactName.Text = "Contact Name:";
            // 
            // btnAddSample
            // 
            this.btnAddSample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSample.Location = new System.Drawing.Point(35, 591);
            this.btnAddSample.Name = "btnAddSample";
            this.btnAddSample.Size = new System.Drawing.Size(446, 34);
            this.btnAddSample.TabIndex = 45;
            this.btnAddSample.Text = "Add Sample";
            this.btnAddSample.UseVisualStyleBackColor = true;
            this.btnAddSample.Click += new System.EventHandler(this.btnAddSample_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(512, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 85);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Placed",
            "Despatched",
            "Recieved"});
            this.comboStatus.Location = new System.Drawing.Point(512, 137);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(114, 21);
            this.comboStatus.TabIndex = 51;
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = global::FontusHealthCRM.Properties.Resources.refresh_symbol_1;
            this.picRefresh.Location = new System.Drawing.Point(181, 48);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(26, 26);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 52;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(531, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(72, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 53;
            this.picLogo.TabStop = false;
            // 
            // lblSamples
            // 
            this.lblSamples.AutoSize = true;
            this.lblSamples.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamples.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSamples.Location = new System.Drawing.Point(289, 59);
            this.lblSamples.Name = "lblSamples";
            this.lblSamples.Size = new System.Drawing.Size(113, 28);
            this.lblSamples.TabIndex = 54;
            this.lblSamples.Text = "Samples";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(245, 528);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(47, 13);
            this.lblProduct.TabIndex = 47;
            this.lblProduct.Text = "Product:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(362, 528);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 47;
            this.lblQuantity.Text = "Quantity:";
            // 
            // comboProduct
            // 
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(186, 552);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(161, 21);
            this.comboProduct.TabIndex = 55;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Location = new System.Drawing.Point(431, 538);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(50, 38);
            this.btnAddItem.TabIndex = 57;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_1);
            // 
            // lsbBasket
            // 
            this.lsbBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lsbBasket.FormattingEnabled = true;
            this.lsbBasket.Location = new System.Drawing.Point(506, 504);
            this.lsbBasket.Name = "lsbBasket";
            this.lsbBasket.ScrollAlwaysVisible = true;
            this.lsbBasket.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbBasket.Size = new System.Drawing.Size(130, 121);
            this.lsbBasket.TabIndex = 59;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(354, 552);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(57, 20);
            this.nudQuantity.TabIndex = 60;
            // 
            // comboContName
            // 
            this.comboContName.FormattingEnabled = true;
            this.comboContName.Location = new System.Drawing.Point(40, 552);
            this.comboContName.Name = "comboContName";
            this.comboContName.Size = new System.Drawing.Size(139, 21);
            this.comboContName.TabIndex = 61;
            // 
            // FormSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 699);
            this.Controls.Add(this.comboContName);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lsbBasket);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.lblSamples);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.btnAddSample);
            this.Controls.Add(this.dgvSamples);
            this.Controls.Add(this.btnDash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSamples";
            this.Text = "FormSamples";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSamples;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Button btnAddSample;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSamples;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lsbBasket;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox comboContName;
    }
}