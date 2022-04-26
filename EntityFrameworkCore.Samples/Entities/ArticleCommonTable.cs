using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCore.Samples.Entities
{
    [Table("articlecommontable", Schema = "dbo")]
    public abstract class ArticleCommonTable
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("articletitle")]
        public string ArticleTitle { get; set; }

        [Column("type")]
        public string Type { get; set; }
    }
}
