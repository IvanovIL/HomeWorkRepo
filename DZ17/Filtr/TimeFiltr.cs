using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
namespace DZ17.Filtr
{
	public class TimeFiltr : IActionFilter
	{
		private Stopwatch timer;
		 public void OnActionExecuting(ActionExecutingContext context)
		{
			timer = Stopwatch.StartNew();
			
		}

		public void OnActionExecuted(ActionExecutedContext context)
		{
			timer.Stop();

			
			Console.WriteLine($"Время ответа запроса  {timer.Elapsed}");
		}
	}
}

