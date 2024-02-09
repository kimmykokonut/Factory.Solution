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
    List<Engineer> model = _db.Engineers.ToList();
    return View(model);
  }
  public ActionResult Details(int id)
  {
    Engineer thisEngineer = _db.Engineers
    .FirstOrDefault(engineer => engineer.EngineerId == id);
    return View(thisEngineer);
  }
}
