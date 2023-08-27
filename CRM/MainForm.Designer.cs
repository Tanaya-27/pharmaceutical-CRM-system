
namespace FontusHealthCRM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblPercentSales = new System.Windows.Forms.Label();
            this.lblTop10 = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnActivities = new System.Windows.Forms.Button();
            this.btnSamples = new System.Windows.Forms.Button();
            this.btnPractices = new System.Windows.Forms.Button();
            this.btnCCGs = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.chartPercentOfSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopPracs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkMyDataOnly = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPercentOfSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopPracs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPercentSales
            // 
            this.lblPercentSales.AutoSize = true;
            this.lblPercentSales.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentSales.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPercentSales.Location = new System.Drawing.Point(574, 253);
            this.lblPercentSales.Name = "lblPercentSales";
            this.lblPercentSales.Size = new System.Drawing.Size(162, 25);
            this.lblPercentSales.TabIndex = 25;
            this.lblPercentSales.Text = "% of total sales";
            // 
            // lblTop10
            // 
            this.lblTop10.AutoSize = true;
            this.lblTop10.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTop10.Location = new System.Drawing.Point(133, 253);
            this.lblTop10.Name = "lblTop10";
            this.lblTop10.Size = new System.Drawing.Size(187, 25);
            this.lblTop10.TabIndex = 24;
            this.lblTop10.Text = "top 10 purchasers";
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDash.Location = new System.Drawing.Point(27, 36);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(240, 38);
            this.lblDash.TabIndex = 20;
            this.lblDash.Text = "DASHBOARD";
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContacts.Location = new System.Drawing.Point(367, 142);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(132, 48);
            this.btnContacts.TabIndex = 19;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click_1);
            // 
            // btnActivities
            // 
            this.btnActivities.BackColor = System.Drawing.Color.SkyBlue;
            this.btnActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.Location = new System.Drawing.Point(538, 142);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(132, 48);
            this.btnActivities.TabIndex = 18;
            this.btnActivities.Text = "Activities";
            this.btnActivities.UseVisualStyleBackColor = false;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click_1);
            // 
            // btnSamples
            // 
            this.btnSamples.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSamples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSamples.Location = new System.Drawing.Point(706, 142);
            this.btnSamples.Name = "btnSamples";
            this.btnSamples.Size = new System.Drawing.Size(132, 48);
            this.btnSamples.TabIndex = 17;
            this.btnSamples.Text = "Samples";
            this.btnSamples.UseVisualStyleBackColor = false;
            this.btnSamples.Click += new System.EventHandler(this.btnSamples_Click_1);
            // 
            // btnPractices
            // 
            this.btnPractices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPractices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPractices.Location = new System.Drawing.Point(199, 142);
            this.btnPractices.Name = "btnPractices";
            this.btnPractices.Size = new System.Drawing.Size(132, 48);
            this.btnPractices.TabIndex = 16;
            this.btnPractices.Text = "Practices";
            this.btnPractices.UseVisualStyleBackColor = false;
            this.btnPractices.Click += new System.EventHandler(this.btnPractices_Click_1);
            // 
            // btnCCGs
            // 
            this.btnCCGs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCCGs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCCGs.ForeColor = System.Drawing.Color.Black;
            this.btnCCGs.Location = new System.Drawing.Point(34, 142);
            this.btnCCGs.Name = "btnCCGs";
            this.btnCCGs.Size = new System.Drawing.Size(132, 48);
            this.btnCCGs.TabIndex = 15;
            this.btnCCGs.Text = "CCGs";
            this.btnCCGs.UseVisualStyleBackColor = false;
            this.btnCCGs.Click += new System.EventHandler(this.btnCCGs_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Enabled = false;
            this.btnAdmin.Location = new System.Drawing.Point(637, 22);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(217, 81);
            this.btnAdmin.TabIndex = 31;
            this.btnAdmin.Text = "ADMINISTRATION";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // chartPercentOfSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPercentOfSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPercentOfSales.Legends.Add(legend1);
            this.chartPercentOfSales.Location = new System.Drawing.Point(458, 290);
            this.chartPercentOfSales.Name = "chartPercentOfSales";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Value";
            this.chartPercentOfSales.Series.Add(series1);
            this.chartPercentOfSales.Size = new System.Drawing.Size(380, 348);
            this.chartPercentOfSales.TabIndex = 32;
            this.chartPercentOfSales.Text = "chart1";
            // 
            // chartTopPracs
            // 
            this.chartTopPracs.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chartTopPracs.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopPracs.Legends.Add(legend2);
            this.chartTopPracs.Location = new System.Drawing.Point(37, 290);
            this.chartTopPracs.Name = "chartTopPracs";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Value, £";
            this.chartTopPracs.Series.Add(series2);
            this.chartTopPracs.Size = new System.Drawing.Size(374, 348);
            this.chartTopPracs.TabIndex = 32;
            this.chartTopPracs.Text = "chart1";
            // 
            // chkMyDataOnly
            // 
            this.chkMyDataOnly.AutoSize = true;
            this.chkMyDataOnly.Enabled = false;
            this.chkMyDataOnly.Location = new System.Drawing.Point(717, 666);
            this.chkMyDataOnly.Name = "chkMyDataOnly";
            this.chkMyDataOnly.Size = new System.Drawing.Size(121, 17);
            this.chkMyDataOnly.TabIndex = 33;
            this.chkMyDataOnly.Text = "Show My Stats Only";
            this.chkMyDataOnly.UseVisualStyleBackColor = true;
            this.chkMyDataOnly.CheckedChanged += new System.EventHandler(this.chkMyDataOnly_CheckedChanged);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(272, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(72, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 35;
            this.picLogo.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(553, 22);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(63, 81);
            this.btnLogOut.TabIndex = 36;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 704);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.chkMyDataOnly);
            this.Controls.Add(this.chartTopPracs);
            this.Controls.Add(this.chartPercentOfSales);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblPercentSales);
            this.Controls.Add(this.lblTop10);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnActivities);
            this.Controls.Add(this.btnSamples);
            this.Controls.Add(this.btnPractices);
            this.Controls.Add(this.btnCCGs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Fontus Health - Dashbord";
            ((System.ComponentModel.ISupportInitialize)(this.chartPercentOfSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopPracs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPercentSales;
        private System.Windows.Forms.Label lblTop10;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.Button btnSamples;
        private System.Windows.Forms.Button btnPractices;
        private System.Windows.Forms.Button btnCCGs;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPercentOfSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopPracs;
        private System.Windows.Forms.CheckBox chkMyDataOnly;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLogOut;
    }
}

