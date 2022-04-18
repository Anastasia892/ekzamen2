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

namespace ekzamen2
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        List<Excel> Start = BaseClass.bd.Excel.ToList();
        List<Excel> Cart;
        public ListPage()
        {
            InitializeComponent();
            Listview.ItemsSource = Start;
        }

        private void But_Cart_Click(object sender, RoutedEventArgs e)
        {
                var List = Listview.SelectedItems;
                Num_book.Text = "Количество выбранных книг: " + List.Count;
                int books_summa = 0;
                foreach (Excel book in List)
                {
                books_summa += (int) book.Cost;
                }
                 Num_book.Text = "Стоимость покупки: " + books_summa;
            

        }

        private void But_Cart2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
