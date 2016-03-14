namespace Steam_Game_Randomizer
{
    partial class Form1
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
            this.butSearch = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtAppNums = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butVisitSite = new System.Windows.Forms.Button();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSearchStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(264, 175);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(87, 34);
            this.butSearch.TabIndex = 0;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(100, 79);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(294, 22);
            this.txtURL.TabIndex = 1;
            // 
            // txtAppNums
            // 
            this.txtAppNums.Location = new System.Drawing.Point(417, 181);
            this.txtAppNums.Multiline = true;
            this.txtAppNums.Name = "txtAppNums";
            this.txtAppNums.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAppNums.Size = new System.Drawing.Size(204, 97);
            this.txtAppNums.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "App Numbers Searched";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(335, 29);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(59, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // butVisitSite
            // 
            this.butVisitSite.Location = new System.Drawing.Point(436, 28);
            this.butVisitSite.Name = "butVisitSite";
            this.butVisitSite.Size = new System.Drawing.Size(139, 73);
            this.butVisitSite.TabIndex = 6;
            this.butVisitSite.Text = "Open in Browser";
            this.butVisitSite.UseVisualStyleBackColor = true;
            this.butVisitSite.Click += new System.EventHandler(this.butVisitSite_Click);
            // 
            // txtGameName
            // 
            this.txtGameName.Location = new System.Drawing.Point(100, 29);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(183, 22);
            this.txtGameName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Game:";
            // 
            // numMaxPrice
            // 
            this.numMaxPrice.DecimalPlaces = 2;
            this.numMaxPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numMaxPrice.Location = new System.Drawing.Point(120, 181);
            this.numMaxPrice.Name = "numMaxPrice";
            this.numMaxPrice.Size = new System.Drawing.Size(120, 22);
            this.numMaxPrice.TabIndex = 9;
            this.numMaxPrice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "URL:";
            // 
            // lblSearchStatus
            // 
            this.lblSearchStatus.AutoSize = true;
            this.lblSearchStatus.Location = new System.Drawing.Point(117, 239);
            this.lblSearchStatus.Name = "lblSearchStatus";
            this.lblSearchStatus.Size = new System.Drawing.Size(96, 17);
            this.lblSearchStatus.TabIndex = 12;
            this.lblSearchStatus.Text = "Click \"Search\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 305);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSearchStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMaxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGameName);
            this.Controls.Add(this.butVisitSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAppNums);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.butSearch);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Steam Game Randomizer - Free Software by Austin Steingrube";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtAppNums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butVisitSite;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSearchStatus;
        private System.Windows.Forms.Label label6;
    }
}

