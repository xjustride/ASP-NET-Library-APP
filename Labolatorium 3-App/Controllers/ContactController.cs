using Labolatorium_3_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_3_App.Controllers
{
    public class ContactController : Controller
    {
        //static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            List<Contact> contacts = _contactService.FindAll();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Contact model = new Contact();  
            model.Organizations = _contactService.FindAllOrganizations()
            .Select(oe => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
            {
                Text = oe.Name,
                Value = oe.Id.ToString(),
            }).ToList();
            model.Organizations.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
            {
                Text = "Brak organizacji",
                Value = ""
            }); ;
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Contact contact = _contactService.FindById(id);
            if(contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }
        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid) 
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            Contact contact = _contactService.FindById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(Contact model) 
        {
            _contactService.Delete(model.id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Contact contact = _contactService.FindById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

    }

}
