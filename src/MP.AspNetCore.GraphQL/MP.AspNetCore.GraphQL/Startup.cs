using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MP.AspNetCore.GraphQL.Data;
using MP.AspNetCore.GraphQL.Models;
using MP.AspNetCore.GraphQL.Models.Schemas;

namespace MP.AspNetCore.GraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<PersonsQuery>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();
            services.AddTransient<RoleType>();
            services.AddTransient<PersonType>();
            var sp = services.BuildServiceProvider();
            services.AddScoped<ISchema>(_ => new PersonsSchema(type => (GraphType)sp.GetService(type)) { Query = sp.GetService<PersonsQuery>() });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseGraphiQl();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}