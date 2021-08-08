using System;
using System.Collections.Generic;
using System.Data;
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
using BusniessLogicLayer.Concrete;
using EntityLayer.Concrete;

namespace Wpf_Entity_Framework_example
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        StudentManager studentManager = new StudentManager();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
           datagrid.ItemsSource=  studentManager.ListAll();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            this.Hide();
            addStudent.Show();
            
        }

        ÖğrenciTablosu selectedStudent =new ÖğrenciTablosu();

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         

            try
            {
            
                var row = (ÖğrenciTablosu)datagrid.Items[datagrid.SelectedIndex]; ;

                ÖğrenciTablosu tempStudent = row;

                selectedStudent.OgrID = tempStudent.OgrID;
                selectedStudent.OgrAd = tempStudent.OgrAd;
                selectedStudent.OgrMail = tempStudent.OgrMail;
                selectedStudent.OgrOkulNo = tempStudent.OgrOkulNo;
                selectedStudent.OgrSifre = tempStudent.OgrSifre;
                selectedStudent.OgrSoyad = tempStudent.OgrSoyad;

                tboxName.Text = tempStudent.OgrAd;

                tboxMail.Text = tempStudent.OgrMail;

                tboxPassword.Password = tempStudent.OgrSifre;

                tboxSchoolNo.Text = tempStudent.OgrOkulNo;

                tboxSurname.Text = tempStudent.OgrSoyad;

            }
            catch 
            {
                selectedStudent.OgrID = -1;
                return;
               
            }
               
          
              

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (selectedStudent.OgrID==-1)
            {
                MessageBox.Show("Boş kısma tıkladınız lütfen öğrenci seçiniz");
                return;
            }
            studentManager.Delete(selectedStudent);
            
            datagrid.ItemsSource = studentManager.ListAll();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (selectedStudent.OgrID == -1)
            {
                MessageBox.Show("Boş kısma tıkladınız lütfen öğrenci seçiniz");
                return;
            }
            ÖğrenciTablosu editingStudent = new ÖğrenciTablosu();
            editingStudent.OgrID = selectedStudent.OgrID;

            editingStudent.OgrAd = tboxName.Text;
            editingStudent.OgrMail = tboxMail.Text;
            editingStudent.OgrOkulNo = tboxSchoolNo.Text;
            editingStudent.OgrSifre = tboxPassword.Password;
            editingStudent.OgrSoyad = tboxSurname.Text;

            studentManager.Update(editingStudent);
            datagrid.ItemsSource = studentManager.ListAll();
        }
    }
}
