using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksApi.Entities
{
    [Table("Authors")]
    public class Author
    {
        [Key] public Guid ID { get; set; }
        [Required] [MaxLength(150)] public string Firstname { get; set; }
        [Required] [MaxLength(150)] public string Lastname { get; set; }
    }
}