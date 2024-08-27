using Microsoft.AspNetCore;
using DZ16.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace DZ16.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private new List<Products> productsList = new List<Products>()
        {
            new Products{Id = 1, Name = "Bread", Price = 10},
            new Products{Id = 2, Name = "Apple", Price = 25 },
            new Products{Id = 3, Name = "Potato", Price = 15 },
            new Products{Id = 4, Name = "Fish", Price = 34 },
            new Products{Id = 5, Name = "Tomato", Price = 20 },
            new Products{Id = 6, Name = "Sprite", Price = 43 },
            new Products{Id = 7, Name = "CocaCola", Price = 46 },
            new Products{Id = 8, Name = "Tea", Price = 15 }


        };

        [HttpGet]
        [Route("getProducts")]

        public IActionResult getProducts()
        {
            return Ok(productsList);
        }

        [HttpPost]
        [Route("DeleteProducts")]

        public IActionResult DeleteProducts(int id)
        {
            bool run = true;
            int valueId = 0;
           

            for (int i = 0; i < productsList.Count; i++)
            {
                if (productsList[i].Id == id)
                {
                    run = false;
                    valueId = productsList[i].Id;
                    break;
                }
            }

            if (run == false)
            {
                productsList.RemoveAt(valueId);
               
                
                return Ok(productsList);
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        [Route("AddProducts")]

        public IActionResult AddProducts(Products product1)
        {
            bool run = false;

            for (int i = 0; i < productsList.Count(); i++)
            {
               if (productsList[i].Id == product1.Id)
                {
                    run = true;
                    break;
                }
                        
            }

            if (true)
            {

                productsList.Add(product1);
                return Ok(productsList);


            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}





