using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Threading;


namespace MyOODProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Shirts> allShirts = new List<Shirts>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            
            

            
            MyDataBase DB = new MyDataBase();

            var query = from s in DB.Shirts
                        select s.Name;

            var results = query.ToList();

            lbxShirts.ItemsSource = results;


            //populate combobox
            // string[] county = { "All", "Connachta", "Munster", "Leinster" };
            // cbxCounties.ItemsSource = county;        

            //Display Exact Date
            DateTime dateTime = DateTime.Today;
            TbDate.Text = TbDate.Text + dateTime.ToShortDateString();
        
            //Create Shirts
            //Connachta s1 = new Connachta() { ShirtNames = "Sligo", Info = "Show your support and cheer on the Yeats county with the Sligo GAA Hurling Home Jersey. The jersey features a majestic watermark image of the Benbulben mountain on the front with the words “Land of Hearts Desire” on the lower back. Crafted from our high-performance Koolite fabric, this jersey utilises catch, move and release nano-technology to transport moisture away from the skin." };
            //Connachta s2 = new Connachta() { ShirtNames = "Mayo" };
            //Connachta s3 = new Connachta() { ShirtNames = "Galway" };
            //Connachta s4 = new Connachta() { ShirtNames = "Roscommon" };
            //Connachta s5 = new Connachta() { ShirtNames = "Lietrim" };

            //Leinster l1 = new Leinster() { ShirtNames = "Carlow" };
            //Leinster l2 = new Leinster() { ShirtNames = "Dublin" };
            //Leinster l3 = new Leinster() { ShirtNames = "Kilkenny" };
            //Leinster l4 = new Leinster() { ShirtNames = "Kildare" };
            //Leinster l5 = new Leinster() { ShirtNames = "Laois" };
            //Leinster l6 = new Leinster() { ShirtNames = "LongFord" };
            //Leinster l7 = new Leinster() { ShirtNames = "Louth" };

            //Munster m1 = new Munster() { ShirtNames = "Clare" };
            //Munster m2 = new Munster() { ShirtNames = "Cork" };
            //Munster m3 = new Munster() { ShirtNames = "Kerry" };
            //Munster m4 = new Munster() { ShirtNames = "Limerick" };
            //Munster m5 = new Munster() { ShirtNames = "Tipperary" };
            //Munster m6 = new Munster() { ShirtNames = "Waterford" };

            //Desc d1 = new Desc( "Sligo","uuvg", 2024);
            //Desc d2 = new Desc("Sligo", "uuvg", 2024);
            //Desc d3 = new Desc("Sligo", "uuvg", 2024);
            //Desc d4 = new Desc("Sligo", "uuvg", 2024);
            //Desc d5 = new Desc("Sligo", "uuvg", 2024);
            //Desc d6 = new Desc("Sligo", "uuvg", 2024);
            //Desc d7 = new Desc("Sligo", "uuvg", 2024);
            //Desc d8 = new Desc("Sligo", "uuvg", 2024);

            //Add Decription
           



            //Add to collection
            //Connachta
            //allShirts.Add(s1);
            //allShirts.Add(s2);
            //allShirts.Add(s3);
            //allShirts.Add(s4);
            //allShirts.Add(s5);

            ////Leinster
            //allShirts.Add(l1);
            //allShirts.Add(l2);
            //allShirts.Add(l3);
            //allShirts.Add(l4);
            //allShirts.Add(l5);
            //allShirts.Add(l6);
            //allShirts.Add(l7);

            ////Munster
            //allShirts.Add(m1);
            //allShirts.Add(m2);
            //allShirts.Add(m3);
            //allShirts.Add(m4);
            //allShirts.Add(m5);
            //allShirts.Add(m6);

            //Sort Shirts
            //allShirts.Sort();

            //Display
            //lbxShirts.ItemsSource = allShirts;
        }

        private void cbxCounties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what is selected in combobox
            string selectedCountries = cbxCounties.SelectedItem as string;

            //setup a filtered list
            List<Shirts> filteredList = new List<Shirts>();
        }
        //if/else - switch
        //    switch(selectedCountries)
        //    {
        //        case "All":
        //            lbxShirts.ItemsSource = allShirts;
        //            break;

        //        case "Connachta":

        //            foreach(Shirts shirt in allShirts)
        //            {
        //                if(shirt is Connachta)
        //                    filteredList.Add(shirt);
        //            }
        //            lbxShirts.ItemsSource = filteredList;
        //            break;

        //        case "Munster":

        //            foreach (Shirts shirt in allShirts)
        //            {
        //                if (shirt is Munster)
        //                    filteredList.Add(shirt);
        //            }
        //            lbxShirts.ItemsSource = filteredList;
        //            break;

        //        case "Leinster":

        //            foreach (Shirts shirt in allShirts)
        //            {
        //                if (shirt is Leinster)
        //                    filteredList.Add(shirt);
        //            }
        //            lbxShirts.ItemsSource = filteredList;
        //            break;
        //    }

        //    //update display
        //}

        private void lbxShirts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Shirts selectedShirts = lbxShirts.SelectedItem as Shirts;

            if (selectedShirts != null)
            {
                //lbxPrice.ItemsSource = selectedShirts.Descript;

                tblkDesc.Text = string.Format($"About {selectedShirts.Name}'s Jersey: " +
                    $"\n{selectedShirts.Info}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 secondWindow = new Window1();
            secondWindow.Show();
        }


    }

    

}
