using ERPMBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Mvc.Html;

namespace ERPMBA.Controllers
{
    public class InventoryController : Controller
    {
        //
        // GET: /Inventory/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }
        public ActionResult ReportSales()
        {
            return View();
        }

        public ActionResult SPR()
        {
            //    DbSalesperson dbcont = new DbSalesperson();
            //     List<Salesperson> ListofUser = dbcont.Salespersons.ToList();
            //     ReportDataSource datasource = new ReportDataSource(ListofUser.ToString());

            //      Warning[] warnings;
            //       string mimeType;
            //      string[] streamids;
            //       string encoding;
            //   string filenameExtension;
            //   string extension;


            //     ReportViewer rv = new Microsoft.Reporting.WebForms.ReportViewer();
            //     rv.ProcessingMode = ProcessingMode.Local;

            //     rv.LocalReport.ReportPath = Server.MapPath("~/Reports/Report1.rdlc");
            //      rv.LocalReport.Refresh();

            //       byte[] bytes = rv.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);


            //    ReportDataSource RDS = new ReportDataSource("RepotrDS", ListofUser.ToList());

            //   rv.LocalReport.DataSources.Add(RDS);

            //     rv.LocalReport.Refresh();
            //    return PartialView("rv"); 
            return View();
        }
        

        public ActionResult NewCustomer()
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
            usr.Phoneno = Convert.ToInt32(usr1.Phoneno);
          usr.Mobileno = Convert.ToInt32(usr1.Mobileno);
            usr.Skype = usr1.Skype;
            usr.Designation = usr1.Designation;
            usr.Department = usr1.Department;
            usr.Website = usr1.Website;
            usr.Street1 = usr1.Street1;
            usr.Street2 = usr1.Street2;
            usr.City = usr1.City;
            usr.States = usr1.States;
            usr.Zipcode = Convert.ToInt32(usr1.Zipcode);
            usr.Country = usr1.Country;
            usr.Payment = usr1.Payment;
            usr.Currency = usr1.Currency;


            dbcont.NewCustomers.Add(usr);
            dbcont.SaveChanges();

            return "Customer Added";

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
                    usr.Payment = usr1.Payment;
                    usr.Currency = usr1.Currency;
                    
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

