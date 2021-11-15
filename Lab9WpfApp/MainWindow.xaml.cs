using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab8WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Uri uri = new Uri("White.xaml", UriKind.Relative);
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
            MenuItemDark.IsChecked = false;
            MenuItemWhite.IsChecked = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as string);
            if (textBox != null)
                textBox.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as string);
            double size = Convert.ToDouble(fontName);
            if (textBox != null)
            {
                textBox.FontSize = size;
            }
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Текстовый файл (*.txt)|*.txt*|Все файлы (*.*)|*.*";
            if (Open.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(Open.FileName);
            }
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            Save.Filter = "Текстовый файл (*.txt)|*.txt*|Все файлы (*.*)|*.*";
            if (Save.ShowDialog() == true)
            {
                File.WriteAllText(Save.FileName, textBox.Text);
            }
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BondExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
            {
                textBox.FontWeight = FontWeights.Bold;
                BondMenu.IsChecked = true;

            }
            else
            {
                textBox.FontWeight = FontWeights.Normal;
                BondMenu.IsChecked = false;
            }
        }

        private void ItalicExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
            {
                textBox.FontStyle = FontStyles.Italic;
                ItalicMenu.IsChecked = true;
            }
            else
            {
                textBox.FontStyle = FontStyles.Normal;
                ItalicMenu.IsChecked = false;
            }
        }

        private void UnderlineExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox.TextDecorations == null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
                UnderlineMenu.IsChecked = true;
            }
            else
            {
                textBox.TextDecorations = null;
                UnderlineMenu.IsChecked = false;
            }
        }

        private void BlackExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Black;
            if (textBox.Foreground == Brushes.Black)
            {
                BlackRadioButton.IsChecked = true;
            }
        }

        private void RedExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;
            if (textBox.Foreground == Brushes.Red)
            {
                RedRadioButton.IsChecked = true;
            }
        }

        private void Window_StylusMove(object sender, StylusEventArgs e)
        {

        }

        private void MenuItemDark_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Dark.xaml", UriKind.Relative);
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
            MenuItemDark.IsChecked = true;
            MenuItemWhite.IsChecked = false;
        }

        private void MenuItemWhite_Click(object sender, RoutedEventArgs e)
        {
            {
                Uri uri = new Uri("White.xaml", UriKind.Relative);
                ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resource);
                MenuItemDark.IsChecked = false;
                MenuItemWhite.IsChecked = true;
            }
        }
    }
}