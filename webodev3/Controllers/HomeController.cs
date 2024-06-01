using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webodev3.Models;

namespace webodev3.Controllers;

public class HomeController : Controller
{
     private readonly ILogger<HomeController> _logger;
    private readonly AdminContext context;

    public HomeController(ILogger<HomeController> logger, AdminContext context)
    {
        _logger = logger;
        this.context = context;
    }
    public IActionResult Index()
    {
        return View(context.Kayitlar.ToList());
    }
    public IActionResult Ekle()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Ekle(Kayit model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        context.Kayitlar.Add(model);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Guncelle(int id)
    {
        Kayit? kayit = context.Kayitlar.FirstOrDefault(x => x.Id == id);
        return View(kayit);
    }
    [HttpPost]
    public IActionResult Guncelle(Kayit model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        context.Kayitlar.Update(model);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Sil(int id)
    {
        Kayit ?kayit = context.Kayitlar.FirstOrDefault(x => x.Id == id);
        context.Kayitlar.Remove(kayit);
        context.SaveChanges();
        return RedirectToAction("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
