using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DZ17.Models;


namespace DZ17.Controllers;
[Route("Products")]
public class ProductsController : Controller
{

	public List<Product> products = new List<Product>()
	{
			new Product {Id = 1, Name = "Смартфон", Price = 2000 },
		new Product {Id = 2, Name = "Телевизор", Price = 6000 },
		new Product {Id = 3, Name = "Компьютер", Price = 10000 },
		new Product {Id = 4, Name = "Планшет", Price = 4700 },
		new Product {Id = 5, Name = "Монитор", Price = 4000 }
	};


	[HttpGet]
	[Route("List")]

	public IActionResult List()
	{
		
		return View("List",products);
	}

	[HttpGet]
	[Route("Menu")]
	public IActionResult Menu()
	{
		return View("Menu");
	}

	[HttpPost]
	[Route("Delete")]

	public IActionResult Delete(int id)
	{
		bool run = false;
		int valueId = 0;
		for (int i = 0; i < products.Count; i++)
		{
			if (products[i].Id == id)
			{
				valueId = products[i].Id;
				run = true;
				break;
			}
		}

		if (run == true)
		{
			products.RemoveAt(valueId);
			return View("DeleteProducts");
		}
		else
		{
			return BadRequest();
		}
		
	}

	[HttpGet]
	[Route("DeleteProducts")]
	public IActionResult DeleteProducts()
	{
		return View("DeleteProducts");
	}

	[HttpPost]
	[Route("Add")]

	public IActionResult Add(Product userProduct)
	{
		bool run = false;

		for (int i =0; i < products.Count;i++)
		{
			if (products[i].Id != userProduct.Id)
			{
				run = true;
				break;
			}
		}
		if (run == true)
		{
			products.Add(userProduct);
			return View("AddProducts");
		}
		else
		{
			return BadRequest();
		}
	}

	[HttpGet]
	[Route("AddProducts")]

	public IActionResult AddProducts()
	{
		return View("AddProducts");
	}

	
}
