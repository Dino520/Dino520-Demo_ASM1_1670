using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Data
{
    [Table("Books")]
    public class Books
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
