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

namespace Entity_FrameWork_WPF
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            showdata();
        }

        TorosDTBEntities dtb = new TorosDTBEntities();

        private void showdata()
        {
            dg1.ItemsSource = dtb.ÖrnekKitapListesi.ToList();
        }

        private void addata()
        {
            ÖrnekKitapListesi tbl = new ÖrnekKitapListesi();

            tbl.KitapAdı = txtboxad.Text;

            tbl.Yayınevi = txtboxyayınevi.Text;

            tbl.Yazar = txtboxyazar.Text;

            dtb.ÖrnekKitapListesi.Add(tbl);

            dtb.SaveChanges();
        }

        private void deletedata()
        {
            int id3 = Convert.ToInt32(txtboxid.Text);

            ÖrnekKitapListesi tbl = dtb.ÖrnekKitapListesi.First(f => f.Sıra == id3);

            dtb.ÖrnekKitapListesi.Remove(tbl);

            dtb.SaveChanges();
        }

        private void updatedata()
        {
            int id4 = Convert.ToInt32(txtboxid.Text);

            ÖrnekKitapListesi tbl = dtb.ÖrnekKitapListesi.First(f => f.Sıra == id4);

            tbl.KitapAdı = txtboxad.Text;

            tbl.Yayınevi = txtboxyayınevi.Text;

            tbl.Yazar = txtboxyazar.Text;

            dtb.SaveChanges();

        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            addata();
            showdata();
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            deletedata();
            showdata();
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            updatedata();
            showdata();
        }
    }
}
