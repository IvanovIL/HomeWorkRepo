
using DZ17.Filtr;
using DZ17.Middleware;
using Microsoft.AspNetCore.Builder;

namespace DZ17
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();
			builder.Services.AddControllersWithViews( options =>
			{
				options.Filters.Add<TimeFiltr>();
			});

			var app = builder.Build();
			app.UseMiddleware<ExcetpionMiddleware>();
			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();
		
			app.MapControllerRoute(
				name: "deafult",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
		
	}
}