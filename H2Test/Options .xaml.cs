using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace H2Test
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        private static readonly Regex _regex = new Regex("[^0-9.-]+");

        public Options(Boolean deleteListOnClick, int listCount)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Check if text is nummeric
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        /// <summary>
        /// on closing hide insted
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// Hide options window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveNdClose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
           
        }

        /// <summary>
        /// Textbox if inut not number messagebox error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextNummeric_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsTextAllowed(TextNummeric.Text) == false)
            {
                TextNummeric.Clear();
                MessageBox.Show("Only Numbers");
            }
        }

    }
}
