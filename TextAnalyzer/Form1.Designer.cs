namespace TextAnalyzer
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInputPrompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gboxAnalysisResults = new System.Windows.Forms.GroupBox();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.lblCharCountResult = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblWordCountResult = new System.Windows.Forms.Label();
            this.lblSentenceCount = new System.Windows.Forms.Label();
            this.lblSentenceCountResult = new System.Windows.Forms.Label();
            this.lblVowelCount = new System.Windows.Forms.Label();
            this.lblVowelCountResult = new System.Windows.Forms.Label();
            this.lblMostFrequentWord = new System.Windows.Forms.Label();
            this.lblMostFrequentWordResult = new System.Windows.Forms.Label();
            this.gboxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchPrompt = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.gboxWordFrequency = new System.Windows.Forms.GroupBox();
            this.lstWordFrequency = new System.Windows.Forms.ListBox();
            this.btnShowFrequency = new System.Windows.Forms.Button();
            this.gboxAdditionalFeatures = new System.Windows.Forms.GroupBox();
            this.btnRemoveStopWords = new System.Windows.Forms.Button();
            this.btnToggleDarkMode = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxAnalysisResults.SuspendLayout();
            this.gboxSearch.SuspendLayout();
            this.gboxWordFrequency.SuspendLayout();
            this.gboxAdditionalFeatures.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();

            // menuStripMain
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(900, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";

            // openToolStripMenuItem
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);

            // saveToolStripMenuItem
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save Results";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);

            // toolStripSeparator1
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);

            // exitToolStripMenuItem
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += (s, e) => this.Close();

            // toolsToolStripMenuItem
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(270, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TEXT ANALYZER - NLP";

            // lblInputPrompt
            this.lblInputPrompt.AutoSize = true;
            this.lblInputPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            this.lblInputPrompt.Location = new System.Drawing.Point(20, 80);
            this.lblInputPrompt.Name = "lblInputPrompt";
            this.lblInputPrompt.Size = new System.Drawing.Size(112, 17);
            this.lblInputPrompt.TabIndex = 2;
            this.lblInputPrompt.Text = "Enter your text:";

            // txtInput
            this.txtInput.Location = new System.Drawing.Point(20, 105);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(860, 120);
            this.txtInput.TabIndex = 3;

            // btnAnalyze
            this.btnAnalyze.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(20, 240);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(120, 35);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "Analyze Text";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(760, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // gboxAnalysisResults
            this.gboxAnalysisResults.Controls.Add(this.lblCharCount);
            this.gboxAnalysisResults.Controls.Add(this.lblCharCountResult);
            this.gboxAnalysisResults.Controls.Add(this.lblWordCount);
            this.gboxAnalysisResults.Controls.Add(this.lblWordCountResult);
            this.gboxAnalysisResults.Controls.Add(this.lblSentenceCount);
            this.gboxAnalysisResults.Controls.Add(this.lblSentenceCountResult);
            this.gboxAnalysisResults.Controls.Add(this.lblVowelCount);
            this.gboxAnalysisResults.Controls.Add(this.lblVowelCountResult);
            this.gboxAnalysisResults.Controls.Add(this.lblMostFrequentWord);
            this.gboxAnalysisResults.Controls.Add(this.lblMostFrequentWordResult);
            this.gboxAnalysisResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gboxAnalysisResults.Location = new System.Drawing.Point(20, 290);
            this.gboxAnalysisResults.Name = "gboxAnalysisResults";
            this.gboxAnalysisResults.Size = new System.Drawing.Size(440, 200);
            this.gboxAnalysisResults.TabIndex = 6;
            this.gboxAnalysisResults.TabStop = false;
            this.gboxAnalysisResults.Text = "Analysis Results";

            // lblCharCount
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(10, 25);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(110, 17);
            this.lblCharCount.TabIndex = 0;
            this.lblCharCount.Text = "Character Count:";

            // lblCharCountResult
            this.lblCharCountResult.AutoSize = true;
            this.lblCharCountResult.Location = new System.Drawing.Point(300, 25);
            this.lblCharCountResult.Name = "lblCharCountResult";
            this.lblCharCountResult.Size = new System.Drawing.Size(16, 17);
            this.lblCharCountResult.TabIndex = 1;
            this.lblCharCountResult.Text = "0";

            // lblWordCount
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(10, 55);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(88, 17);
            this.lblWordCount.TabIndex = 2;
            this.lblWordCount.Text = "Word Count:";

            // lblWordCountResult
            this.lblWordCountResult.AutoSize = true;
            this.lblWordCountResult.Location = new System.Drawing.Point(300, 55);
            this.lblWordCountResult.Name = "lblWordCountResult";
            this.lblWordCountResult.Size = new System.Drawing.Size(16, 17);
            this.lblWordCountResult.TabIndex = 3;
            this.lblWordCountResult.Text = "0";

            // lblSentenceCount
            this.lblSentenceCount.AutoSize = true;
            this.lblSentenceCount.Location = new System.Drawing.Point(10, 85);
            this.lblSentenceCount.Name = "lblSentenceCount";
            this.lblSentenceCount.Size = new System.Drawing.Size(115, 17);
            this.lblSentenceCount.TabIndex = 4;
            this.lblSentenceCount.Text = "Sentence Count:";

            // lblSentenceCountResult
            this.lblSentenceCountResult.AutoSize = true;
            this.lblSentenceCountResult.Location = new System.Drawing.Point(300, 85);
            this.lblSentenceCountResult.Name = "lblSentenceCountResult";
            this.lblSentenceCountResult.Size = new System.Drawing.Size(16, 17);
            this.lblSentenceCountResult.TabIndex = 5;
            this.lblSentenceCountResult.Text = "0";

            // lblVowelCount
            this.lblVowelCount.AutoSize = true;
            this.lblVowelCount.Location = new System.Drawing.Point(10, 115);
            this.lblVowelCount.Name = "lblVowelCount";
            this.lblVowelCount.Size = new System.Drawing.Size(90, 17);
            this.lblVowelCount.TabIndex = 6;
            this.lblVowelCount.Text = "Vowel Count:";

            // lblVowelCountResult
            this.lblVowelCountResult.AutoSize = true;
            this.lblVowelCountResult.Location = new System.Drawing.Point(300, 115);
            this.lblVowelCountResult.Name = "lblVowelCountResult";
            this.lblVowelCountResult.Size = new System.Drawing.Size(16, 17);
            this.lblVowelCountResult.TabIndex = 7;
            this.lblVowelCountResult.Text = "0";

            // lblMostFrequentWord
            this.lblMostFrequentWord.AutoSize = true;
            this.lblMostFrequentWord.Location = new System.Drawing.Point(10, 145);
            this.lblMostFrequentWord.Name = "lblMostFrequentWord";
            this.lblMostFrequentWord.Size = new System.Drawing.Size(134, 17);
            this.lblMostFrequentWord.TabIndex = 8;
            this.lblMostFrequentWord.Text = "Most Frequent Word:";

            // lblMostFrequentWordResult
            this.lblMostFrequentWordResult.AutoSize = true;
            this.lblMostFrequentWordResult.Location = new System.Drawing.Point(300, 145);
            this.lblMostFrequentWordResult.Name = "lblMostFrequentWordResult";
            this.lblMostFrequentWordResult.Size = new System.Drawing.Size(0, 17);
            this.lblMostFrequentWordResult.TabIndex = 9;

            // gboxSearch
            this.gboxSearch.Controls.Add(this.lblSearchPrompt);
            this.gboxSearch.Controls.Add(this.txtSearch);
            this.gboxSearch.Controls.Add(this.btnSearch);
            this.gboxSearch.Controls.Add(this.lblSearchResult);
            this.gboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gboxSearch.Location = new System.Drawing.Point(480, 290);
            this.gboxSearch.Name = "gboxSearch";
            this.gboxSearch.Size = new System.Drawing.Size(400, 130);
            this.gboxSearch.TabIndex = 7;
            this.gboxSearch.TabStop = false;
            this.gboxSearch.Text = "Search Feature";

            // lblSearchPrompt
            this.lblSearchPrompt.AutoSize = true;
            this.lblSearchPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSearchPrompt.Location = new System.Drawing.Point(10, 25);
            this.lblSearchPrompt.Name = "lblSearchPrompt";
            this.lblSearchPrompt.Size = new System.Drawing.Size(94, 15);
            this.lblSearchPrompt.TabIndex = 0;
            this.lblSearchPrompt.Text = "Enter word to search:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(110, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 23);
            this.txtSearch.TabIndex = 1;

            // btnSearch
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(300, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // lblSearchResult
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSearchResult.Location = new System.Drawing.Point(10, 60);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(0, 15);
            this.lblSearchResult.TabIndex = 3;

            // gboxWordFrequency
            this.gboxWordFrequency.Controls.Add(this.lstWordFrequency);
            this.gboxWordFrequency.Controls.Add(this.btnShowFrequency);
            this.gboxWordFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gboxWordFrequency.Location = new System.Drawing.Point(20, 500);
            this.gboxWordFrequency.Name = "gboxWordFrequency";
            this.gboxWordFrequency.Size = new System.Drawing.Size(440, 180);
            this.gboxWordFrequency.TabIndex = 8;
            this.gboxWordFrequency.TabStop = false;
            this.gboxWordFrequency.Text = "Word Frequency";

            // lstWordFrequency
            this.lstWordFrequency.Location = new System.Drawing.Point(10, 30);
            this.lstWordFrequency.Name = "lstWordFrequency";
            this.lstWordFrequency.Size = new System.Drawing.Size(420, 120);
            this.lstWordFrequency.TabIndex = 0;

            // btnShowFrequency
            this.btnShowFrequency.BackColor = System.Drawing.Color.Orange;
            this.btnShowFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowFrequency.ForeColor = System.Drawing.Color.White;
            this.btnShowFrequency.Location = new System.Drawing.Point(10, 155);
            this.btnShowFrequency.Name = "btnShowFrequency";
            this.btnShowFrequency.Size = new System.Drawing.Size(140, 28);
            this.btnShowFrequency.TabIndex = 1;
            this.btnShowFrequency.Text = "Show Word Frequency";
            this.btnShowFrequency.UseVisualStyleBackColor = false;
            this.btnShowFrequency.Click += new System.EventHandler(this.btnShowFrequency_Click);

            // gboxAdditionalFeatures
            this.gboxAdditionalFeatures.Controls.Add(this.btnRemoveStopWords);
            this.gboxAdditionalFeatures.Controls.Add(this.btnToggleDarkMode);
            this.gboxAdditionalFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gboxAdditionalFeatures.Location = new System.Drawing.Point(480, 430);
            this.gboxAdditionalFeatures.Name = "gboxAdditionalFeatures";
            this.gboxAdditionalFeatures.Size = new System.Drawing.Size(400, 110);
            this.gboxAdditionalFeatures.TabIndex = 9;
            this.gboxAdditionalFeatures.TabStop = false;
            this.gboxAdditionalFeatures.Text = "Additional Features";

            // btnRemoveStopWords
            this.btnRemoveStopWords.BackColor = System.Drawing.Color.Purple;
            this.btnRemoveStopWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveStopWords.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStopWords.Location = new System.Drawing.Point(10, 30);
            this.btnRemoveStopWords.Name = "btnRemoveStopWords";
            this.btnRemoveStopWords.Size = new System.Drawing.Size(150, 30);
            this.btnRemoveStopWords.TabIndex = 0;
            this.btnRemoveStopWords.Text = "Remove Stop Words";
            this.btnRemoveStopWords.UseVisualStyleBackColor = false;
            this.btnRemoveStopWords.Click += new System.EventHandler(this.btnRemoveStopWords_Click);

            // btnToggleDarkMode
            this.btnToggleDarkMode.BackColor = System.Drawing.Color.Teal;
            this.btnToggleDarkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnToggleDarkMode.ForeColor = System.Drawing.Color.White;
            this.btnToggleDarkMode.Location = new System.Drawing.Point(230, 30);
            this.btnToggleDarkMode.Name = "btnToggleDarkMode";
            this.btnToggleDarkMode.Size = new System.Drawing.Size(150, 30);
            this.btnToggleDarkMode.TabIndex = 1;
            this.btnToggleDarkMode.Text = "Dark Mode";
            this.btnToggleDarkMode.UseVisualStyleBackColor = false;
            this.btnToggleDarkMode.Click += new System.EventHandler(this.btnToggleDarkMode_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInputPrompt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gboxAnalysisResults);
            this.Controls.Add(this.gboxSearch);
            this.Controls.Add(this.gboxWordFrequency);
            this.Controls.Add(this.gboxAdditionalFeatures);
            this.Name = "Form1";
            this.Text = "Text Analyzer - NLP";
            this.gboxAnalysisResults.ResumeLayout(false);
            this.gboxAnalysisResults.PerformLayout();
            this.gboxSearch.ResumeLayout(false);
            this.gboxSearch.PerformLayout();
            this.gboxWordFrequency.ResumeLayout(false);
            this.gboxAdditionalFeatures.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInputPrompt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gboxAnalysisResults;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Label lblCharCountResult;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblWordCountResult;
        private System.Windows.Forms.Label lblSentenceCount;
        private System.Windows.Forms.Label lblSentenceCountResult;
        private System.Windows.Forms.Label lblVowelCount;
        private System.Windows.Forms.Label lblVowelCountResult;
        private System.Windows.Forms.Label lblMostFrequentWord;
        private System.Windows.Forms.Label lblMostFrequentWordResult;
        private System.Windows.Forms.GroupBox gboxSearch;
        private System.Windows.Forms.Label lblSearchPrompt;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.GroupBox gboxWordFrequency;
        private System.Windows.Forms.ListBox lstWordFrequency;
        private System.Windows.Forms.Button btnShowFrequency;
        private System.Windows.Forms.GroupBox gboxAdditionalFeatures;
        private System.Windows.Forms.Button btnRemoveStopWords;
        private System.Windows.Forms.Button btnToggleDarkMode;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    }
}
