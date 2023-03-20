using AutoMapper;
using BusinessLayer.Abstarct;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactUsController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    Mail = model.Mail,
                    MessageBody = model.MessageBody,
                    MessageDate = model.MessageDate,
                    MessageStatus = true,
                    Name = model.Name,
                    Subject = model.Subject

                });
                return RedirectToAction("Index", "ContactUs");
            }
            return View(model);
        }
    }
}
