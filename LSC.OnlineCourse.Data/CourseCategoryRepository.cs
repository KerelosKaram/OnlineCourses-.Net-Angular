using LSC.OnlineCourse.Core.Entities;
using LSC.OnlineCourse.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LSC.OnlineCourse.Data
{
    // public class CourseCategoryRepository(OnlineCourseDbContext dbContext) : ICourseCategoryRepository
    // {
    //     private readonly OnlineCourseDbContext dbContext = dbContext;

    //     public CourseCategory? GetById(int id)
    //     {
    //         var data = dbContext.CourseCategories.Find(id);
    //         return data;
    //     }

    //     public List<CourseCategory> GetCourseCategories()
    //     {
    //         var data = dbContext.CourseCategories.ToList();
    //         return data;
    //     }
    // }

    public class CourseCategoryRepository : ICourseCategoryRepository
    {
        private readonly OnlineCourseDbContext dbContext;
        public CourseCategoryRepository(OnlineCourseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<CourseCategory?> GetByIdAsync(int id)
        {
            var data = dbContext.CourseCategories.FindAsync(id).AsTask();
            return data;
        }

        public Task<List<CourseCategory>> GetCourseCategoriesAsync()
        {
            var data = dbContext.CourseCategories.ToListAsync();
            return data;
        }
    }
}