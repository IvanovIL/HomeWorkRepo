using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DZ17.Middleware
{
	public class ExcetpionMiddleware 
	{
		private readonly RequestDelegate _next;

		public ExcetpionMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			// Логика до передачи запроса следующему Middleware
			try
			{

				await _next(context); // Передача запроса следующему компоненту в конвейере
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка");
			}
			// Логика после передачи запроса следующему Middleware
			
		}

	}
}
