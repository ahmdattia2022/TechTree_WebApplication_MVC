using System.ComponentModel.DataAnnotations;
using TechTreeMVCWebApp.Entities;

namespace TechTreeMVCWebApp.Data
{
    public class Content
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string HTMLContent { get; set; }
        public string VideoLink { get; set; }
        public CategoryItem CategoryItem { get; set; }//for a 1:1 relationship between content and categoryItem tables

    }
}
