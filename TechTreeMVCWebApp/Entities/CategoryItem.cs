using System;
using System.ComponentModel.DataAnnotations;

namespace TechTreeMVCWebApp.Entities
{
    public class CategoryItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeItemAdded { get; set; }
        public int CategoryId { get; set; }
        public int MediaTypeId { get; set; }

    }
}
