namespace CardPackGenerator
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CardImageWidth = new System.Windows.Forms.NumericUpDown();
            this.CardImageHeight = new System.Windows.Forms.NumericUpDown();
            this.CardBoarderWidth = new System.Windows.Forms.NumericUpDown();
            this.CardBoarderHeight = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Rows = new System.Windows.Forms.NumericUpDown();
            this.Columns = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CardImageWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardImageHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBoarderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBoarderHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Boarder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Height";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(307, 530);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 43);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(416, 530);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 43);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CardImageWidth
            // 
            this.CardImageWidth.Location = new System.Drawing.Point(173, 142);
            this.CardImageWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CardImageWidth.Name = "CardImageWidth";
            this.CardImageWidth.Size = new System.Drawing.Size(120, 26);
            this.CardImageWidth.TabIndex = 12;
            // 
            // CardImageHeight
            // 
            this.CardImageHeight.Location = new System.Drawing.Point(173, 220);
            this.CardImageHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CardImageHeight.Name = "CardImageHeight";
            this.CardImageHeight.Size = new System.Drawing.Size(120, 26);
            this.CardImageHeight.TabIndex = 13;
            // 
            // CardBoarderWidth
            // 
            this.CardBoarderWidth.Location = new System.Drawing.Point(540, 142);
            this.CardBoarderWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CardBoarderWidth.Name = "CardBoarderWidth";
            this.CardBoarderWidth.Size = new System.Drawing.Size(120, 26);
            this.CardBoarderWidth.TabIndex = 14;
            // 
            // CardBoarderHeight
            // 
            this.CardBoarderHeight.Location = new System.Drawing.Point(540, 220);
            this.CardBoarderHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CardBoarderHeight.Name = "CardBoarderHeight";
            this.CardBoarderHeight.Size = new System.Drawing.Size(120, 26);
            this.CardBoarderHeight.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Number of Rows";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Number of Columns";
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(318, 426);
            this.Rows.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Rows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(120, 26);
            this.Rows.TabIndex = 18;
            this.Rows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(318, 369);
            this.Columns.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Columns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(120, 26);
            this.Columns.TabIndex = 19;
            this.Columns.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 618);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CardBoarderHeight);
            this.Controls.Add(this.CardBoarderWidth);
            this.Controls.Add(this.CardImageHeight);
            this.Controls.Add(this.CardImageWidth);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.CardImageWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardImageHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBoarderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBoarderHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OKButton; 
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown CardImageWidth;
        private System.Windows.Forms.NumericUpDown CardImageHeight;
        private System.Windows.Forms.NumericUpDown CardBoarderHeight;
        private System.Windows.Forms.NumericUpDown CardBoarderWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Rows;
        private System.Windows.Forms.NumericUpDown Columns;
    }
}