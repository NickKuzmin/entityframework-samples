using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCore.Samples.Entities
{
    [Table("articlefirsttypetable")]
    public class ArticleFirstTypeTable : ArticleCommonTable
    {
        [Column("articlefirsttypeproperty")]
        public string ArticleFirstTypeProperty { get; set; }
    }
}
