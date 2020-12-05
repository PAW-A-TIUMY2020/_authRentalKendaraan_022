using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_022.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
    
        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }
        [Required(ErrorMessage = "NIK customer tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        public string Alamat { get; set; }
        [Required(ErrorMessage = "No HP tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        [MinLength(10, ErrorMessage = "No HP minimal 10 digit")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 13 digit")]
        public string NoHp { get; set; }
        [Required(ErrorMessage = "Gender tidak boleh kosong")]
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }

        
    }
}
