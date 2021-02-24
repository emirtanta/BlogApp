﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repository;

        public CategoryController(ICategoryRepository _repo)
        {
            repository = _repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        //kategori listesi bölgesi
        public IActionResult List()
        {
            return View(repository.GetAll());
        }

        #region Kategory Ekleme Bölgesi

        [HttpGet]
        public IActionResult Create()
        {
            

            return View();
        }

        [HttpPost]
        public IActionResult Create(Category entity)
        {
            if (ModelState.IsValid)
            {
                repository.AddCategory(entity);

                return RedirectToAction("List");
            }
            

            return View(entity);
        }

        #endregion

        #region Hem Ekleme hem Düzenleme Yapan bölümü

        [HttpGet]
        public IActionResult AddOrUpdate(int? id)
        {
            if (id==null)
            {
                return View(new Category());
            }

            else
            {
                return View(repository.GetById((int)id));
            }

            
        }

        [HttpPost]
        public IActionResult AddOrUpdate(Category entity)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCategory(entity);

                TempData["message"] = $"{entity.Name} kayıt edildi";

                return RedirectToAction("List");
            }

            return View(entity);
        }
        #endregion

        #region Kategori Silme Bölgesi



        #endregion
    }
}