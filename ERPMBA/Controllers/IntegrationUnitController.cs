using ERPMBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERPMBA.Controllers
{
    public class IntegrationUnitController : Controller
    {
        //
        // GET: /IntegrationUnit/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserAdmin()
        {
            return View();
        }
        public ActionResult ItemAdmin()
        {
            return View();

        }
        public ActionResult CustomerAdmin()
        {
            return View();

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

        public ActionResult HR()
        {

            return View();

        }

        public ActionResult Customer()
        {

            return View();

        }

         public JsonResult GetNewCustomerInfo()
        {
            DbCustomer dbcont = new DbCustomer();
            List<NewCustomer> ListofUser = dbcont.NewCustomers.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public string InsertNewCustomer(NewCustomer usr1)
        {
            DbCustomer dbcont = new DbCustomer();
            var usr = new NewCustomer();

           
            usr.CustomerName = usr1.CustomerName;
            usr.Companyname = usr1.Companyname;
            usr.Contactdisplayname = usr1.Contactdisplayname;
            usr.Email = usr1.Email;
            usr.Companymail = usr1.Companymail;
            usr.Phoneno = usr1.Phoneno;
            usr.Mobileno = usr1.Mobileno;
            usr.Skype = usr1.Skype;
            usr.Designation = usr1.Designation;
            usr.Department = usr1.Department;
            usr.Website = usr1.Website;
            usr.Street1 = usr1.Street1;
            usr.Street2 = usr1.Street2;
            usr.City = usr1.City;
            usr.States = usr1.States;
            usr.Zipcode = usr1.Zipcode;
            usr.Country = usr1.Country;
            usr.Currency = usr1.Currency;
            usr.Payment = usr1.Payment;
            dbcont.NewCustomers.Add(usr);
            dbcont.SaveChanges();

            return "Customer Updated";

        }

        [HttpPost]
        public string UpdateNewCustomer(NewCustomer usr1)
        {

            if (usr1 != null)
            {
                using (DbCustomer dataContext = new DbCustomer())
                {
                    var no = usr1.CustomerID;
                    var usr = dataContext.NewCustomers.Where(x => x.CustomerID == no).FirstOrDefault();


                    usr.CustomerName = usr1.CustomerName;
                    usr.Companyname = usr1.Companyname;
                    usr.Contactdisplayname = usr1.Contactdisplayname;
                    usr.Email = usr1.Email;
                    usr.Companymail = usr1.Companymail;
                    usr.Phoneno = usr1.Phoneno;
                    usr.Mobileno = usr1.Mobileno;
                    usr.Skype = usr1.Skype;
                    usr.Designation = usr1.Designation;
                    usr.Department = usr1.Department;
                    usr.Website = usr1.Website;
                    usr.Street1 = usr1.Street1;
                    usr.Street2 = usr1.Street2;
                    usr.City = usr1.City;
                    usr.States = usr1.States;
                    usr.Zipcode = usr1.Zipcode;
                    usr.Country = usr1.Country;
                    usr.Currency = usr1.Currency;
                    usr.Payment = usr1.Payment;
                    dataContext.SaveChanges();
                    return "Customer Updated";
                }
            }
            else
            {
                return "Invalid Customer";
            }
        }
        public string DeleteNewCustomer(NewCustomer usrd)
        {
            if (usrd != null)
            {
                using (DbCustomer dbcont = new DbCustomer())
                {
                    var no = usrd.CustomerID;
                    var UserList = dbcont.NewCustomers.Where(x => x.CustomerID == no).FirstOrDefault();
                    dbcont.NewCustomers.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Customer Deleted";
                }
            }
            else
            {
                return "Invalid Customer";
            }
        }
       
       
        
       
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ItemGroups()
        {
            return View();
        }
        

        public ActionResult CompositeItems()
        {
            return View();
        }
        public ActionResult ItemAdjustments()
        {
            return View();
        }
        public ActionResult TransferOrders()
        {
            return View();
        }
        public ActionResult Unit()
        {
            return View();
        }
        public ActionResult Manufacturer()
        {
            return View();
        }
       

    }
}
