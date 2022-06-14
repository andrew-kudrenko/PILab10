namespace PILab10
{
    partial class CustomElementsForm
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
            this.LetterStatsData = new System.Windows.Forms.DataGridView();
            this.LetterWithStats = new PILab10.WordLenStats();
            ((System.ComponentModel.ISupportInitialize)(this.LetterStatsData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "For Dear Aliens";
            // 
            // LetterStatsData
            // 
            this.LetterStatsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LetterStatsData.Location = new System.Drawing.Point(12, 161);
            this.LetterStatsData.Name = "LetterStatsData";
            this.LetterStatsData.Size = new System.Drawing.Size(263, 147);
            this.LetterStatsData.TabIndex = 2;
            // 
            // LetterWithStats
            // 
            this.LetterWithStats.Location = new System.Drawing.Point(12, 25);
            this.LetterWithStats.Multiline = true;
            this.LetterWithStats.Name = "LetterWithStats";
            this.LetterWithStats.Size = new System.Drawing.Size(263, 130);
            this.LetterWithStats.TabIndex = 0;
            this.LetterWithStats.Text = "Hello world! I am from the Earth planet. I am Andrew. I am a human writing this l" +
    "etter for you, my dear aliens. Hello, aliens! I hope you will be fine";
            this.LetterWithStats.Leave += new System.EventHandler(this.OnTextChanged);
            // 
            // CustomElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 319);
            this.Controls.Add(this.LetterStatsData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LetterWithStats);
            this.Name = "CustomElementsForm";
            this.Text = "CustomElementsForm";
            ((System.ComponentModel.ISupportInitialize)(this.LetterStatsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WordLenStats LetterWithStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LetterStatsData;
    }
}