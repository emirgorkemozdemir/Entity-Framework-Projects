using BusniessLogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DENEME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentManager studentManager = new StudentManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            dg1.DataSource = studentManager.ListAll().ToList();
        }
    }
}
