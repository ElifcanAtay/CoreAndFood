﻿using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context c = new Context();
        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index(int page =1)
        {
         

            return View(foodRepository.TList("Category").ToPagedList(page,3));
        }
        [HttpGet] 
        public IActionResult AddFood()
        {
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem 
                                           {
                                               Text =x.CategoryName,
                                               Value=x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddFood(UrunEkle p)
        {
            Food f = new Food();
            if (p.ImageURL!=null)
            {
                var extension = Path.GetExtension(p.ImageURL.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/resimler/",newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageURL.CopyTo(stream);
                f.ImageURL = newimagename;
            }
            f.Name = p.Name;
            f.Price = p.Price;
            f.Stock = p.Stock;
            f.CategoryId = p.CategoryId;
            f.Description = p.Description;
            foodRepository.TAdd(f);

            return RedirectToAction("Index");
            
        }
        public IActionResult DeleteFood(int id)
        {
            
            foodRepository.TDelete(new Food { FoodId = id });
            return RedirectToAction("Index");
        }
        public IActionResult FoodGet(int id)
        {

            var x = foodRepository.TGet(id);
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Food f = new Food()
            {
                FoodId=x.FoodId,
                CategoryId=x.CategoryId,
                Name=x.Name,
                Price=x.Price,
                Stock=x.Stock,
                Description=x.Description,
                ImageURL=x.ImageURL
            };
            return View(f);
        }
        public IActionResult FoodUpdate(Food p)
        {
            var x = foodRepository.TGet(p.FoodId);
            x.Name = p.Name;
            x.Stock = p.Stock;
            x.Price = p.Price;
            x.Description = p.Description;
            x.ImageURL = p.ImageURL;
            x.CategoryId = p.CategoryId;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");



        }
 

    }
}
