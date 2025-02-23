using Project_1.Context;
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
using System.Windows.Shapes;

namespace Project_1
{
    /// <summary>
    /// Логика взаимодействия для MechanicRedaction.xaml
    /// </summary>
    public partial class MechanicRedaction : Window
    {
        public static Mechanic Mechanic { get; set; }
        public MechanicRedaction(Mechanic Mechanic)
        {
            MechanicRedaction.Mechanic = Mechanic;
            InitializeComponent();
        }
    }
}
