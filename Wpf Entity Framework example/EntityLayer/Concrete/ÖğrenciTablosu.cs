using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class ÖğrenciTablosu:IDatabaseEntity
    {
        [Key]
        public int OgrID { get; set; }

        public string OgrAd { get; set; }

        public string  OgrSoyad { get; set; }

        public string OgrMail { get; set; }

        public string OgrSifre { get; set; }

        public int Bakiye { get; set; }

        public string OgrOkulNo { get; set; }
    }
}
