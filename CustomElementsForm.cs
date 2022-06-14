using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PILab10
{
    public partial class CustomElementsForm : Form
    {
        private readonly string _wordPattern = @"[A-Za-z]+|(#.*?#)|(\[.*?\])";

        public CustomElementsForm()
        {
            InitializeComponent();
            InitializeLetterStats();
        }

        private void InitializeLetterStats()
        {
            LetterStatsData.DataSource = LetterWithStats.Words;
            
            LetterStatsData.Columns.Add("Word", "Word");
            LetterStatsData.Columns.Add("Count", "Count");
        }

        private List<string> GetWordList() => Regex
              .Matches(LetterWithStats.Text, _wordPattern)
              .OfType<Match>()
              .Select(match => match.Value.ToLower())
              .ToList();

        private void CountWords(List<string> words)
        {
            foreach (string word in words)
            {
                if (LetterWithStats.Words.Count(p => p.Item1 == word) == 0)
                {
                    LetterWithStats.Words.Add(new ValueTuple<string, int>(word, 1));
                }
                else
                {
                    var index = LetterWithStats.Words.ToList().FindIndex(w => w.Item1 == word);
                    var found = LetterWithStats.Words[index];
                    LetterWithStats.Words[index] = new ValueTuple<string, int>(found.Item1, found.Item2 + 1);
                }
            }
        }

        private void UpdateLetterStats()
        {
            for (int i = 0; i < LetterWithStats.Words.Count; i++)
            {
                var cells = LetterStatsData.Rows[i].Cells;

                cells[0].Value = LetterWithStats.Words[i].Item1;
                cells[1].Value = LetterWithStats.Words[i].Item2;
            }
        }

        private void OnTextChanged(object sender, System.EventArgs e)
        {
            CountWords(GetWordList());
            UpdateLetterStats();
        }
    }
}
