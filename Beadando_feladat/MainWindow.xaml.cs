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
using Beadando_feladat.Classes;

namespace Beadando_feladat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            Szamla sz = new Szamla();
            sz.name1 = "Beta";
            tulaj_nev1.Text = sz.name1.ToString();
            sz.egyenleg_1 = "5000";
            egyenleg1.Text = sz.egyenleg_1.ToString();

            sz.name2 = "Alfa";
            tulaj_nev2.Text = sz.name2.ToString();
            sz.egyenleg_2 = "5000";
            egyenleg2.Text = sz.egyenleg_2.ToString();
        }

        
        private void tulajnev1_Click(object sender, RoutedEventArgs e)
        {
            Szamla sz = new Szamla();
            sz.name1 = bevitel1.Text;

            tulaj_nev1.Text = sz.name1.ToString();
            bevitel1.Text = "";
        }

        private void tulajnev2_Click(object sender, RoutedEventArgs e)
        {
            Szamla sz = new Szamla();
            sz.name2 = bevitel2.Text;

            tulaj_nev2.Text = sz.name2.ToString();
            bevitel2.Text = "";
        }

        private void feltoltes1_Click(object sender, RoutedEventArgs e)
        {
            Szamla sz = new Szamla();

            if (egyenleg1.Text=="")
            {
                sz.money1 = bevitel1.Text;
                egyenleg1.Text = sz.money1.ToString();
                bevitel1.Text = "";
            }
            else
            {
                sz.money1 = egyenleg1.Text;
                int money_1 = int.Parse(sz.money1);
                int betesz = money_1 + int.Parse(bevitel1.Text);

                egyenleg1.Text = betesz.ToString();
                bevitel1.Text = "";
            }
            

        }

        private void feltoltes2_Click(object sender, RoutedEventArgs e)
        {
            Szamla sz = new Szamla();
            if (egyenleg2.Text == "")
            {
                sz.money2 = bevitel2.Text;
                egyenleg2.Text = sz.money2.ToString();
                bevitel2.Text = "";
            }
            else
            {
                sz.money2 = egyenleg2.Text;
                int money_2 = int.Parse(sz.money2);
                int betesz = money_2 + int.Parse(bevitel2.Text);

                egyenleg2.Text = betesz.ToString();
                bevitel2.Text = "";
            }
        }


        private void kivetel1_Click(object sender, RoutedEventArgs e)
        {
            Szamla sz = new Szamla();
            if (int.Parse(egyenleg1.Text) >= 0)
            {
                sz.money1 = egyenleg1.Text;
                int money_1 = int.Parse(sz.money1);
                int kivet_utan = money_1 - int.Parse(bevitel1.Text);

                egyenleg1.Text = kivet_utan.ToString();
                bevitel1.Text = "";
            }
            else if (int.Parse(egyenleg1.Text) < 0)
            {
                MessageBox.Show("A számla minuszba ment Őn sajnos tönkre ment! :(");
            }
           
        }

        private void kivetel2_Click(object sender, RoutedEventArgs e)
        {
            Szamla sz = new Szamla();
            if (int.Parse(egyenleg2.Text) >= 0)
            {
            sz.money2 = egyenleg2.Text;
            int money_2 = int.Parse(sz.money2);
            int kivet_utan = money_2 - int.Parse(bevitel2.Text);

            egyenleg2.Text = kivet_utan.ToString();
            bevitel2.Text = "";
            }
            else if (int.Parse(egyenleg2.Text) < 0)
            {
                MessageBox.Show("A számla minuszba ment Őn sajnos tönkre ment! :(");
            }
        }

        private void utalas1_Click(object sender, RoutedEventArgs e)
        {
            Szamla sz = new Szamla();
            sz.money1 = egyenleg1.Text;
            sz.money2 = egyenleg2.Text;
            int money_1 = int.Parse(sz.money1);
            int money_2 = int.Parse(sz.money2);
            int utalas1 = money_1 - int.Parse(bevitel1.Text);
            int utalas2 = money_2 + int.Parse(bevitel1.Text);

            egyenleg1.Text = utalas1.ToString();
            egyenleg2.Text = utalas2.ToString();
            bevitel1.Text = "";
        }

        private void utalas2_Click(object sender, RoutedEventArgs e)
        {

            Szamla sz = new Szamla();
            sz.money1 = egyenleg2.Text;
            sz.money2 = egyenleg1.Text;
            int money_1 = int.Parse(sz.money1);
            int money_2 = int.Parse(sz.money2);
            int utalas1 = money_1 - int.Parse(bevitel2.Text);
            int utalas2 = money_2 + int.Parse(bevitel2.Text);

            egyenleg2.Text = utalas1.ToString();
            egyenleg1.Text = utalas2.ToString();
            bevitel2.Text = "";
        }
    }
}
