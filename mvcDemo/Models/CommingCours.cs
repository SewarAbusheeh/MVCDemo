namespace mvcDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommingCourses")]
    public partial class CommingCours
    {
        [Key]
        public int CommingCourseId { get; set; }

        [Required]
        public string CName { get; set; }

        [Required]
        public string CourseDesc { get; set; }

        public string CourseImg { get; set; }

        public int Hours { get; set; }

        public decimal Price { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartDate { get; set; }

        public int CategoryId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public virtual Category Category { get; set; }
    }
}
