using LSC.OnlineCourse.Data;
using LSC.OnlineCourse.Data.Entities;
using LSC.OnlineCourse.Service;
using Microsoft.EntityFrameworkCore;

namespace LSC.OnlineCourse.API
{
    public class Program
    {
        public static void Main (string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var configuration = builder.Configuration;

            builder.Services.AddDbContextPool<OnlineCourseDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("DbContext"),
                    provideroptions => provideroptions.EnableRetryOnFailure());
                
                options.EnableSensitiveDataLogging();
            });


            // Add services to the container.
            builder.Services.AddControllers(); // Add MVC controllers
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            builder.Services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<ICourseService, CourseService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers(); // Map controller routes

            app.Run();
        }
    }
}
