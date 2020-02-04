using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPMBA.Models
{
    public class DbSupplier : DbContext
    {
        public DbSupplier() : base("Dbconns") { }
        public DbSet<Supplier> Suppliers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<Supplier>().HasKey(x => x.SupplierID);

        }
    }


    public class DbconnectionSettingsChild : DbContext
    {
        public DbconnectionSettingsChild() : base("Dbconns") { }
        public DbSet<MenuChild> ChildMenuApp { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuChild>().ToTable("MenuChild");
            modelBuilder.Entity<MenuChild>().HasKey(x => x.ChildMenuId);

        }
    }



    public class DbconnectionLogin : DbContext
    {
        public DbconnectionLogin() : base("Dbconns") { }

        public DbSet<Userclass> Userclassses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Userclass>().ToTable("UserInf");
            modelBuilder.Entity<Userclass>().HasKey(x => x.userid);

        }

    }


    public class DbconnectionSettings : DbContext
    {
        public DbconnectionSettings() : base("Dbconns") { }
        public DbSet<MenuClass> MenuApp { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuClass>().ToTable("MenuClass");
            modelBuilder.Entity<MenuClass>().HasKey(x => x.MenuId);

        }
    }



    public class DbconnectionRole : DbContext
    {
        public DbconnectionRole() : base("Dbconns") { }
        public DbSet<Role> RoleClass { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<Role>().HasKey(x => x.RoleId);

        }
    }


    public class DbconnectionGrant : DbContext
    {
        public DbconnectionGrant() : base("Dbconns") { }
        public DbSet<Grants> Grants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grants>().ToTable("Grants");
            modelBuilder.Entity<Grants>().HasKey(x => x.Userid);

        }
    }

    public class DbCustomer : DbContext
    {
        public DbCustomer() : base("Dbconns") { }
        public DbSet<NewCustomer> NewCustomers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewCustomer>().ToTable("NewCustomer");
            modelBuilder.Entity<NewCustomer>().HasKey(x => x.CustomerID);

        }
    }

    public class DbSalesperson : DbContext
    {
        public DbSalesperson() : base("Dbconns") { }
        public DbSet<Salesperson> Salespersons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salesperson>().ToTable("Salesperson");
            modelBuilder.Entity<Salesperson>().HasKey(x => x.Sellerid);

        }
    }
    

    public class DbCategory : DbContext
    {
        public DbCategory() : base("Dbconns") { }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().HasKey(x => x.Categoryname);

        }
    }

    public class DbBrand : DbContext
    {
        public DbBrand() : base("Dbconns") { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> BrandCategory { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Brand>().HasKey(x => x.Brandname);
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().HasKey(x => x.Categoryname);

        }
    }

    public class DbItems : DbContext
    {
        public DbItems() : base("Dbconns") { }
        public DbSet<Items> Item { get; set; }
        public DbSet<Category> ItemCategory { get; set; }
        public DbSet<Brand> ItemBrand { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>().ToTable("Items");
            modelBuilder.Entity<Items>().HasKey(x => x.ProductID);
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Category>().HasKey(x => x.Categoryname);
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Brand>().HasKey(x => x.Brandname);
        }
    }

    public class DbCSO : DbContext
    {
        public DbCSO() : base("Dbconns") { }

        public DbSet<CSO> CSOS { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<CSO>().ToTable("CSO");
            modelBuilder.Entity<CSO>().HasKey(x => x.SalesOrder);
        }
    }

    public class Dbconnectioncpo : DbContext
    {
        public Dbconnectioncpo() : base("Dbconns") { }

        public DbSet<CPO> cpos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CPO>().ToTable("CPO");
            modelBuilder.Entity<CPO>().HasKey(x => x.PurchaseOrder1);
        }
    }

    public class Dbneworder : DbContext
    {
        public Dbneworder() : base("Dbconns") { }

        public DbSet<addorder> addorders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<addorder>().ToTable("addorder");
            modelBuilder.Entity<addorder>().HasKey(x => x.itemdetail);
        }
    }

    public class DbNewsale : DbContext
    {
        public DbNewsale() : base("Dbconns") { }

        public DbSet<Newsale> nws { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Newsale>().ToTable("Newsale");
            modelBuilder.Entity<Newsale>().HasKey(x => x.Itemdetails);
        }
    }
    public class DbCB1 : DbContext
    {
        public DbCB1() : base("Dbconns") { }

        public DbSet<CB> CBS { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<CB>().ToTable("CB");
            modelBuilder.Entity<CB>().HasKey(x => x.BillNo);
        }
    }
    public class DbNewBill : DbContext
    {
        public DbNewBill() : base("Dbconns") { }

        public DbSet<NewBill> NewBills { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewBill>().ToTable("NewBill");
            modelBuilder.Entity<NewBill>().HasKey(x => x.Itemdetails);
        }
    }
    public class DbCIS : DbContext
    {
        public DbCIS() : base("Dbconns") { }

        public DbSet<CIS> CISe { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CIS>().ToTable("CIS");
            modelBuilder.Entity<CIS>().HasKey(x => x.OrderNo);
        }
    }
    public class DbINV : DbContext
    {
        public DbINV() : base("Dbconns") { }

        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().ToTable("Invoice");
            modelBuilder.Entity<Invoice>().HasKey(x => x.Itemdetails);
        }
    }
    public class DbWarehouse : DbContext
    {
        public DbWarehouse() : base("Dbconns") { }
        public DbSet<Warehouse> WHS { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>().ToTable("Warehouse");
            modelBuilder.Entity<Warehouse>().HasKey(x => x.Warehouseno);

        }
    }

    public class DbStore : DbContext
    {
        public DbStore() : base("Dbconns") { }
        public DbSet<Store> Stores { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>().ToTable("Store");
            modelBuilder.Entity<Store>().HasKey(x => x.Storeno);

        }
    }

    public class DbRack : DbContext
    {
        public DbRack() : base("Dbconns") { }
        public DbSet<Rack> Racks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rack>().ToTable("Rack");
            modelBuilder.Entity<Rack>().HasKey(x => x.Rackno);

        }
    }
    public class DbRow : DbContext
    {
        public DbRow() : base("Dbconns") { }
        public DbSet<Row> Rows { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Row>().ToTable("Row");
            modelBuilder.Entity<Row>().HasKey(x => x.Rowno);

        }
    }

    public class DbStock : DbContext
    {
        public DbStock() : base("Dbconns") { }
        public DbSet<Stock> Stocks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>().ToTable("Stock");
            modelBuilder.Entity<Stock>().HasKey(x => x.Warehouseno);

        }
    }

    public class DbStockRel : DbContext
    {
        public DbStockRel() : base("Dbconns") { }
        public DbSet<SS> StockRels { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SS>().ToTable("StockRelease");
            modelBuilder.Entity<SS>().HasKey(x => x.Warehouseno);

        }
    }


}







