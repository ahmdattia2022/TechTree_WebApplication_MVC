namespace TechTreeMVCWebApp.Entities
{
    //a join entity between user table and category
    public class UserCategory
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
