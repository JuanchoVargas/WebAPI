using System;
using Microsoft.EntityFrameworkCore;
using WebAPIAutores;

namespace WebAPI
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

			services.AddDbContext<ApplicationDBContext>(options =>
			options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));

			services.AddEndpointsApiExplorer();
			services.AddAuthorization();
			services.AddControllers();
			services.AddHealthChecks();
			services.AddSwaggerGen();

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// 202301142257: Usa swagger también en producción
			// if (env.IsDevelopment())
			// {
			app.UseSwagger();
			app.UseSwaggerUI();
			// }

			// 202301142255: Desabilita la redirección
			// app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
