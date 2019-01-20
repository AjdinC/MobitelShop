﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS1_P120_MobitelShop.Areas.ModulAdministracija.Models
{
    public class NarudzbePrikaziVM
    {
        public class NarudzbeInfo
        {
            public int Id { get; set; }
            public int BrojNarudzbe { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0: dd/MMM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
            public DateTime DatumNarudzbe { get; set; }
            public string statusNarudzbe { get; set; }
            public bool Otkazano { get; set; }
            public List<SelectListItem> isporuke { get; set; }
            public int IsporukaId { get; set; }
            public List<SelectListItem> klijenti { get; set; }
            public int KlijentId { get; set; }
            public string isporukaVrsta { get; set; }
            public string klijentIme { get; set; }
            public double? Ukupno { get; set; }
        }
        public List<NarudzbeInfo> narudzbeStavke { get; set; }
     
        public class DetaljiNarudzbePrikaziVM
        {
            public class DetaljiInfo
            {
                public int Id { get; set; }
                public int Kolicina { get; set; }
                public int ArtikalId { get; set; }
                public string artikalNaziv { get; set; }
                public double? Ukupno { get; set; }
                public double? CijenaArtikla { get; set; }
                public int NarudzbaId { get; set; }

                public double? CijenaSaPopustom { get; set; }

            }
            public List<DetaljiInfo> detaljiStavke { get; set; }
            public int NarudzbaId { get; set; }
        }
    }
}