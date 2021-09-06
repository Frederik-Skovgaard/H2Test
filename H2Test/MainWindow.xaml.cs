using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using Microsoft.Win32;
using System.IO;
using System.Collections.ObjectModel;

namespace H2Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static bool _optionBool = true;
        private static int _optionInt = 0;

        Options options = new Options(_optionBool, _optionInt);

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        /// <summary>
        /// Add new item to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Name_Click(object sender, RoutedEventArgs e)
        {
            if (lstNames.Items.Count.ToString() == options.TextNummeric.Text)
            {
                MessageBox.Show("Too many name on list...");
                lstNames.Items.Clear();
                txtName.Clear();
            }
            else if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else
            {
                txtName.Clear();
            }
        }

        /// <summary>
        /// Delete selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lstNames.SelectedItem == null)
                {
                    MessageBox.Show("Please select af name to delete...");
                }
                else
                {
                    lstNames.Items.Remove(lstNames.SelectedItem);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }

        /// <summary>
        /// Clear textList on btn click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Clear();
        }

        /// <summary>
        /// Clear textList if click on list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstNames_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (options.CheckClear.IsChecked == true)
            {
                lstNames.Items.Clear();
            }
        }

        /// <summary>
        /// Show option window on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOption_Click(object sender, RoutedEventArgs e)
        {
            options.Show();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtTopic_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Title = txtTopic.Text;
        }

        /// <summary>
        /// Runs the add name method on key press enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Name_Click(sender, e);
            }
        }

        /// <summary>
        /// Save current boxlist to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveList_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == true)
            {
                List<string> list = new List<string>();
                foreach (string item in lstNames.Items)
                {
                    list.Add(item);
                }

                File.WriteAllLines(saveFile.FileName, list);
            }
        }

        /// <summary>
        /// Load file into ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadList_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                string[] vs = File.ReadAllLines(openFile.FileName);
                foreach (string item in vs)
                {
                    lstNames.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Press delete while having selected name to delete it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstNames_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                btnDelete_Click(sender, e);
            }
        }

        
    }
}
