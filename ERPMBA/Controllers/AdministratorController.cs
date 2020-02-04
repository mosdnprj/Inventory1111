using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERPMBA.Models;
using ERPMBA.Controllers;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace ERPMBA.Controllers
{
    public class AdministratorController : Controller
    {
        //
        // GET: /adminstration/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserAdmin()
        {
            return View();

        }
        public ActionResult Grants()
        {
            return View();

        }
        public JsonResult GetGrantInfo()
        {
            DbconnectionGrant dbcont = new DbconnectionGrant();
            List<Grants> ListofUser = dbcont.Grants.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertGrant(Grants usr1)

        {
            DbconnectionGrant dbcont = new DbconnectionGrant();
            var usr = new Grants();

            usr.Userid = usr1.Userid;
            usr.RoleId = usr1.RoleId;
            dbcont.Grants.Add(usr);
            dbcont.SaveChanges();
            return "Employee Inserted";
        }

        public ActionResult ItemAdmin()
        {
            return View();

        }
        public ActionResult CustomerAdmin()
        {
            return View();

        }
        public ActionResult Role()
        {
            return View();

        }
        public JsonResult GetRoleInfo()
        {
            DbconnectionRole dbcont = new DbconnectionRole();
            List<Role> ListofUser = dbcont.RoleClass.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertRole(Role usr1)

        {
            DbconnectionRole dbcont = new DbconnectionRole();
            var usr = new Role();

            usr.Inventory = usr1.Inventory;
            usr.HR = usr1.HR;
            usr.CRM = usr1.CRM;
            usr.Dashboard = usr1.Dashboard;
            usr.ITSMS = usr1.ITSMS;
            if (usr.Inventory == "0")
            {
                usr.RoleId = usr1.RoleId;
                usr.RoleName = usr1.RoleName;
                usr.Comments = usr1.Comments;
                usr.Users = "0";
                usr.Stack = "0";
                usr.Product = "0";
                usr.Packages = "0";
                usr.Orders = "0";
                usr.Billing = "0";
                usr.Integration = "0";
                usr.Reports = "0";
                dbcont.RoleClass.Add(usr);
                dbcont.SaveChanges();
                return "Employee Inserted";

            }
            else
            {
                usr.RoleId = usr1.RoleId;
                usr.RoleName = usr1.RoleName;
                usr.Comments = usr1.Comments;
                usr.Users = usr1.Users;
                usr.Stack = usr1.Stack;
                usr.Product = usr1.Product;
                usr.Packages = usr1.Packages;
                usr.Orders = usr1.Orders;
                usr.Billing = usr1.Billing;
                usr.Integration = usr1.Integration;
                usr.Reports = usr1.Reports;
                dbcont.RoleClass.Add(usr);
                dbcont.SaveChanges();
                return "Employee Inserted";

            }

        }

        [HttpPost]
        public string UpdateRole(Role usr1)
        {

            if (usr1 != null)
            {
                using (DbconnectionRole dataContext = new DbconnectionRole())
                {
                    var no = usr1.RoleId;
                    var usr = dataContext.RoleClass.Where(x => x.RoleId == no).FirstOrDefault();

                    usr.RoleId = usr1.RoleId;
                    usr.RoleName = usr1.RoleName;
                    usr.Comments = usr1.Comments;
                    usr.Inventory = usr1.Inventory;
                    usr.Users = usr1.Users;
                    usr.Stack = usr1.Stack;
                    usr.Product = usr1.Product;
                    usr.Packages = usr1.Packages;
                    usr.Orders = usr1.Orders;
                    usr.Billing = usr1.Billing;
                    usr.Integration = usr1.Integration;
                    usr.Reports = usr1.Reports;


                    dataContext.SaveChanges();
                    return "Employee Updated";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }



        public string DeleteRole(Role usrd)
        {
            if (usrd != null)
            {
                using (DbconnectionRole dataContext = new DbconnectionRole())
                {
                    var no = usrd.RoleId;
                    var UserList = dataContext.RoleClass.Where(x => x.RoleId == no).FirstOrDefault();
                    dataContext.RoleClass.Remove(UserList);
                    dataContext.SaveChanges();
                    return "Employee Deleted";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }


        public ActionResult SupplierAdmin()
        {
            return View();

        }
        public ActionResult HRAdmin()
        {
            return View();

        }
        public ActionResult UserInf()
        {

            return View();

        }

        public JsonResult GetUserInfo()
        {
            DbconnectionLogin dbcont = new DbconnectionLogin();
            List<Userclass> ListofUser = dbcont.Userclassses.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        public JsonResult getUserInf()
        {
            using (DbconnectionLogin dataContext = new DbconnectionLogin())
            {

                var ListofUsers = dataContext.Userclassses;
                return Json(ListofUsers, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult HR()
        {

            return View();

        }

        [HttpPost]
        public string InsertUsers(Userclass usr1)
        {
            DbconnectionLogin dbcont = new DbconnectionLogin();
            var usr = new Userclass();

            usr.userid = usr1.userid;
            usr.username = usr1.username;
            usr.email = usr1.email;
            usr.firstname = usr1.firstname;
            usr.secondname = usr1.secondname;
            usr.Telephoneno = usr1.Telephoneno;
            usr.password = usr1.password;
            usr.Image_User = usr1.Image_User;

            dbcont.Userclassses.Add(usr);
            dbcont.SaveChanges();

            return "Employee Inserted";

        }





        [HttpPost]
        public string UpdateUser(Userclass usr1)
        {

            if (usr1 != null)
            {
                using (DbconnectionLogin dataContext = new DbconnectionLogin())
                {
                    var no = usr1.userid;
                    var usr = dataContext.Userclassses.Where(x => x.userid == no).FirstOrDefault();

                    usr.userid = usr1.userid;
                    usr.username = usr1.username;
                    usr.email = usr1.email;
                    usr.firstname = usr1.firstname;
                    usr.secondname = usr1.secondname;
                    usr.Telephoneno = usr1.Telephoneno;
                    usr.password = usr1.password;
                    usr.Image_User = usr1.Image_User;


                    dataContext.SaveChanges();
                    return "Employee Updated";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }



        public string DeleteUser(Userclass usrd)
        {
            if (usrd != null)
            {
                using (DbconnectionLogin dataContext = new DbconnectionLogin())
                {
                    var no = usrd.userid;
                    var UserList = dataContext.Userclassses.Where(x => x.userid == no).FirstOrDefault();
                    dataContext.Userclassses.Remove(UserList);
                    dataContext.SaveChanges();
                    return "Employee Deleted";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }

        public ActionResult Setting1()
        {

            return View();

        }
        public string DeleteMenu(MenuClass usrd)
        {
            if (usrd != null)
            {
                using (DbconnectionSettings dataContext = new DbconnectionSettings())
                {
                    var no = usrd.MenuId;
                    var UserList = dataContext.MenuApp.Where(x => x.MenuId == no).FirstOrDefault();
                    dataContext.MenuApp.Remove(UserList);
                    dataContext.SaveChanges();
                    return "Employee Deleted";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }
        public string DeleteSubMenu(MenuChild usrd)
        {
            if (usrd != null)
            {
                using (DbconnectionSettingsChild dataContext = new DbconnectionSettingsChild())
                {
                    var no = usrd.ChildMenuId;
                    var UserList = dataContext.ChildMenuApp.Where(x => x.ChildMenuId == no).FirstOrDefault();
                    dataContext.ChildMenuApp.Remove(UserList);
                    dataContext.SaveChanges();
                    return "Employee Deleted";
                }
            }
            else
            {
                return "Invalid Employee";
            }
        }
        public ActionResult Customer()
        {

            return View();

        }




        public ActionResult Supplier()
        {

            return View();

        }
        public ActionResult Item()
        {

            return View();

        }




        public ActionResult ItemCatagory()
        {

            return View();

        }




        public JsonResult GetMenuInfo()
        {
            DbconnectionSettings dbcont = new DbconnectionSettings();
            List<MenuClass> ListOfMenu = dbcont.MenuApp.ToList();


            return Json(ListOfMenu, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetChildInfo()
        {
            DbconnectionSettingsChild dbcont = new DbconnectionSettingsChild();
            List<MenuChild> ListOfChildMenu = dbcont.ChildMenuApp.ToList();


            return Json(ListOfChildMenu, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public string InsertMenu(MenuClass MNU1)
        {
            DbconnectionSettings dbcont = new DbconnectionSettings();
            var mnu = new MenuClass();

            mnu.MenuId = MNU1.MenuId;
            mnu.MenuName = MNU1.MenuName;
            mnu.MenuAdded = MNU1.MenuAdded;
            dbcont.MenuApp.Add(mnu);
            dbcont.SaveChanges();

            return "Employee Inserted";

        }


        [HttpPost]
        public string GetChild(MenuChild MNUChild)
        {
            DbconnectionSettingsChild dbcont = new DbconnectionSettingsChild();
            var mnu = new MenuChild();

            mnu.ChildMenuId = MNUChild.ChildMenuId;
            mnu.ChildMenuName = MNUChild.ChildMenuName;
            mnu.ChildMenuAdded = MNUChild.ChildMenuAdded;
            mnu.MenuId = MNUChild.MenuId;
            dbcont.ChildMenuApp.Add(mnu);
            dbcont.SaveChanges();

            return "Employee Inserted";

        }

        public ActionResult Login()
        {

            return View();

        }

    }

}
