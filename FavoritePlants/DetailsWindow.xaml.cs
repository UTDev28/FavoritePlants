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

namespace FavoritePlants
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        Plant plant;
        public DetailsWindow(Plant paramPlant)
        {
            InitializeComponent();

            //Assign the passed in plant object to the plant variable we created up above
            plant = paramPlant;

            LblName.Content = plant.Name;
            LblEnviroment.Content = plant.Enviroment;
            LblType.Content = plant.GetType().Name;
            LblPick.Content = plant.Pick();
        }
        
        //Initiates the sniff button from the xaml file and will display the sniff message according to the selection 
        private void BtnSniff_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(plant.Sniff());
        }

        //Will close the window once the user selects the Close button
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }
    }
}
