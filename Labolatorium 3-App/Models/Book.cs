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
        public string? Title { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "Proszę wprowadzić liczbę większą lub równą 1.")]
        [Display(Name = "Liczba stron")]
        public string Page_No { get; set; }


        [Range(1, int.MaxValue, ErrorMessage = "Proszę wprowadzić liczbę większą lub równą 1.")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; }


        [Required(ErrorMessage = "Musisz podać datę publikacji!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data publikacji")]
        public DateTime PublicationDate { get; set; }


        [Required(ErrorMessage = "Musisz podać nazwę wydawnictwa!")]
        [Display(Name = "Nazwa wydawnictwa")]
        public string? PublishingHouse { get; set; }

        [Display(Name = "Status dostępności")]
        public BookStatus BookStatus { get; set; }
        public DateTime Created { get; set; }
    }
}
