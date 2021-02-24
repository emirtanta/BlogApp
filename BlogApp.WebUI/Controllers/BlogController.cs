using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _blogRepository;
        private ICategoryRepository _categoryRepository;

        public BlogController(IBlogRepository blogRepo,ICategoryRepository categoryRepo)
        {
            _blogRepository = blogRepo;
            _categoryRepository = categoryRepo;
        }

        
        //arama işlemi ve diğer
        public IActionResult Index(int? id ,string q)
        {
            var query = _blogRepository.GetAll().Where(i => i.isApproved);

            if (id!=null)
            {
                query = query.Where(i => i.CategoryId == id);
            }

            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(x => x.Title.Contains(q) || x.Body.Contains(q) || x.Description.Contains(q));

                //yada böyle de yazılabilir
                //query = query.Where(i => EF.Functions.Like(i.Title, "%" + q + "%") || EF.Functions.Like(i.Body, "%" + q + "%") || EF.Functions.Like(i.Description, "%" + q + "%"));
            }

            return View(query.OrderByDescending(i => i.Date));
            
        }


        //blog listesi bölgesi
        public IActionResult List()
        {
            return View(_blogRepository.GetAll());
        }

        #region Blok Ekleme Bölgesi

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            return View(new Blog());
        }

        [HttpPost]
        public IActionResult Create(Blog entity)
        {
            entity.Date = DateTime.Now;

            if (ModelState.IsValid)
            {
                _blogRepository.SaveBlog(entity);
                TempData["message"] = $"{entity.Title} kayıt edildi";

                return RedirectToAction("List");
            }

            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            return View(entity);
        }

        #endregion

        #region Blog Güncelleme Bölgesi

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            return View(_blogRepository.GetById(id));
        }

        //resim yüklemek içi IFormFile eklenir. Birden fazla resim yüklemek için ise Ienumrable<IFormFile> yazılır
        [HttpPost]
        public async Task<IActionResult> Edit(Blog entity,IFormFile file)
        {
            if (ModelState.IsValid)
            {

                if (file!=null)
                {
                    //resim yükleme
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);

                    //resim yükleme
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);

                        entity.Image = file.FileName;
                    }
                }
                

                

                _blogRepository.UpdateBlog(entity);

                TempData["message"] = $"{entity.Title} güncellendi";

                return RedirectToAction("List");
            }

            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            return View(entity);
        }
        #endregion

        //hem ekleme hem de güncelleme yapan yer anternatif çözüm
        [HttpGet]
        public IActionResult AddOrUpdate(int? id)
        {
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            if (id==null)
            {
                //yeni bir kayıt
                return View(new Blog());
            }
            else
            {
                //güncelleme
                return View(_blogRepository.GetById((int)id));
            }
        }

        [HttpPost]
        public IActionResult AddOrUpdate(Blog entity)
        {
            if (ModelState.IsValid)
            {
                _blogRepository.SaveBlog(entity);

                TempData["message"] = $"{entity.Title} kayıt edildi";

                return RedirectToAction("List");
            }

            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            return View(entity);
        }

        #region Blog Silme Bölgesi

        [HttpGet]
        public IActionResult Delete(int id)
        {

            
            return View(_blogRepository.GetById(id));
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirm(int BlogId)
        {
            _blogRepository.DeleteBlog(BlogId);
            TempData["message"] = $"{BlogId} numaralı kayıt edildi";

            return RedirectToAction("List");
        }
        #endregion

        #region Blog Detay Bölgesi

        public IActionResult Details(int id)
        {
            return View(_blogRepository.GetById(id));
        }

        #endregion
    }
}