using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(512, MinimumLength = 3, ErrorMessage = "Kitap ismi alanına en az 3 karakter girilmelidir.")]
        [Required(ErrorMessage = "Kitap ismi alanı boş bırakılamaz.")]
        [Display(Name = "Kitap İsmi")]
        public string Title { get; set; } // nvarchar(512), not nullable
        [Display(Name = "Sayfa Sayısı")]
        [Required(ErrorMessage = "Sayfa sayısı alanı boş bırakılamaz.")]
        public int? PageCount { get; set; }
        [Display(Name = "Yazar İsmi")]
        [Required(ErrorMessage = "Yazar ismi alanı boş bırakılamaz.")]
        public string Authors { get; set; }
        [Display(Name = "Tanım")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Tanım alanına en az 3 karakter girilmelidir.")]
        public string Description { get; set; }
        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Fiyat alanı boş bırakılamaz, kitap ücretsize ise 0 yazmalısınız.")]
        public Decimal Price { get; set; }

        [Display(Name = "Basıldığı Yıl")]
        [Required(ErrorMessage = "Basıldığı Yıl alanı boş bırakılamaz.")]
        public int PressYear { get; set; }
       
        [Display(Name = "Stok")]
        [Required(ErrorMessage = "Stok alanı boş bırakılamaz.")]
        public int StockCount { get; set; }


        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]

        [Display(Name = "Kategori İsmi")]
        [Required(ErrorMessage = "Bir kategori seçmelisiniz, eğer yoksa önce kategori seçin.")]
        public Category Category { get; set; }
    
        [Display(Name = "Yorumlar")]
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            

        }

    }
}
