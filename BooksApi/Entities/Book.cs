using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksApi.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key] public Guid ID { get; set; }
        [Required] [MaxLength(150)] public string Title { get; set; }
        [Required] [MaxLength(2500)] public string Description { get; set; }
        public Guid AuthorID { get; set; }
        public Author Author { get; set; }
    }
}