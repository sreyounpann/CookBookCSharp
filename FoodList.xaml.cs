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

namespace CookBook_Final
{
    /// <summary>
    /// Interaction logic for FoodList.xaml
    /// </summary>
    public partial class FoodList : Window
    {
        public static string doc;
        public FoodList()
        {
            InitializeComponent();
            DataContext = new DataContext();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Text_View text_View = new Text_View();
            text_View.Show();
        }

        private void KhmerFood_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var uie = KhmerFood.InputHitTest(Mouse.GetPosition(this.KhmerFood));

            if (uie == null)
                return;

            var listBoxItem = FindParent<ListBoxItem>((FrameworkElement)uie);

            if (listBoxItem == null)
                return;

            int index = this.KhmerFood.ItemContainerGenerator.IndexFromContainer(listBoxItem);

            Food element = (Food)KhmerFood.Items.GetItemAt(index);
            doc = element.Document;
        }
   
        private void KhmerDessert_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var uie = KhmerDessert.InputHitTest(Mouse.GetPosition(this.KhmerDessert));
            if (uie == null)
                return;

            var listBoxItem = FindParent<ListBoxItem>((FrameworkElement)uie);

            if (listBoxItem == null)
                return;
            int index = this.KhmerDessert.ItemContainerGenerator.IndexFromContainer(listBoxItem);
            Food element = (Food)KhmerDessert.Items.GetItemAt(index);
            doc = element.Document;


        }
        public static T FindParent<T>(FrameworkElement child) where T : DependencyObject
        {
            T parent = null;
            var currentParent = VisualTreeHelper.GetParent(child);

            while (currentParent != null)
            {
                if (currentParent is T)
                {
                    parent = (T)currentParent;
                    break;
                }
                currentParent = VisualTreeHelper.GetParent(currentParent);
            }
            return parent;
        }
    }
}
