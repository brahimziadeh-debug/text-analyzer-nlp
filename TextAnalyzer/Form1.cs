using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TextAnalyzer
{
    /// <summary>
    /// Main form for the Text Analyzer application.
    /// Provides NLP analysis capabilities for user-entered text.
    /// </summary>
    public partial class Form1 : Form
    {
        private bool isDarkMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Analyze Text button click event.
        /// Performs all NLP analysis and displays results.
        /// </summary>
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;

            // Validate input
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Please enter some text to analyze.", "No Text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Perform NLP analysis
                int charCount = NLPAnalyzer.GetCharacterCount(inputText);
                int wordCount = NLPAnalyzer.GetWordCount(inputText);
                int sentenceCount = NLPAnalyzer.GetSentenceCount(inputText);
                int vowelCount = NLPAnalyzer.GetVowelCount(inputText);
                string mostFrequentWord = NLPAnalyzer.GetMostFrequentWord(inputText);

                // Display results
                lblCharCountResult.Text = charCount.ToString();
                lblWordCountResult.Text = wordCount.ToString();
                lblSentenceCountResult.Text = sentenceCount.ToString();
                lblVowelCountResult.Text = vowelCount.ToString();
                lblMostFrequentWordResult.Text = mostFrequentWord;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Clear button click event.
        /// Clears all text and resets results.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        /// <summary>
        /// Clears all text and result fields.
        /// </summary>
        private void ClearAll()
        {
            txtInput.Clear();
            txtSearch.Clear();
            lblCharCountResult.Text = "0";
            lblWordCountResult.Text = "0";
            lblSentenceCountResult.Text = "0";
            lblVowelCountResult.Text = "0";
            lblMostFrequentWordResult.Text = "";
            lblSearchResult.Text = "";
            lstWordFrequency.Items.Clear();
            txtInput.Focus();
        }

        /// <summary>
        /// Handles the Search button click event.
        /// Searches for the entered word in the text.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtSearch.Text.Trim();
            string inputText = txtInput.Text;

            if (string.IsNullOrEmpty(searchWord))
            {
                MessageBox.Show("Please enter a word to search.", "No Search Term", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Please enter some text first.", "No Text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int count = NLPAnalyzer.SearchWord(inputText, searchWord);
                lblSearchResult.Text = $"'{searchWord}' found {count} time(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Show Word Frequency button click event.
        /// Displays a list of all words and their frequencies.
        /// </summary>
        private void btnShowFrequency_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Please enter some text first.", "No Text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Dictionary<string, int> frequency = NLPAnalyzer.GetWordFrequency(inputText);
                lstWordFrequency.Items.Clear();

                foreach (var kvp in frequency)
                {
                    lstWordFrequency.Items.Add($"{kvp.Key}: {kvp.Value}");
                }

                if (lstWordFrequency.Items.Count == 0)
                    MessageBox.Show("No words found to analyze.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Remove Stop Words button click event.
        /// Removes common stop words and displays the result.
        /// </summary>
        private void btnRemoveStopWords_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Please enter some text first.", "No Text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string filtered = NLPAnalyzer.RemoveStopWords(inputText);
                MessageBox.Show($"Text without stop words:\n\n{filtered}", "Filtered Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Dark Mode toggle button click event.
        /// Switches between dark and light themes.
        /// </summary>
        private void btnToggleDarkMode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            ApplyTheme();
        }

        /// <summary>
        /// Applies the current theme to the form.
        /// </summary>
        private void ApplyTheme()
        {
            if (isDarkMode)
            {
                this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
                this.ForeColor = System.Drawing.Color.White;
                ApplyDarkModeToControl(this);
                btnToggleDarkMode.Text = "Light Mode";
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.Control;
                this.ForeColor = System.Drawing.SystemColors.ControlText;
                ApplyLightModeToControl(this);
                btnToggleDarkMode.Text = "Dark Mode";
            }
        }

        /// <summary>
        /// Recursively applies dark mode to all controls.
        /// </summary>
        private void ApplyDarkModeToControl(Control control)
        {
            if (control is TextBox)
            {
                control.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
                control.ForeColor = System.Drawing.Color.White;
            }
            else if (control is Label)
            {
                control.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
                control.ForeColor = System.Drawing.Color.White;
            }
            else if (!(control is Button))
            {
                control.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
                control.ForeColor = System.Drawing.Color.White;
            }

            foreach (Control child in control.Controls)
            {
                ApplyDarkModeToControl(child);
            }
        }

        /// <summary>
        /// Recursively applies light mode to all controls.
        /// </summary>
        private void ApplyLightModeToControl(Control control)
        {
            if (control is TextBox)
            {
                control.BackColor = System.Drawing.Color.White;
                control.ForeColor = System.Drawing.Color.Black;
            }
            else if (control is Label)
            {
                control.BackColor = System.Drawing.SystemColors.Control;
                control.ForeColor = System.Drawing.SystemColors.ControlText;
            }
            else if (!(control is Button))
            {
                control.BackColor = System.Drawing.SystemColors.Control;
                control.ForeColor = System.Drawing.SystemColors.ControlText;
            }

            foreach (Control child in control.Controls)
            {
                ApplyLightModeToControl(child);
            }
        }

        /// <summary>
        /// Handles the Save Results menu item click event.
        /// Saves analysis results to a text file.
        /// </summary>
        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "analysis_results.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string results = GenerateResultsText();
                    File.WriteAllText(saveFileDialog.FileName, results);
                    MessageBox.Show("Results saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the Open File menu item click event.
        /// Opens and loads text from a file.
        /// </summary>
        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    txtInput.Text = fileContent;
                    MessageBox.Show("File loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Generates a formatted text string of the analysis results.
        /// </summary>
        /// <returns>Formatted results text</returns>
        private string GenerateResultsText()
        {
            return $"TEXT ANALYZER - ANALYSIS RESULTS\n" +
                   $"================================\n\n" +
                   $"ORIGINAL TEXT:\n{txtInput.Text}\n\n" +
                   $"ANALYSIS RESULTS:\n" +
                   $"Character Count: {lblCharCountResult.Text}\n" +
                   $"Word Count: {lblWordCountResult.Text}\n" +
                   $"Sentence Count: {lblSentenceCountResult.Text}\n" +
                   $"Vowel Count: {lblVowelCountResult.Text}\n" +
                   $"Most Frequent Word: {lblMostFrequentWordResult.Text}\n\n" +
                   $"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
        }
    }
}
