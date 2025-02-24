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
using System.Windows.Shapes;

namespace Project_1
{
    /// <summary>
    /// Логика взаимодействия для Statistics.xaml
    /// </summary>
    public partial class Statistics : Window
    {
        public static ObservableCollection<Request> requests { get; set; }
        public static ObservableCollection<Mechanic> mechanics { get; set; }
        public static DateTime StartFrom { get; set; } = DateTime.Now;
        public static DateTime Until { get; set; } = DateTime.Now;
        public static ObservableCollection<Mechanic> selectedMechanics { get; set; } = new ObservableCollection<Mechanic>();
        public static Dictionary<Context.Type, int> Types { get; set; } = new Dictionary<Context.Type, int>();
        public Statistics(ObservableCollection<Request> requests, ObservableCollection<Mechanic> mechanics)
        {
            Statistics.requests = requests;
            Statistics.mechanics = mechanics;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MultipleDeliversSelection multipleDeliversSelection = new MultipleDeliversSelection(mechanics, selectedMechanics);
            multipleDeliversSelection.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Request> req = new List<Request>();
            List<string> ids = new List<string>();
            foreach (Mechanic mechanic in selectedMechanics) ids.Add(mechanic.mechanicID);
            foreach (Request request in requests) if (request.date > StartFrom && request.date < Until && ids.Contains(request.mechanicID) && request.completionDate != null) req.Add(request);
            Completed.Text = req.Count().ToString();
            TimeSpan timeSpan = TimeSpan.FromSeconds(0);
            foreach (Request request in req) timeSpan += request.completionDate - request.date;
            AverageTime.Text = TimeSpan.FromMilliseconds(timeSpan.TotalMilliseconds / Convert.ToDouble(req.Count())).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Request> req = new List<Request>();
            List<string> ids = new List<string>();
            foreach (Mechanic mechanic in selectedMechanics) ids.Add(mechanic.mechanicID);
            foreach (Request request in requests) if (request.date > StartFrom && request.date < Until && ids.Contains(request.mechanicID) && request.completionDate != null) req.Add(request);
            Types.Clear();
            foreach (Request request in req) if (Types.ContainsKey(request.type)) Types[request.type]++; else Types.Add(request.type, 1);
            TypesList.Items.Refresh();
        }
    }
}
