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
    /// Логика взаимодействия для AdditionAndRedactionOfRequests.xaml
    /// </summary>
    public partial class AdditionAndRedactionOfRequests : Window
    {
        public static Request ShowingRequest { get; set; }
        public AdditionAndRedactionOfRequests(Request request)
        {
            ShowingRequest = request;
            InitializeComponent();
        }
        public static IEnumerable<Status> Statuses { get; set; } = Enum.GetValues(typeof(Status)).Cast<Status>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mechanic_selection s = new Mechanic_selection();
            s.ShowDialog();
            ShowingRequest.mechanicID = ((Mechanic)s.MechanicsList.SelectedItem).mechanicID;
        }
    }
}
