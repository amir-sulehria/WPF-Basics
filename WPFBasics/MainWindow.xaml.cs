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

namespace WPFBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: { this.descripText.Text}");
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            this.weldcb.IsChecked = this.assemblycb.IsChecked = this.plasmacb.IsChecked = this.lasercb.IsChecked = this.purchasecb.IsChecked = this.lathecb.IsChecked =
                this.drilcb.IsChecked = this.foldcb.IsChecked = this.rollcb.IsChecked = this.sawcb.IsChecked = false;
        }

        public void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.lengthText.Text += ((CheckBox)sender).Content;
        }

        private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            if (this.noteText == null)
                return;
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.noteText.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox_Selected(this.ComboBoxContent, null);
        }

        private void SupplierName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.massText.Text = this.supplierName.Text;
        }
    }
}
