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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<testtt> testdata = new List<testtt>();
            testdata.Add(new testtt("1", "2", "3"));
            test.ItemsSource = testdata;
            testdata.Add(new testtt("2", "2", "3"));
            test.ItemsSource = testdata;
      
            //btnTest.IsPressed
        }

        private void butt(object sender, EventArgs e)
        {

        }
     public class testtt
     {
         public testtt(string cc1,string cc2 ,string cc3)
         { 
             c1=cc1;
             c2=cc2;
             c3=cc3;
         }
         public string c1 { get; set; }
              public string c2{ get;set;}
              public string c3{ get;set;}
     }

     private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
     {

     }

     private void click(object sender, RoutedEventArgs e)
     {
         this.Close();

     }

     private void drag(object sender, DragEventArgs e)
     {
         this.DragMove();
     }

     private void butt(object sender, RoutedEventArgs e)
     {
         NavigationWindow window = new NavigationWindow();

         window.Source = new Uri("/pages/button.xaml", UriKind.Relative);

         window.Show();
     }

     private void Button_Click(object sender, RoutedEventArgs e)
     {

     }

     private void tool(object sender, RoutedEventArgs e)
     {
         NavigationWindow window = new NavigationWindow();

         window.Source = new Uri("/pages/tooltip.xaml", UriKind.Relative);

         window.Show();

     }

     private void page(object sender, RoutedEventArgs e)
     {
         NavigationWindow window = new NavigationWindow();

         window.Source = new Uri("/pages/PPage.xaml", UriKind.Relative);

         window.Show();

     }

     private void toolbar(object sender, RoutedEventArgs e)
     {
         NavigationWindow window = new NavigationWindow();

         window.Source = new Uri("/pages/toolbar.xaml", UriKind.Relative);

         window.Show();

     }
    }
}