        public ActionResult Supplier()
        {

            return View();
        }
        public JsonResult GetSupplierInfo()
        {
            DbSupplier dbcont = new DbSupplier();
            List<Supplier> ListofUser = dbcont.Suppliers.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public string InsertSupplier(Supplier usr1)
        {
            DbSupplier dbcont = new DbSupplier();
            var usr = new Supplier();


         //   usr.Salutation = usr1.Salutation;
            usr.SupplierName = usr1.SupplierName;
            usr.Companyname = usr1.Companyname;
            usr.Email = usr1.Email;
            usr.Mobileno = usr1.Mobileno;
            usr.Webpage = usr1.Webpage;
            usr.Suppliergroup = usr1.Suppliergroup;
            usr.Businesstype = usr1.Businesstype;
            usr.Deliveryterms = usr1.Deliveryterms;
            usr.Tax = usr1.Tax;
            usr.Street1 = usr1.Street1;
            usr.Street2 = usr1.Street2;
            usr.City = usr1.City;
            usr.State = usr1.State;
            usr.Zipcode = usr1.Zipcode;
            usr.Country = usr1.Country;
            usr.Bank = usr1.Bank;
            usr.Accountno = usr1.Accountno;
            usr.Ifsc = usr1.Ifsc;
            usr.Paymentdeadline = usr1.Paymentdeadline;
            usr.Currency = usr1.Currency;
            usr.Paymentmethod = usr1.Paymentmethod;


            dbcont.Suppliers.Add(usr);
            dbcont.SaveChanges();

            return "Supplier Added";

        }

        [HttpPost]
        public string UpdateSupplier(Supplier usr1)
        {

            if (usr1 != null)
            {
                using (DbSupplier dataContext = new DbSupplier())
                {
                    var no = usr1.SupplierID;
                    var usr = dataContext.Suppliers.Where(x => x.SupplierID == no).FirstOrDefault();


                  //  usr.Salutation = usr1.Salutation;
                    usr.SupplierName = usr1.SupplierName;
                    usr.Companyname = usr1.Companyname;
                    usr.Email = usr1.Email;
                    usr.Mobileno = usr1.Mobileno;
                    usr.Webpage = usr1.Webpage;
                    usr.Suppliergroup = usr1.Suppliergroup;
                    usr.Businesstype = usr1.Businesstype;
                    usr.Deliveryterms = usr1.Deliveryterms;
                    usr.Tax = usr1.Tax;
                    usr.Street1 = usr1.Street1;
                    usr.Street2 = usr1.Street2;
                    usr.City = usr1.City;
                    usr.State = usr1.State;
                    usr.Zipcode = usr1.Zipcode;
                    usr.Country = usr1.Country;
                    usr.Bank = usr1.Bank;
                    usr.Accountno = usr1.Accountno;
                    usr.Ifsc = usr1.Ifsc;
                    usr.Paymentdeadline = usr1.Paymentdeadline;
                    usr.Currency = usr1.Currency;
                    usr.Paymentmethod = usr1.Paymentmethod;
                    dataContext.SaveChanges();
                    return "Supplier Updated";
                }
            }
            else
            {
                return "Invalid Supplier";
            }
        }
        public string DeleteSupplier(Supplier usrd)
        {
            if (usrd != null)
            {
                using (DbSupplier dbcont = new DbSupplier())
                {
                    var no = usrd.SupplierID;
                    var UserList = dbcont.Suppliers.Where(x => x.SupplierID == no).FirstOrDefault();
                    dbcont.Suppliers.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Supplier Deleted";
                }
            }
            else
            {
                return "Invalid Supplier";
            }
        }

        public ActionResult Salesperson()
        {
            return View();
        }

        public JsonResult GetSalespersonInfo()
        {
            DbSalesperson dbcont = new DbSalesperson();
            List<Salesperson> ListofUser = dbcont.Salespersons.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public string InsertSalesperson(Salesperson usr1)
        {
            DbSalesperson dbcont = new DbSalesperson();
            var usr = new Salesperson();

            usr.Sellerid = usr1.Sellerid;
            usr.Sellername = usr1.Sellername;
            usr.Sellercontactno = usr1.Sellercontactno;

            dbcont.Salespersons.Add(usr);
            dbcont.SaveChanges();

            return "Sales Person Updated";

        }

        [HttpPost]
        public string UpdateSalesperson(Salesperson usr1)
        {

            if (usr1 != null)
            {
                using (DbSalesperson dataContext = new DbSalesperson())
                {
                    var no = usr1.Sellerid;
                    var usr = dataContext.Salespersons.Where(x => x.Sellerid == no).FirstOrDefault();


                    usr.Sellerid = usr1.Sellerid;
                    usr.Sellername = usr1.Sellername;
                    usr.Sellercontactno = usr1.Sellercontactno;
                    dataContext.SaveChanges();
                    return "Sales Person Updated";
                }
            }
            else
            {
                return "Invalid Sales Person";
            }
        }
        public string DeleteSalesperson(Salesperson usrd)
        {
            if (usrd != null)
            {
                using (DbSalesperson dbcont = new DbSalesperson())
                {
                    var no = usrd.Sellerid;
                    var UserList = dbcont.Salespersons.Where(x => x.Sellerid == no).FirstOrDefault();
                    dbcont.Salespersons.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Sales Person Deleted";
                }
            }
            else
            {
                return "Invalid Sales Person";
            }
        }
        
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Category()
        {
            return View();
        }

        public JsonResult GetCategoryInfo()
        {
            DbCategory dbcont = new DbCategory();
            List<Category> ListofUser = dbcont.Categories.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public string InsertCategory(Category usr1)
        {
            DbCategory dbcont = new DbCategory();
            var usr = new Category();

            usr.Categoryname = usr1.Categoryname;
            usr.CategoryStatus = usr1.CategoryStatus;
            


            dbcont.Categories.Add(usr);
            dbcont.SaveChanges();

            return "Category Added";

        }

        [HttpPost]
        public string UpdateCategory(Category usr1)
        {

            if (usr1 != null)
            {
                using (DbCategory dataContext = new DbCategory())
                {
                    var no = usr1.Categoryname;
                    var usr = dataContext.Categories.Where(x => x.Categoryname == no).FirstOrDefault();
                    usr.CategoryStatus = usr1.CategoryStatus;
                    dataContext.SaveChanges();
                    return "Category Updated";
                }
            }
            else
            {
                return "Invalid Category";
            }
        }
        public string DeleteCategory(Category usrd)
        {
            if (usrd != null)
            {
                using (DbCategory dbcont = new DbCategory())
                {
                    var no = usrd.Categoryname;
                    var UserList = dbcont.Categories.Where(x => x.Categoryname == no).FirstOrDefault();
                    dbcont.Categories.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Category Deleted";
                }
            }
            else
            {
                return "Invalid Category";
            }
        }
        public ActionResult Brand()
        {
            return View();
        }

        public JsonResult GetBrandInfo()
        {
            DbBrand dbcont = new DbBrand();
            List<Brand> ListofUser = dbcont.Brands.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getCategorydetail()
        {
            DbBrand dbcont = new DbBrand();
            List<Category> ListofUser = dbcont.BrandCategory.ToList();
            return Json(ListofUser, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public string InsertBrand(Brand usr1)
        {
            DbBrand dbcont = new DbBrand();
            var usr = new Brand();

            usr.Categoryname = usr1.Categoryname;
            usr.Brandname = usr1.Brandname;
            usr.Brandstatus = usr1.Brandstatus;



            dbcont.Brands.Add(usr);
            dbcont.SaveChanges();

            return "Brand Updated";

        }

        [HttpPost]
        public string UpdateBrand(Brand usr1)
        {

            if (usr1 != null)
            {
                using (DbBrand dataContext = new DbBrand())
                {
                    var no = usr1.Brandname;
                    var usr = dataContext.Brands.Where(x => x.Brandname == no).FirstOrDefault();

                    usr.Categoryname = usr1.Categoryname;
                    usr.Brandstatus = usr1.Brandstatus;

                    dataContext.SaveChanges();
                    return "Brand Updated";
                }
            }
            else
            {
                return "Invalid Brand";
            }
        }
        public string DeleteBrand(Brand usrd)
        {
            if (usrd != null)
            {
                using (DbBrand dbcont = new DbBrand())
                {
                    var no = usrd.Brandname;
                    var UserList = dbcont.Brands.Where(x => x.Brandname == no).FirstOrDefault();
                    dbcont.Brands.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Brand Deleted";
                }
            }
            else
            {
                return "Invalid Brand";
            }
        }
        public ActionResult Items()
        {
            return View();
        }
        public JsonResult GetItemsInfo()
        {
            DbItems dbcont = new DbItems();
            List<Items> ListofUser = dbcont.Item.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        public JsonResult getItemCategorydetail()
        {
            DbItems dbcont = new DbItems();
            List<Category> ListofUser = dbcont.ItemCategory.ToList();
            return Json(ListofUser, JsonRequestBehavior.AllowGet);
        }
        public JsonResult getItemBranddetail()
        {
            DbItems dbcont = new DbItems();
            List<Brand> ListofUser = dbcont.ItemBrand.ToList();
            return Json(ListofUser, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public string InsertItems(Items usr1)
        {
            DbItems dbcont = new DbItems();
            var usr = new Items();

            usr.Image_Item = usr1.Image_Item;
            usr.Productname = usr1.Productname;
            usr.Unit = usr1.Unit;
            usr.Quantity = usr1.Quantity;
            usr.Categoryname = usr1.Categoryname;
            usr.Brandname = usr1.Brandname;
            usr.UPC = usr1.UPC;
            usr.MPN = usr1.MPN;
            usr.EAN = usr1.EAN;
            usr.SupplierID = usr1.SupplierID;
            usr.SellingPrice = usr1.SellingPrice;
            usr.PurchasePrice = usr1.PurchasePrice;
            


            dbcont.Item.Add(usr);
            dbcont.SaveChanges();

            return "Product Updated";

        }

        [HttpPost]
        public string UpdateItems(Items usr1)
        {

            if (usr1 != null)
            {
                using (DbItems dataContext = new DbItems())
                {
                    var no = usr1.ProductID;
                    var usr = dataContext.Item.Where(x => x.ProductID == no).FirstOrDefault();

                    usr.Image_Item = usr1.Image_Item;
                    usr.Productname = usr1.Productname;
                    usr.Unit = usr1.Unit;
                    usr.Quantity = usr1.Quantity;
                    usr.Categoryname = usr1.Categoryname;
                    usr.Brandname = usr1.Brandname;
                    usr.UPC = usr1.UPC;
                    usr.MPN = usr1.MPN;
                    usr.EAN = usr1.EAN;
                    usr.SupplierID = usr1.SupplierID;
                    usr.SellingPrice = usr1.SellingPrice;
                    usr.PurchasePrice = usr1.PurchasePrice;
                   
                    dataContext.SaveChanges();
                    return "Item Updated";
                }
            }
            else
            {
                return "Invalid Item";
            }
        }
        public string DeleteItems(Items usrd)
        {
            if (usrd != null)
            {
                using (DbItems dbcont = new DbItems())
                {
                    var no = usrd.ProductID;
                    var UserList = dbcont.Item.Where(x => x.ProductID == no).FirstOrDefault();
                    dbcont.Item.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Product Deleted";
                }
            }
            else
            {
                return "Invalid Product";
            }
        }

        public ActionResult Order()
        {
            return View();
        }
       
       

        public ActionResult CSO()
        {
            return View();
        }


        public JsonResult GetCSOInfo()
        {
            DbCSO dbcont = new DbCSO();
            List<CSO> ListofUser = dbcont.CSOS.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public string InsertCSO(CSO usr1)
        {
            DbCSO dbcont = new DbCSO();
            var usr = new CSO();

            usr.CustomerName = usr1.CustomerName;
            usr.Reference = usr1.Reference;
            usr.SalesOrderdate = usr1.SalesOrderdate;
            usr.ExpecShipDate = usr1.ExpecShipDate;
            usr.SalesPerson = usr1.SalesPerson;
            usr.DeliveryMethod = usr1.DeliveryMethod;
            usr.PaymentType = usr1.PaymentType;

            dbcont.CSOS.Add(usr);
            dbcont.SaveChanges();

            return "Sales Order Updated";

        }

        [HttpPost]
        public string UpdateCSO(CSO usr1)
        {

            if (usr1 != null)
            {
                using (DbCSO dataContext = new DbCSO())
                {
                    var no = usr1.SalesOrder;
                    var usr = dataContext.CSOS.Where(x => x.SalesOrder == no).FirstOrDefault();


                    usr.CustomerName = usr1.CustomerName;
                    usr.SalesOrder = usr1.SalesOrder;
                    usr.Reference = usr1.Reference;
                    usr.SalesOrderdate = usr1.SalesOrderdate;
                    usr.ExpecShipDate = usr1.ExpecShipDate;
                    usr.SalesPerson = usr1.SalesPerson;
                    usr.DeliveryMethod = usr1.DeliveryMethod;
                    usr.PaymentType = usr1.PaymentType;

                    dataContext.SaveChanges();
                    return "Sales Person Updated";
                }
            }
            else
            {
                return "Invalid Sales Order";
            }
        }
        public string DeleteCSO(CSO usrd)
        {
            if (usrd != null)
            {
                using (DbCSO dbcont = new DbCSO())
                {
                    var no = usrd.SalesOrder;
                    var UserList = dbcont.CSOS.Where(x => x.SalesOrder == no).FirstOrDefault();
                    dbcont.CSOS.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Sales Order Deleted";
                }
            }
            else
            {
                return "Invalid Sales Order";
            }
        }

        public ActionResult Newsale()
        {
            return View();
        }
        public JsonResult GetNewsaleInfo()
        {
            DbNewsale dbcont = new DbNewsale();
            List<Newsale> ListofUser = dbcont.nws.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertNewsale(Newsale usr1)
        {
            DbNewsale dbcont = new DbNewsale();
            var usr = new Newsale();

            usr.Itemdetails = usr1.Itemdetails;
            usr.Quantity = usr1.Quantity;
            usr.Price = usr1.Price;
            usr.Amount = usr1.Amount;
            usr.Tax = usr1.Tax;



            dbcont.nws.Add(usr);
            dbcont.SaveChanges();

            return "Sales Order Updated";

        }
        [HttpPost]
        public string UpdateNewsale(Newsale usr1)
        {

            if (usr1 != null)
            {
                using (DbNewsale dataContext = new DbNewsale())
                {
                    var no = usr1.Itemdetails;
                    var usr = dataContext.nws.Where(x => x.Itemdetails == no).FirstOrDefault();
                    usr.Itemdetails = usr1.Itemdetails;
                    usr.Quantity = usr1.Quantity;
                    usr.Price = usr1.Price;
                    usr.Amount = usr1.Amount;
                    usr.Tax = usr1.Tax;
                    dataContext.SaveChanges();
                    return "Item Updated";
                }
            }
            else
            {
                return "Invalid Item";
            }
        }
        public string DeleteNewsale(Newsale usrd)
        {
            if (usrd != null)
            {
                using (DbNewsale dbcont = new DbNewsale())
                {
                    var no = usrd.Itemdetails;
                    var UserList = dbcont.nws.Where(x => x.Itemdetails == no).FirstOrDefault();
                    dbcont.nws.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Item Deleted";
                }
            }
            else
            {
                return "Invalid Item";
            }
        }


        public ActionResult Billing()
        {
            return View();
        }


        public ActionResult PGS()
        {
            return View();
        }
        public ActionResult PO()
        {
            return View();
        }
        public ActionResult IS()
        {
            return View();
        }
        public ActionResult Bills()
        {
            return View();
        }
        public ActionResult IGS()
        {
            return View();
        }
        public ActionResult RPT()
        {
            return View();
        }
        
        
        public ActionResult ISO()
        {
            return View();
        }
        public ActionResult CPO()
        {
            return View();
        }
        public JsonResult GetpurchaseInfo()
        {
            Dbconnectioncpo dbcont = new Dbconnectioncpo();
            List<CPO> ListofUser = dbcont.cpos.ToList();
            return Json(ListofUser, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public string Insertcpo(CPO usr1)
        {
            Dbconnectioncpo dbcont = new Dbconnectioncpo();
            var usr = new CPO();
            usr.PurchaseOrder1 = usr1.PurchaseOrder1;
            usr.TraderName = usr1.TraderName;
            usr.Reference = usr1.Reference;
            usr.Purchasenbr = usr1.Purchasenbr;
            usr.Transdate = usr1.Transdate;
            usr.ExpctdDelDate = usr1.ExpctdDelDate;
            usr.ShipPref = usr1.ShipPref;


            dbcont.cpos.Add(usr);
            dbcont.SaveChanges();

            return "Sales Order Updated";

        }
        public JsonResult GetnewpurchaseInfo()
        {
            Dbneworder dbcont = new Dbneworder();
            List<addorder> ListofUser = dbcont.addorders.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string Insertaddorder(addorder grp1)
        {
            Dbneworder dbcont = new Dbneworder();
            var grp = new addorder();

            grp.itemdetail = grp1.itemdetail;
            grp.tax = grp1.tax;
            grp.quantity = grp1.quantity;
            grp.rate = grp1.rate;
            grp.amount = grp1.amount;


            dbcont.addorders.Add(grp);
            dbcont.SaveChanges();

            return "group Inserted";

        }
        [HttpPost]
        public string Updateaddorder(addorder usr1)
        {

            if (usr1 != null)
            {
                using (Dbneworder dataContext = new Dbneworder())
                {
                    var no = usr1.itemdetail;
                    var usr = dataContext.addorders.Where(x => x.itemdetail == no).FirstOrDefault();


                    usr.itemdetail = usr1.itemdetail;
                    usr.tax = usr1.tax;
                    usr.quantity = usr1.quantity;
                    usr.rate = usr1.rate;
                    usr.amount = usr1.amount;



                    dataContext.SaveChanges();
                    return "Sales Person Updated";
                }
            }
            else
            {
                return "Invalid Sales Order";
            }
        }
        public string Deleteaddorder(addorder usrd)
        {
            if (usrd != null)
            {
                using (Dbneworder dbcont = new Dbneworder())
                {
                    var no = usrd.itemdetail;
                    var UserList = dbcont.addorders.Where(x => x.itemdetail == no).FirstOrDefault();
                    dbcont.addorders.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Sales Order Deleted";
                }
            }
            else
            {
                return "Invalid Sales Order";
            }
        }

        public ActionResult addorder()
        {
            return View();
        }
        public ActionResult IPO()
        {
            return View();
        }
        public ActionResult CIS()
        {
            return View();
        }

        public JsonResult GetCISInfo()
        {
            DbCIS dbcont = new DbCIS();
            List<CIS> ListofUser = dbcont.CISe.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public string InsertCIS(CIS usr1)
        {
            DbCIS dbcont = new DbCIS();
            var usr = new CIS();

            usr.InvoiceNo = usr1.InvoiceNo;
            usr.InvoiceDate = usr1.InvoiceDate;
            usr.OrderNo = usr1.OrderNo;
            usr.Reference = usr1.Reference;
            usr.Paymentterms = usr1.Paymentterms;
            usr.Duedate = usr1.Duedate;
            usr.CustomerName = usr1.CustomerName;
            usr.ShipAddress = usr1.ShipAddress;


            dbcont.CISe.Add(usr);
            dbcont.SaveChanges();

            return "Sales Order Updated";

        }

        [HttpPost]
        public string UpdateCIS(CIS usr1)
        {

            if (usr1 != null)
            {
                using (DbCIS dataContext = new DbCIS())
                {
                    var no = usr1.OrderNo;
                    var usr = dataContext.CISe.Where(x => x.OrderNo == no).FirstOrDefault();


                    usr.InvoiceNo = usr1.InvoiceNo;
                    usr.InvoiceDate = usr1.InvoiceDate;
                    usr.OrderNo = usr1.OrderNo;
                    usr.Reference = usr1.Reference;
                    usr.Paymentterms = usr1.Paymentterms;
                    usr.Duedate = usr1.Duedate;
                    usr.CustomerName = usr1.CustomerName;
                    usr.ShipAddress = usr1.ShipAddress;

                    dataContext.SaveChanges();
                    return "Sales Person Updated";
                }
            }
            else
            {
                return "Invalid Sales Order";
            }
        }
        public string DeleteCIS(CIS usrd)
        {
            if (usrd != null)
            {
                using (DbCIS dbcont = new DbCIS())
                {
                    var no = usrd.OrderNo;
                    var UserList = dbcont.CISe.Where(x => x.OrderNo == no).FirstOrDefault();
                    dbcont.CISe.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Sales Order Deleted";
                }
            }
            else
            {
                return "Invalid Sales Order";
            }
        }
        public ActionResult IIS()
        {
            return View();
        }

        public ActionResult Invoice()
        {
            return View();
        }
        public JsonResult GetInvoiceInfo()
        {
            DbINV dbcont = new DbINV();
            List<Invoice> ListofUser = dbcont.Invoices.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertInvoice(Invoice usr1)
        {
            DbINV dbcont = new DbINV();
            var usr = new Invoice();

            usr.Itemdetails = usr1.Itemdetails;
            usr.Quantity = usr1.Quantity;
            usr.Price = usr1.Price;
            usr.Amount = usr1.Amount;
            usr.Tax = usr1.Tax;



            dbcont.Invoices.Add(usr);
            dbcont.SaveChanges();

            return "Sales Order Updated";

        }
        [HttpPost]
        public string UpdateInvoice(Invoice usr1)
        {

            if (usr1 != null)
            {
                using (DbINV dataContext = new DbINV())
                {
                    var no = usr1.Itemdetails;
                    var usr = dataContext.Invoices.Where(x => x.Itemdetails == no).FirstOrDefault();
                    usr.Itemdetails = usr1.Itemdetails;
                    usr.Quantity = usr1.Quantity;
                    usr.Price = usr1.Price;
                    usr.Amount = usr1.Amount;
                    usr.Tax = usr1.Tax;
                    dataContext.SaveChanges();
                    return "Item Updated";
                }
            }
            else
            {
                return "Invalid Item";
            }
        }
        public string DeleteInvoice(Invoice usrd)
        {
            if (usrd != null)
            {
                using (DbINV dbcont = new DbINV())
                {
                    var no = usrd.Itemdetails;
                    var UserList = dbcont.Invoices.Where(x => x.Itemdetails == no).FirstOrDefault();
                    dbcont.Invoices.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Item Deleted";
                }
            }
            else
            {
                return "Invalid Item";
            }
        }
        public ActionResult CB()
        {
            return View();
        }

        public JsonResult GetCBInfo()
        {
            DbCB1 dbcont = new DbCB1();
            List<CB> ListofUser = dbcont.CBS.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public string InsertCB(CB usr1)
        {
            DbCB1 dbcont = new DbCB1();
            var usr = new CB();

            usr.Name = usr1.Name;
            usr.BillNo = usr1.BillNo;
            usr.Billdate = usr1.Billdate;
            usr.Duedate = usr1.Duedate;


            dbcont.CBS.Add(usr);
            dbcont.SaveChanges();

            return "Sales Order Updated";

        }

        [HttpPost]
        public string UpdateCB(CB usr1)
        {

            if (usr1 != null)
            {
                using (DbCB1 dataContext = new DbCB1())
                {
                    var no = usr1.BillNo;
                    var usr = dataContext.CBS.Where(x => x.BillNo == no).FirstOrDefault();


                    usr.Name = usr1.Name;
                    usr.BillNo = usr1.BillNo;
                    usr.Billdate = usr1.Billdate;
                    usr.Duedate = usr1.Duedate;

                    dataContext.SaveChanges();
                    return "Sales Person Updated";
                }
            }
            else
            {
                return "Invalid Sales Order";
            }
        }
        public string DeleteCB(CB usrd)
        {
            if (usrd != null)
            {
                using (DbCB1 dbcont = new DbCB1())
                {
                    var no = usrd.BillNo;
                    var UserList = dbcont.CBS.Where(x => x.BillNo == no).FirstOrDefault();
                    dbcont.CBS.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Sales Order Deleted";
                }
            }
            else
            {
                return "Invalid Sales Order";
            }
        }

        public ActionResult NewBill()
        {
            return View();
        }
        public JsonResult GetNewBillInfo()
        {
            DbNewBill dbcont = new DbNewBill();
            List<NewBill> ListofUser = dbcont.NewBills.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertNewBill(NewBill usr1)
        {
            DbNewBill dbcont = new DbNewBill();
            var usr = new NewBill();

            usr.Itemdetails = usr1.Itemdetails;
            usr.Quantity = usr1.Quantity;
            usr.Price = usr1.Price;
            usr.Amount = usr1.Amount;
            usr.Tax = usr1.Tax;



            dbcont.NewBills.Add(usr);
            dbcont.SaveChanges();

            return "Sales Order Updated";

        }
        [HttpPost]
        public string UpdateNewBill(NewBill usr1)
        {

            if (usr1 != null)
            {
                using (DbNewBill dataContext = new DbNewBill())
                {
                    var no = usr1.Itemdetails;
                    var usr = dataContext.NewBills.Where(x => x.Itemdetails == no).FirstOrDefault();
                    usr.Itemdetails = usr1.Itemdetails;
                    usr.Quantity = usr1.Quantity;
                    usr.Price = usr1.Price;
                    usr.Amount = usr1.Amount;
                    usr.Tax = usr1.Tax;
                    dataContext.SaveChanges();
                    return "Item Updated";
                }
            }
            else
            {
                return "Invalid Item";
            }
        }
        public string DeleteNewBill(NewBill usrd)
        {
            if (usrd != null)
            {
                using (DbNewBill dbcont = new DbNewBill())
                {
                    var no = usrd.Itemdetails;
                    var UserList = dbcont.NewBills.Where(x => x.Itemdetails == no).FirstOrDefault();
                    dbcont.NewBills.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Item Deleted";
                }
            }
            else
            {
                return "Invalid Item";
            }
        }

        public ActionResult IB()
        {
            return View();
        }
        public ActionResult Stock()
        {
            return View();
        }
        public ActionResult WHP()
        {
            return View();
        }

        
        public JsonResult getwarehousedetail()
        {
            DbWarehouse dbcont = new DbWarehouse();
            List<Warehouse> ListofUser = dbcont.WHS.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertWarehouse(Warehouse usr1)
        {
            DbWarehouse dbcont = new DbWarehouse();
            var usr = new Warehouse();

            usr.Warehouseno = usr1.Warehouseno;
            usr.Warehousename = usr1.Warehousename;
            usr.Warehouseloc = usr1.Warehouseloc;

            dbcont.WHS.Add(usr);
            dbcont.SaveChanges();

            return "Warehouse Inserted";

        }

        [HttpPost]
        public string UpdateWarehouse(Warehouse usr1)
        {

            if (usr1 != null)
            {
                using (DbWarehouse dataContext = new DbWarehouse())
                {
                    var no = usr1.Warehouseno;
                    var usr = dataContext.WHS.Where(x => x.Warehouseno == no).FirstOrDefault();


                    usr.Warehousename = usr1.Warehousename;
                    usr.Warehouseloc = usr1.Warehouseloc;
                    
                    dataContext.SaveChanges();
                    return "Warehouse Updated";
                }
            }
            else
            {
                return "Invalid Warehouse";
            }
        }
        public string DeleteWarehouse(Warehouse usrd)
        {
            if (usrd != null)
            {
                using (DbWarehouse dbcont = new DbWarehouse())
                {
                    var no = usrd.Warehouseno;
                    var UserList = dbcont.WHS.Where(x => x.Warehouseno == no).FirstOrDefault();
                    dbcont.WHS.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Warehouse Deleted";
                }
            }
            else
            {
                return "Invalid Warehouse";
            }
        }

        public JsonResult getstoredetail()
        {
            DbStore dbcont = new DbStore();
            List<Store> ListofUser = dbcont.Stores.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertStore(Store usr1)
        {
            DbStore dbcont = new DbStore();
            var usr = new Store();

            usr.Warehouseno = usr1.Warehouseno;
            usr.Storeno = usr1.Storeno;
            usr.Storename = usr1.Storename;
            usr.Rows = usr1.Rows;
            usr.Cols = usr1.Cols;
            usr.Storedesc = usr1.Storedesc;

            dbcont.Stores.Add(usr);
            dbcont.SaveChanges();

            return "Store Inserted";

        }

        public JsonResult getRackdetail()
        {
            DbRack dbcont = new DbRack();
            List<Rack> ListofUser = dbcont.Racks.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertRack(Rack usr1)
        {
            DbRack dbcont = new DbRack();
            var usr = new Rack();

            usr.Warehouseno = usr1.Warehouseno;
            usr.Storeno = usr1.Storeno;
            usr.Rackno = usr1.Rackno;
            usr.Rackname = usr1.Rackname;
            usr.RRows = usr1.RRows;
            usr.Rackdesc = usr1.Rackdesc;

            dbcont.Racks.Add(usr);
            dbcont.SaveChanges();

            return "Rack Inserted";

        }
        public JsonResult getRowdetail()
        {
            DbRow dbcont = new DbRow();
            List<Row> ListofUser = dbcont.Rows.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string InsertRow(Row usr1)
        {
            DbRow dbcont = new DbRow();
            var usr = new Row();

            usr.Warehouseno = usr1.Warehouseno;
            usr.Storeno = usr1.Storeno;
            usr.Rackno = usr1.Rackno;
            usr.Rowno = usr1.Rowno;
            usr.Rowname = usr1.Rowname;
            usr.Rowdesc = usr1.Rowdesc;

            dbcont.Rows.Add(usr);
            dbcont.SaveChanges();

            return "Row Inserted";

        }
        public ActionResult SP()
        {
            return View();
        }

        public JsonResult GetStockInfo()
        {
            DbStock dbcont = new DbStock();
            List<Stock> ListofUser = dbcont.Stocks.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public string InsertStock(Stock usr1)
        {
            DbStock dbcont = new DbStock();
            var usr = new Stock();

            usr.Warehouseno = usr1.Warehouseno;
            usr.Storeno = usr1.Storeno;
            usr.Rackno = usr1.Rackno;
            usr.Rowno = usr1.Rowno;
            usr.ProductID = usr1.ProductID;
            usr.Productname = usr1.Productname;
            usr.Quantity = usr1.Quantity;
            usr.Unit = usr1.Unit;
            usr.Price = usr1.Price;
            usr.SupplierID = usr1.SupplierID;




            dbcont.Stocks.Add(usr);
            dbcont.SaveChanges();

            return "Stock Added";

        }

        [HttpPost]
        public string UpdateStock(Stock usr1)
        {

            if (usr1 != null)
            {
                using (DbStock dataContext = new DbStock())
                {
                    var no = usr1.Warehouseno;
                    var usr = dataContext.Stocks.Where(x => x.Warehouseno == no).FirstOrDefault();
                    usr.Storeno = usr1.Storeno;
                    usr.Rackno = usr1.Rackno;
                    usr.Rowno = usr1.Rowno;
                    usr.ProductID = usr1.ProductID;
                    usr.Productname = usr1.Productname;
                    usr.Quantity = usr1.Quantity;
                    usr.Unit = usr1.Unit;
                    usr.Price = usr1.Price;
                    usr.SupplierID = usr1.SupplierID;



                    dataContext.SaveChanges();
                    return "Stock Updated";
                }
            }
            else
            {
                return "Invalid Stock";
            }
        }
        public string DeleteStock(Stock usrd)
        {
            if (usrd != null)
            {
                using (DbStock dbcont = new DbStock())
                {
                    var no = usrd.Warehouseno;
                    var UserList = dbcont.Stocks.Where(x => x.Warehouseno == no).FirstOrDefault();
                    dbcont.Stocks.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Stock Deleted";
                }
            }
            else
            {
                return "Invalid Stock";
            }
        }
        public ActionResult SS()
        {
            return View();
        }

        public JsonResult GetStockrelInfo()
        {
            DbStockRel dbcont = new DbStockRel();
            List<SS> ListofUser = dbcont.StockRels.ToList();


            return Json(ListofUser, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public string InsertStockrel(SS usr1)
        {
            DbStockRel dbcont = new DbStockRel();
            var usr = new SS();

            usr.Warehouseno = usr1.Warehouseno;
            usr.Storeno = usr1.Storeno;
            usr.Rackno = usr1.Rackno;
            usr.Rowno = usr1.Rowno;
            usr.ProductID = usr1.ProductID;
            usr.Productname = usr1.Productname;
            usr.Quantity = usr1.Quantity;
            usr.Unit = usr1.Unit;
            usr.Price = usr1.Price;
            usr.CustomerID = usr1.CustomerID;




            dbcont.StockRels.Add(usr);
            dbcont.SaveChanges();

            return "Stock Added";

        }

        [HttpPost]
        public string UpdateStockRel(SS usr1)
        {

            if (usr1 != null)
            {
                using (DbStockRel dataContext = new DbStockRel())
                {
                    var no = usr1.Warehouseno;
                    var usr = dataContext.StockRels.Where(x => x.Warehouseno == no).FirstOrDefault();
                    usr.Storeno = usr1.Storeno;
                    usr.Rackno = usr1.Rackno;
                    usr.Rowno = usr1.Rowno;
                    usr.ProductID = usr1.ProductID;
                    usr.Productname = usr1.Productname;
                    usr.Quantity = usr1.Quantity;
                    usr.Unit = usr1.Unit;
                    usr.Price = usr1.Price;
                    usr.CustomerID = usr1.CustomerID;



                    dataContext.SaveChanges();
                    return "Stock Updated";
                }
            }
            else
            {
                return "Invalid Stock";
            }
        }
        public string DeleteStockrel(SS usrd)
        {
            if (usrd != null)
            {
                using (DbStockRel dbcont = new DbStockRel())
                {
                    var no = usrd.Warehouseno;
                    var UserList = dbcont.StockRels.Where(x => x.Warehouseno == no).FirstOrDefault();
                    dbcont.StockRels.Remove(UserList);
                    dbcont.SaveChanges();
                    return "Stock Deleted";
                }
            }
            else
            {
                return "Invalid Stock";
            }
        }


        public ActionResult NewVendor()
        {
            return View();
        }
        public ActionResult Shippedpackages()
        {
            return View();
        }
        public ActionResult NSP()
        {
            return View();
        }
        public ActionResult DP()
        {
            return View();
        }
        public ActionResult NDP()
        {
            return View();
        }
        public ActionResult Sss()
        {
            return View();
        }



    }
}



