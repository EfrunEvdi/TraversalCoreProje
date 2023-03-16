using BusinessLayer.Abstarct.AbstractUow;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            var SenderValue = _accountService.TGetByID(model.SenderID);
            var ReceiveValue = _accountService.TGetByID(model.ReceiverID);
            // Sender - Gender - Amount
            SenderValue.Balance -= model.Amount;
            ReceiveValue.Balance += model.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                SenderValue,
                ReceiveValue,
            };

            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
