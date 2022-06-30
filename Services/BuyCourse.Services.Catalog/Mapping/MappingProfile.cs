using AutoMapper;
using BuyCourse.Services.Catalog.Entities;
using BuyCourse.Services.Catalog.Models;
using BuyCourse.Services.Catalog.Models.Course;

namespace BuyCourse.Services.Catalog.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCourseModel, Course>();
            CreateMap<UpdateCourseModel, Course>();
            CreateMap<Course, CourseModel>();
            CreateMap<Category, CategoryModel>();
            CreateMap<Feature, FeatureModel>();
        }
    }
}
