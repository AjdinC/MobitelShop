using RS1_P120_MobitelShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace RS1_P120_MobitelShop.Areas.ModulAdministracija.Models
{
    public class KlijentiEditVM
    {
        public int Id { get; set; }
        public Klijent Klijent { get; set; }
        [StringLength(20, MinimumLength = 50, ErrorMessage = "Minimalna dužina 20 karaktera, a maksimalna 50")]
        public string Ime { get; set; }
        [StringLength(20, MinimumLength = 50, ErrorMessage = "Minimalna dužina 20 karaktera, a maksimalna 50")]
        public string Prezime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MMM/yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime DatumRodjenja { get; set; }
        [StringLength(30, MinimumLength = 50, ErrorMessage = "Minimalna dužina 20 karaktera, a maksimalna 50")]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Broj telefona")]
        [Required(ErrorMessage = "Broj telefona obavezan!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Nije validan format broja teleona")]
        public string Telefon { get; set; }
        [StringLength(30, MinimumLength = 50, ErrorMessage = "Minimalna dužina 20 karaktera, a maksimalna 50")]
        public string Adresa { get; set; }
        [StringLength(30, MinimumLength = 50, ErrorMessage = "Minimalna dužina 20 karaktera, a maksimalna 50")]
        public string KorisnickoIme { get; set; }
        public List<SelectListItem> gradovi { get; set; }
        [StringLength(30, MinimumLength = 50, ErrorMessage = "Minimalna dužina 20 karaktera, a maksimalna 50")]
        public string GradNaziv { get; set; }
        public int GradId { get; set; }
        public int LoginId { get; set; }
        public int KlijentId { get; set; }
        public bool isBanned { get; set; }
    }
}