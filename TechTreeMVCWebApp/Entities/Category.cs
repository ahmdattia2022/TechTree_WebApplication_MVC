using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTreeMVCWebApp.Entities
{
    public class Category
    {
        public int Id { get; set; }//EF will auto create this field as a primary key
        [Required]// will auto generate code to make sure that that title field is not empty
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; } //category title
        public string Description { get; set; }
        [Required]
        public string ThumbnailImagePath { get; set; }
        [ForeignKey("CategoryId")]
        public ICollection<CategoryItem> CategoryItems { get; set; }
        [ForeignKey("CategoryId")]
        public ICollection<UserCategory> UserCategory{ get; set; }

    }
}
