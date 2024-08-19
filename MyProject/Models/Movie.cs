namespace MyProject.Models
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; } = 5;

        public int DistrictId { get; set; }
        public District District { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
