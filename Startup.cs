using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Loader;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using MIS.Areas.Identity.Data;
using MIS.Data;
using Fp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
 
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace MIS
{
    public class Startup
    {
        private string V;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            this.V = Configuration.GetConnectionString("mis_db");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //1. setup cookie policy
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //2. setup cors support
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                //.AllowCredentials()
                );
            });

            //3. add dbcontext
            services.AddDbContextPool<MISDbContext>(
                            options => options.UseMySql(V, // replace with your Connection String
                                mySqlOptions =>
                                {
                                    mySqlOptions.ServerVersion(new Version(5, 7, 17), ServerType.MySql); // replace with your Server Version and Type
                                 }
                        ));

            //4. add identity
            services.AddIdentity<MISUser, IdentityRole>()
                  .AddEntityFrameworkStores<MISDbContext>()
                   .AddDefaultTokenProviders()
                   .AddDefaultUI();

 
            //5. localization
            services.AddMvc().AddViewLocalization();
            CultureInfo.CurrentCulture = new CultureInfo("en-EN");       
 
            //7. add session
            services.AddSession();
            

            #region transient section
            //8. add Email 
            services.AddTransient<IEmailSender, EmailSender>(i =>
              new EmailSender(
                  Configuration["EmailSender:Host"],
                  Configuration.GetValue<int>("EmailSender:Port"),
                  Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                  Configuration["EmailSender:UserName"],
                  Configuration["EmailSender:Password"]
              )
          );

            #endregion

            // services.AddTransient(typeof(IExportService), typeof(ExportService));


            //5. add Dot Net core v 2.2
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

   

            // services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            //6. Add user-defined services from hak team
            // services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));


            //7. Add cache memory
            services.AddMemoryCache();

            //8. Add session
       
            services.AddMvc().
            AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
                    
             //6. support localization
            services.AddMvc().AddViewLocalization();
            CultureInfo.CurrentCulture = new CultureInfo("en-EN");
           
           

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public   void  Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            CreateRoles(serviceProvider);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();

            //1.
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"images")),
                RequestPath = new PathString("/images")
            });
            // app.UseStaticFiles(new StaticFileOptions()
            // {
            //     FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"ads")),
            //     RequestPath = new PathString("/ads")
            // });

           
  

            //2. add support session
            app.UseSession();

            //3. add support for cor policty here
            app.UseCors("CorsPolicy");

            //4. add routing
   

            //5 add authorization
            app.UseAuthentication();
      
 
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            
             
            

        }//ef

        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            //1. get role and user manager
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<MISUser>>();
            //2. form a set of user roles
            string[] roleNames = { "ADMIN", "STAFF", "SUPPORT", "ROOT" };
            //IdentityResult roleResult;

            //3. check for root user
            MISUser root = await UserManager.FindByEmailAsync("oandy14@gmail.com");
            //4. if no root user, create one
            if (root == null)
            {
                root = new MISUser
                {
                    FirstName = "Anan",
                    LastName = "Osothsilp",
                    UserName = "oandy14@gmail.com",
                    NormalizedEmail = "OANDY14@GMAIL.COM",
                    Email = "oandy14@gmail.com",
                    Role = "ADMIN",
                    mobile = "66853509291",
                };
                string password = "Fp2020@";
                await UserManager.CreateAsync(root, password);
                root.EmailConfirmed = true; //auto confirm email
                await UserManager.UpdateAsync(root);
            }//eif
            // foreach (var role in roleNames)
            // {
            //     var roleExist = await RoleManager.RoleExistsAsync(role);
            //     if (!roleExist)
            //     {
            //         //create the roles and seed them to the database: Question 1  
            //         roleResult = await RoleManager.CreateAsync(new IdentityRole(role));
            //     }
            //     if (!await UserManager.IsInRoleAsync(root, role))
            //     {
            //         await UserManager.AddToRoleAsync(root, role);
            //     }
            // }

            //var users = UserManager.Users.Select(x =>x);
            // foreach(FpUser user in users){
            //     user.LockoutEnabled = true;
            //     user.LockoutEnd = null;  
            //     await UserManager.RemovePasswordAsync(user);
            //     await UserManager.AddPasswordAsync(user,"Fp2019*");
            // }
            // var users = UserManager.Users.Select(x => x);
            // foreach(FpUser user in users){
            //     //verify user role
            //     if(!(await UserManager.GetRolesAsync(user)).Contains(user.Role)){
            //         await UserManager.AddToRoleAsync(user, user.Role);
            //     }


            // }







        }//ef


       
    }//ec
    
}//en
