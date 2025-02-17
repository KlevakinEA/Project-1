using Project_1.Context;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Project_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Request> ShowingRequests { get; set; } = new ObservableCollection<Request>();
        public MainWindow()
        {
            InitializeComponent();
            ShowingRequests.Add(new Request("1", DateTime.Now, 10, 10, 100, 10, "Name Name Name", "88005553535", Context.Status.InStorage));
            ShowingRequests.Add(new Request("2", DateTime.Now, 10, 10, 100, 10, "Name Name Name", "88005553535", Context.Status.InStorage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Request current = new Request("3", DateTime.Now, 1, 1, 10, 1, "Name MiddleName LastName", "88005553535", Context.Status.InStorage);
            ShowingRequests.Add(current);
            AdditionAndRedactionOfRequests aaror = new AdditionAndRedactionOfRequests(current);
            aaror.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdditionAndRedactionOfRequests aaror = new AdditionAndRedactionOfRequests((Request)RequestsList.SelectedItem);
            aaror.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ShowingRequests.RemoveAt(RequestsList.SelectedIndex);
        }
    }
}
