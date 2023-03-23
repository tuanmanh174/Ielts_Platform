using BusinessAccess.Exam;
using BusinessAccess.ExamTest;
using BusinessAccess.Part;
using BusinessAccess.QuestionTest;
using BusinessAccess.School;
using BusinessAccess.System.User;
using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
namespace Ielts_Platform
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<IeltsDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("IeltsDatabase")));
            services.AddControllers();
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<IeltsDbContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IExamService, ExamService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISchoolService, SchoolService>();
            services.AddTransient<IQuestionTestService, QuestionTestService>();
            services.AddTransient<IExamTestService, ExamTestService>();
            services.AddTransient<IPartService, PartService>();
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Ielts", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Ielts V1");
                }
            );
        }
    }
}
