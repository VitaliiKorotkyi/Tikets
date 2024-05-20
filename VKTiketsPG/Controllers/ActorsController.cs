using Microsoft.AspNetCore.Mvc;
using VKTiketsPG.Data.Services;
using VKTiketsPG.Models;

public class ActorsController : Controller
{
    private readonly IActorsService _service;

    public ActorsController(IActorsService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var actors = await _service.GetAllAsync();
        return View(actors);
    }

    // GET: Actors/Create
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
    {
        if (!ModelState.IsValid)
        {
            return View(actor);
        }

        
            await _service.AddAsync(actor);
            TempData["SuccessMessage"] = "Actor added successfully!";
            return RedirectToAction(nameof(Index));
        
       
    }
    //Get: Actors/Detalils/1
    public async Task<IActionResult> Detalis(int id)
    {
        var actorDetails = await _service.GetByIdAsync(id);
        if (actorDetails == null)
        {
            return View("NotFound");
        }
        return View(actorDetails);
    }
    public async Task<IActionResult> Edit(int id)
    {
        var actorDetails = await _service.GetByIdAsync(id);
        if (actorDetails == null)
        {
            return View("Notfound");
        }

        return View(actorDetails);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
    {
        if (!ModelState.IsValid)
        {

            return View(actor);
        }
        await _service.UpdateAsync(id, actor);
        return RedirectToAction(nameof(Index));
    }

    //Get: Actors/Delete/1
    public async Task<IActionResult> Delete(int id)
    { 
    var actorDetails=await _service.GetByIdAsync(id);
        if (actorDetails is null)
        {
            return View("NotFound");
        }
        return View(actorDetails);
    
    }
    [HttpPost,ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var actorDetails = await _service.GetByIdAsync(id);
        if (actorDetails is null)
        {
            return View("NotFound");
        }
        await _service.DeleteAsync(id);
        return RedirectToAction(nameof(Index)); 
      
  

    }
}
