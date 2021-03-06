namespace BuyCourse.Services.Catalog.Models.Course
{
    public class UpdateCourseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public FeatureModel Feature { get; set; }
        public string CategoryId { get; set; }
    }
}
