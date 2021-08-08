using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_FrameWork_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showdata();
        }

        TorosDTBEntities2 dtb = new TorosDTBEntities2();

        private void showdata()
        {
            dataGridView1.DataSource = dtb.ÖrnekKitapListesi.ToList();
        }

        private void adddata()
        {
            ÖrnekKitapListesi tbl = new ÖrnekKitapListesi();

            tbl.KitapAdı = txtboxad.Text;
            tbl.Yazar = txtboxyazar.Text;
            tbl.Yayınevi = txtboxyayınevi.Text;

            dtb.ÖrnekKitapListesi.Add(tbl);

            dtb.SaveChanges();

        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            adddata();
            showdata();
        }

        private void deletedata()
        {
            int id = Convert.ToInt32(txtboxindex.Text);
          

            ÖrnekKitapListesi tbl = dtb.ÖrnekKitapListesi.First(f => f.Sıra == id);

            dtb.ÖrnekKitapListesi.Remove(tbl);

            dtb.SaveChanges();
        }

        private void dataupdate()
        {
            int id2 = Convert.ToInt32(txtboxindex.Text);

            ÖrnekKitapListesi tbl = dtb.ÖrnekKitapListesi.First(f => f.Sıra == id2);

            tbl.KitapAdı = txtboxad.Text;
            tbl.Yayınevi = txtboxyayınevi.Text;
            tbl.Yazar = txtboxyazar.Text;

            dtb.SaveChanges();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            deletedata();

            showdata();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            dataupdate();
            showdata();
        }
    }
}
