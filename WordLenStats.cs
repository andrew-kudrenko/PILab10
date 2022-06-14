using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PILab10
{
    using WordStats = BindingList<ValueTuple<string, int>>;

    public partial class WordLenStats : TextBox
    {
        public WordStats Words { get; private set; } = new WordStats();
    }
}
