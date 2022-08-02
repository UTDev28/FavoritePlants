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

namespace FavoritePlants
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        //create dictionary to hold plant objects

        Dictionary<string, Plant> plantDict = new Dictionary<string, Plant>();

        Flower flower;
        Tree tree;
        Shrub shrub;
        public MainWindow()
        {
            InitializeComponent();

            LoadPlants();
        }

        private void RdBtnFlower_Checked(object sender, RoutedEventArgs e)
        {
            ImgPlant.Source = new BitmapImage(new Uri("flower.png", UriKind.Relative));
            flower = new Flower();
        }

        private void RdBtnTree_Checked(object sender, RoutedEventArgs e)
        {
            ImgPlant.Source = new BitmapImage(new Uri("tree.png", UriKind.Relative));
            //tree = new Tree();
        }

        private void RdBtnShrub_Checked(object sender, RoutedEventArgs e)
        {
            ImgPlant.Source = new BitmapImage(new Uri("shrub.png", UriKind.Relative));
            shrub = new Shrub();
        }

        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            string name = TxtBoxPlantName.Text;
            string enviroment = CmbBoxEnviroment.SelectedItem.ToString();
            if (name != "")
            {

                if (RdBtnFlower.IsChecked == true)
                {
                    flower.Name = name;
                    flower.Enviroment = enviroment;

                    PolymorphicAddition(flower);
                }
                //Check if the Tree radio button is checked
                else if (RdBtnTree.IsChecked == true)
                {
                    //Create a new tree object using the name and enviroment variables, and the values of 5 for the age parameter
                    // in the tree constructor
                    tree = new Tree(name, enviroment, 5);
                    PolymorphicAddition(tree);
                }
                else if (RdBtnShrub.IsChecked == true)
                {
                    PolymorphicAddition(shrub);
                }
                else
                {
                    MessageBox.Show("Select a plant type please.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid plant name");
            }
        } 

        private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
        {
            if(plantDict.TryGetValue(LstBoxPlants.SelectedItem.ToString(), out Plant plant))
            {
                //Check the plant dictionary to see if the selected item in the ListBox matches a plant. If it does
                // pass the matched plant into the DetailsWindow and display its details.
                DetailsWindow detailsWindow = new DetailsWindow(plant);
                //display the DetailsWindow
                detailsWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Something went wrong when showing the details.");
            }

        }

        private void PolymorphicAddition(Plant plant)
        {
            plantDict.Add(plant.Name, plant);
            LstBoxPlants.Items.Add(plant.Name);

           // try
            //{
               // plantDict.Add(plant.Name, plant);
               // LstBoxPlants.Items.Add(plant.Name);
           // }
           // catch
           // {
               // MessageBox.Show("Plant name already used");

          //  }

        }

        private void LoadPlants()
        {
            CmbBoxEnviroment.Items.Add("Forest");
            CmbBoxEnviroment.Items.Add("Desert");
            CmbBoxEnviroment.Items.Add("Jungle");

            //Creates a flower object using the default constructor method (no parameters)
            Flower defaultFlower = new Flower();

            //Add the default Flower to our plant dictionary and list box usig PolymorphicAddition() method
            PolymorphicAddition(defaultFlower);

            Flower paramFlower = new Flower("Rose", "Forest");
            PolymorphicAddition(paramFlower);

            Plant plantFlower = new Flower("Sunflower", "Forest");
            PolymorphicAddition(plantFlower);   

            CmbBoxEnviroment.SelectedIndex = 0;

        }

       
    }
    
}
