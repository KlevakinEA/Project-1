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
    /// Логика взаимодействия для AdditionAndRedactionOfMechanics.xaml
    /// </summary>
    public partial class AdditionAndRedactionOfMechanics : Window
    {
        public static ObservableCollection<Mechanic> Mechanics { get; set; }
        public AdditionAndRedactionOfMechanics(ObservableCollection<Mechanic> Mechanics)
        {
            AdditionAndRedactionOfMechanics.Mechanics = Mechanics;
            InitializeComponent();
            if (Mechanics.Count() == 0) Button_Click(this, null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mechanics.Add(new Mechanic("0", "Example name", "+7(---)--- -- --", 0));
            MechanicsList.SelectedItem = Mechanics.Last();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mechanics.Remove((Mechanic)MechanicsList.SelectedItem);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MechanicRedaction n = new MechanicRedaction((Mechanic)MechanicsList.SelectedItem);
            n.ShowDialog();
        }
    }
}
