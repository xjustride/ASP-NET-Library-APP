using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_3_App.Models
{
    public class Book
    {
        [HiddenInput]
        public int id { get; set; }
        [Required(ErrorMessage = "Musisz podać tytuł!")]
        [Display(Name = "Tytuł")]
        public string? title { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "Proszę wprowadzić liczbę większą lub równą 1.")]
        [Display(Name = "Liczba stron")]
        public int page_no { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "Proszę wprowadzić liczbę większą lub równą 1.")]
        [Display(Name = "ISBN")]
        public int isbn { get; set; }


        [Required(ErrorMessage = "Musisz podać datę publikacji!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data publikacji")]
        public DateTime publicationdate { get; set; }


        [Required(ErrorMessage = "Musisz podać nazwę wydawnictwa!")]
        [Display(Name = "Nazwa wydawnictwa")]
        public string? publishinghouse { get; set; }

        [Display(Name = "Status dostępności")]
        public BookStatus BookStatus { get; set; }
        public DateTime Created { get; set; }
    }
}
