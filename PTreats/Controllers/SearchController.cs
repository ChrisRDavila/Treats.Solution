using PTreats.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PTreats.Controllers
{
  public class SearchController : Controller
  {
    private readonly PTreatsContext _db;
    public SearchController(PTreatsContext db)
    {
      _db = db;
    }

    private async Task<List<Flavor>> DoFlavorSearch(string query)
    {
      IQueryable<Flavor> results = _db.Set<Flavor>();
      if (query != null)
      {
        return await results?.Where(flavor => flavor.Type.Contains(query)).ToListAsync();
      }
      else
      {
        return await results.ToListAsync();
      }
    }

    private async Task<List<Treat>> DoTreatSearch(string query)
    {
      IQueryable<Treat> results = _db.Set<Treat>();
      if (query != null)
      {
        return await results?.Where(treat => treat.Description.Contains(query)).ToListAsync();
      }
      else
      {
        return await results.ToListAsync();
      }
    }

    public async Task<IActionResult> Index(string query)
    {
      ViewBag.PageTitle = $"Search results for {query}";
      List<Flavor> flavorResults = await DoFlavorSearch(query);
      if (flavorResults.Count == 0)
      {
        List<Treat> treatResults = await DoTreatSearch(query);
        @ViewBag.SearchType = "treats";
        return View(treatResults);
      }
      else 
      {
        @ViewBag.SearchType = "flavors";
        return View(flavorResults);
      }
    }
  }
}

