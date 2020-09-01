using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Catalog.Products;
using System.Text.Json;
namespace API.Controllers
{
    public class ProductController : Controller
    {
        private readonly IManageProductService _manageProductService;
        public ProductController(IManageProductService manageProductService)
        {
            _manageProductService = manageProductService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(JsonSerializer.Serialize(_manageProductService.GetAll().Result));
        } 
    }
}