using SongProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace SongProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (SongDBContext db = new SongDBContext())
            {
                return View(db.Users.ToList());
            }
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserAccount account)
        {
            if (ModelState.IsValid)
            {
                using (SongDBContext db = new SongDBContext())
                {
                    db.Users.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + "Successfully Registered.";
                return RedirectToAction("Login");
            }
            return View();

        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (SongDBContext db = new SongDBContext())
            {
                /* if (ModelState.IsValid)
                 {*/
                /*                    var usr = db.Users.Single(u => u.Username == user.Username && u.Password == user.Password);
                */
                var usr = db.Users.Where(s => s.Username.Equals(user.Username) && s.Password.Equals(user.Password)).FirstOrDefault();


                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.Username.ToString();

                    return RedirectToAction("Search", "Song");

                }
                else
                {
                    ModelState.AddModelError("", "UserName or password is wrong");
                }

            }
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin(UserAccount usr)
        {

            if (usr != null)
            {
                Session["Username"] = "admin";
                Session["Password"] = "admin";

                return RedirectToAction("Create", "Song");

            }
            else
            {
                ModelState.AddModelError("", "UserName or password is wrong");
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
            // return View();
        }
    }
}