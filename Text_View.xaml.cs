using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CookBook_Final
{
    /// <summary>
    /// Interaction logic for Text_View.xaml
    /// </summary>
    public partial class Text_View : Window
    {
        string document = FoodList.doc;
        public Text_View()
        {
            InitializeComponent();

            Paragraph paragraph = new Paragraph();
            paragraph.Inlines.Add(File.ReadAllText(Environment.CurrentDirectory + document));

            FlowDocument doc = new FlowDocument(paragraph);
            FlowDocReader.Document = doc;
        }

        private void Download_Click(object sender, RoutedEventArgs e)
        {
            string fileName = document;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                fileName = saveFileDialog.FileName;
            }
            FileStream xamlFile = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            XamlWriter.Save(FlowDocReader.Document, xamlFile);
            xamlFile.Close();
        }
    }
}
