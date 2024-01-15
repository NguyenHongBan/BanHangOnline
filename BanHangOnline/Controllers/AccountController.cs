using BanHangOnline.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BanHangOnline.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUserModel> _userManage;
		private SignInManager<AppUserModel> _signInManage;

        public AccountController(SignInManager<AppUserModel> signInManager, UserManager<AppUserModel> userManager)
        {
            _signInManage = signInManager;
            _userManage = userManager;
        }
		public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(UserModel user)
		{
            if(ModelState.IsValid)
            {
                AppUserModel newUser = new AppUserModel 
                { 
                    UserName = user.Username,
                    Email = user.Email,
                };
                IdentityResult result = await _userManage.CreateAsync(newUser);
                if(result.Succeeded)
                {
                    TempData["success"] = "Đăng ký thành công!";
                    return Redirect("/account");
                }
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
			return View(user);
		}

	}
}
