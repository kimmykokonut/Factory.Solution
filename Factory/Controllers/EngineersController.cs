using Microsoft.AspNetCore.Mvc;
using Factory.Models; 
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Factory.Controllers;

public class EngineersController : Controller
{
  private readonly FactoryContext _db;
  public EngineersController(FactoryContext db)
  {
    _db = db;
  }
  public ActionResult Index()
  {
    return View();
    // List<ClassName> model = _db.Stylists.ToList();
    // return View(model);
  }
}