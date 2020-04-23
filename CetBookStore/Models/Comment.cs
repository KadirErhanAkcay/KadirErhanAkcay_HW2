using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CetBookStore.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        public string Title { get; set; }


        [Display(Name = "Değerlendirme")]
        public int? Rating { get; set; }
        [Display(Name = "Oluşturulduğu Tarih")]
        public DateTime CreatedDate { get; set; }
        public int BookId { get; set; }
        [Display(Name = "Kitap")]
        public Book Book { get; set; }
        [Display(Name = "Ayrıntılar")]
        public String Detail { get; set; }




        public Comment()
        {
            CreatedDate = DateTime.Now;

        }
    }
}
