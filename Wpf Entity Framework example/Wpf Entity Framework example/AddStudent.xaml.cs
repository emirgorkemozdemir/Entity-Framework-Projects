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
using BusniessLogicLayer.Concrete;
using EntityLayer.Concrete;
namespace Wpf_Entity_Framework_example
{
    /// <summary>
    /// AddStudent.xaml etkileşim mantığı
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentManager studentManager = new StudentManager();

            ÖğrenciTablosu student = new ÖğrenciTablosu();

            student.OgrAd = tboxName.Text;

            student.OgrSoyad = tboxSurname.Text;

            student.OgrMail = tboxMail.Text;

            student.OgrSifre = tboxPassword.Password;

            student.OgrOkulNo = tboxSchoolNo.Text;

            studentManager.Add(student);

            MessageBox.Show("Öğrenci başarıyla eklendi");
        }
    }
}
