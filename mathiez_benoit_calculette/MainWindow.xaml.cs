using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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

namespace mathiez_benoit_calculette
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void Bouton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (afficheBox.Text.Contains("ERROR"))
                {
                    afficheBox.Text = "";
                }

                if(afficheBox.Text == "0")
                {
                    afficheBox.Text = "";
                }
            string btnContent = button.Content.ToString();
            afficheBox.Text += btnContent;

            }
        }





        private void btnSup_Click(object sender, RoutedEventArgs e)
        {
            
            afficheBox.Text = "0";

        }
        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
           

            if (afficheBox.Text != "")
            {


                try
                {
                    string operation = afficheBox.Text;
                    DataTable table = new DataTable();
                    table.Columns.Add("operation", typeof(string), operation);
                    DataRow row = table.NewRow();
                    table.Rows.Add(row);
                    afficheBox.Text = (string)row["operation"];
                }

                catch (Exception ex)
                {
                    afficheBox.Text = "ERROR";
                }
            }                      
        }

    

    

    }
}
