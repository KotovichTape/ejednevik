using System;
using System.Collections;
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

namespace ejednevik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            dp.SelectedDate = DateTime.Now;
        }
        List<string> listok = new List<string>();
        List<string> istok = new List<string>() { };
        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(list.SelectedItem != null)
            {
                name.Text = list.SelectedItem.ToString();
                StringBuilder sb = new StringBuilder();
                foreach (string s in istok)
                {
                    sb.Append(s);
                    sb.Append(", ");
                }
                opis.Text = sb.ToString();
            }
            
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != "" && opis.Text != "")
            {
                list.Items.Add(name.Text);
                istok.Add(opis.Text);
            }
            else
            {
                MessageBox.Show("ничего нет");
            }
            opis.Text = "";
            name.Text = "";

        }
        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                list.Items.Remove(list.SelectedItem);
            }
        }
        private void change_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                int selectedIndex = list.SelectedIndex; // получаем индекс выбранного элемента
                list.Items[selectedIndex] = name.Text;
                list.Items.Refresh();
            }
        }
       

    }
}