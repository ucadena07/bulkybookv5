using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BulkyBookV5.DataAccess.Repository.IRepository;
using BulkyBookV5.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookV5.Areas.Customer.Controllers
{
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IEmailSender _emailSender;

        private readonly UserManager<IdentityUser> _userManager;

        public ShoppingCartVM ShoppingCartVM { get; set; }

        public CartController(IUnitOfWork unitOfWork, IEmailSender emailSender, UserManager<IdentityUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _emailSender = emailSender;
            _userManager = userManager;

        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            ShoppingCartVM = new ShoppingCartVM()
            {
                OrderHeader = new Models.OrderHeader(),
                ListCart = _unitOfWork.ShoppingCart.GetAll(u=> u.ApplicationUserId == claim.Value, includeProperties:"Products")
            };
            ShoppingCartVM.OrderHeader.OrderTotal = 0;
            ShoppingCartVM.OrderHeader.ApplicationUser = _unitOfWork.ApplicationUser
                                                            .GetFirstOrDefault(u => u.Id == claim.Value, 
                                                            includeProperties: "Company");
            foreach(var list in ShoppingCartVM.ListCart)
            {
                list.Product = _unitOfWork.Product.GetFirstOrDefault();
            }
            return View();
        }
    }
}
