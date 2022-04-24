using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Samples.Entities
{
    [Table("articlesecondtypetable")]
    public class ArticleSecondTypeTable : ArticleCommonTable
    {
        [Column("articlesecondtypeproperty")]
        public string ArticleSecondTypeProperty { get; set; }
    }
}
