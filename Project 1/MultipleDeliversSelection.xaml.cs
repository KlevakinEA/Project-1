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
    /// Логика взаимодействия для MultipleDeliversSelection.xaml
    /// </summary>
    public partial class MultipleDeliversSelection : Window
    {
        public static ObservableCollection<Mechanic> All { get; set; }
        public static ObservableCollection<Mechanic> Selected { get; set; }
        public MultipleDeliversSelection(ObservableCollection<Mechanic> mechanics, ObservableCollection<Mechanic> selectedMechanics)
        {
            All = mechanics;
            Selected = selectedMechanics;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Selected.Contains((Mechanic)AllList.SelectedItem)) Selected.Add((Mechanic)AllList.SelectedItem);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Selected.Remove((Mechanic)SelectedList.SelectedItem);
        }
    }
}
