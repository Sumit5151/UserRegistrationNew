using Microsoft.AspNetCore.Mvc;
using UserRegistrationNew.Models;
using UserRegistrationNew.Repository;

namespace UserRegistrationNew.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepository userRepository;

        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }



        [HttpPost]
        public IActionResult Registration(UserViewModel userVM)
        {
            userRepository.Add(userVM);
            return View();

        }


        public IActionResult Index()
        {          
            return View();
        }

        public IActionResult Registration()
        {
            UserViewModel userVM = new UserViewModel();
            return View(userVM);
        }



        



        public IActionResult Update()
        {
            UserViewModel userVM = new UserViewModel();
            return View(userVM);
        }



        [HttpPost]
        public IActionResult Update(UserViewModel userVM)
        {

           
            userRepository.Add(userVM);
            return View();

        }


        public IActionResult Delete()
        {
           
            UserViewModel userVM = new UserViewModel();
            return View(userVM);
        }

    }
}
