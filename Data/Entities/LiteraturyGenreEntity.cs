using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("generes")]
    public class LiteraturyGenreEntity
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public ISet<BookEntity> Books { get; set; }
    }
}
