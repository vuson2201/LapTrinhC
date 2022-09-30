﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC.Infrastructure;
using WebMVC.Models;

namespace WebMVC.Controllers
{

    public class ToDoController : Controller
    {
        private ToDoContext context;

        public ToDoController(ToDoContext context)
        {
            this.context = context;
        }

        // GET /
        public async Task<ActionResult> Index()
        {
            IQueryable<TodoList> items = from i in context.ToDoList orderby i.Id select i;

            List<TodoList> todoList = await items.ToListAsync();

            return View(todoList);

        }

        // GET /todo/create
        public IActionResult Create() => View();

        // POST /todo/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TodoList item)
        {
            if (ModelState.IsValid)
            {
                context.Add(item);
                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(item);

        }

        // GET /todo/edit/5
        public async Task<ActionResult> Edit(int id)
        {
            TodoList item = await context.ToDoList.FindAsync(id);
            
            return View(item);

        }

        // POST /todo/edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(TodoList item)
        {
            if (ModelState.IsValid)
            {
                context.Update(item);
                await context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET /todo/delete/5
        public async Task<ActionResult> Delete(int id)
        {
            TodoList item = await context.ToDoList.FindAsync(id);
            context.ToDoList.Remove(item);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
