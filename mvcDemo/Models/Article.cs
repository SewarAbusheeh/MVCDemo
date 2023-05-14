namespace mvcDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        public int ArticleId { get; set; }

        public string Title { get; set; }

        public string ArticleImg { get; set; }

        public string Desc { get; set; }

        public string UserName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }
    }
}
