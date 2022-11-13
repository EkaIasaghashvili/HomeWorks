using HomeWork13.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;

namespace HomeWork13.Controllers
{
    public class ReserveController : Controller
    {
        private readonly string path = @"C:\Users\user\source\repos\HomeWorks\HomeWork13\File\Reserve.json";
        // GET: ReserveController
        public ActionResult Index()
        {
            var result = new List<Reserve>();
            if (System.IO.File.Exists(path))
            {
                using var reader = new StreamReader(path);
                string jsonString = reader.ReadToEnd();

                if (!string.IsNullOrEmpty(jsonString))
                    result = JsonSerializer.Deserialize<List<Reserve>>(jsonString);
            }
            
            return View(result);
        }

        // GET: ReserveController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReserveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReserveController/Create
        [HttpPost]
        
        public ActionResult Create(Reserve newReserve)
        {
            if (!ModelState.IsValid)
            {
                return View("Error", new ErrorViewModel() { RequestId = ModelState["Time"].Errors[0].ErrorMessage });
            }

            var list = new List<Reserve>();

            if (System.IO.File.Exists(path))
            {
                using var reader = new StreamReader(path);
                string jsonString = reader.ReadToEnd();
                list = JsonSerializer.Deserialize<List<Reserve>>(jsonString);
            }

            list.Add(newReserve);

            string json = JsonSerializer.Serialize(list);
            System.IO.File.WriteAllText(path, json);
            return RedirectToAction("Index");
        }

        // GET: ReserveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReserveController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReserveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReserveController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
