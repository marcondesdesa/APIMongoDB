using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Mongo.Infra;
using Mongo.Servico;

namespace Mongo.API
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
            var appSettings = new AppSettings();           
            var cfcoAppSettings = new ConfigureFromConfigurationOptions<AppSettings>(Configuration.GetSection("AppSettings"));
            cfcoAppSettings.Configure(appSettings);
            services.AddSingleton<AppSettings>(appSettings);

            var mongoSettings = new MongoSettings(appSettings);          
            services.AddSingleton<MongoSettings>(mongoSettings);

            //AddTransient = Adiciona apenas o tipo à injeção, o instancia é criada na chamada do construtor (quem o usa)
            // services.AddTransient<ProdutoServico>();
            services.AddScoped<ProdutoServico>(); //AddScoped = Mantem a mesma instancia por sessao de requisicao 
            //services.AddTransient<MarcaServico>();
            services.AddScoped<MarcaServico>();                       
            //services.AddTransient<PessoaServico>();
            services.AddScoped<PessoaServico>();
            services.AddTransient<PedidoServico>();

            services.AddControllers();


            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
           
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
