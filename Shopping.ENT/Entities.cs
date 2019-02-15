using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.ENT
{
    public class Entities
    {
        public class Categories
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Categories()
            {
                this.Products = new HashSet<Products>();
            }

            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }
            public byte[] Picture { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Products> Products { get; set; }
        }
        public class Products
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Products()
            {
                this.Order_Details = new HashSet<Order_Details>();
            }

            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public Nullable<int> SupplierID { get; set; }
            public Nullable<int> CategoryID { get; set; }
            public string QuantityPerUnit { get; set; }
            public Nullable<decimal> UnitPrice { get; set; }
            public Nullable<short> UnitsInStock { get; set; }
            public Nullable<short> UnitsOnOrder { get; set; }
            public Nullable<short> ReorderLevel { get; set; }
            public bool Discontinued { get; set; }

            public virtual Categories Categories { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Order_Details> Order_Details { get; set; }
            public virtual Suppliers Suppliers { get; set; }
        }
        public class Suppliers
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Suppliers()
            {
                this.Products = new HashSet<Products>();
            }

            public int SupplierID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }
            public string HomePage { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Products> Products { get; set; }
        }
        public class Order_Details
        {
            public int OrderID { get; set; }
            public int ProductID { get; set; }
            public decimal UnitPrice { get; set; }
            public short Quantity { get; set; }
            public float Discount { get; set; }

            public virtual Orders Orders { get; set; }
            public virtual Products Products { get; set; }
        }
        public class CustomerDemographics
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public CustomerDemographics()
            {
                this.Customers = new HashSet<Customers>();
            }

            public string CustomerTypeID { get; set; }
            public string CustomerDesc { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Customers> Customers { get; set; }
        }
        public class Customers
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Customers()
            {
                this.Orders = new HashSet<Orders>();
                this.CustomerDemographics = new HashSet<CustomerDemographics>();
            }

            public string CustomerID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Fax { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Orders> Orders { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<CustomerDemographics> CustomerDemographics { get; set; }
        }
        public class Employees
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Employees()
            {
                this.Employees1 = new HashSet<Employees>();
                this.Orders = new HashSet<Orders>();
                this.Territories = new HashSet<Territories>();
            }

            public int EmployeeID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Title { get; set; }
            public string TitleOfCourtesy { get; set; }
            public Nullable<System.DateTime> BirthDate { get; set; }
            public Nullable<System.DateTime> HireDate { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Region { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
            public string HomePhone { get; set; }
            public string Extension { get; set; }
            public byte[] Photo { get; set; }
            public string Notes { get; set; }
            public Nullable<int> ReportsTo { get; set; }
            public string PhotoPath { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Employees> Employees1 { get; set; }
            public virtual Employees Employees2 { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Orders> Orders { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Territories> Territories { get; set; }
        }
        public class Orders
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Orders()
            {
                this.Order_Details = new HashSet<Order_Details>();
            }

            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public Nullable<int> EmployeeID { get; set; }
            public Nullable<System.DateTime> OrderDate { get; set; }
            public Nullable<System.DateTime> RequiredDate { get; set; }
            public Nullable<System.DateTime> ShippedDate { get; set; }
            public Nullable<int> ShipVia { get; set; }
            public Nullable<decimal> Freight { get; set; }
            public string ShipName { get; set; }
            public string ShipAddress { get; set; }
            public string ShipCity { get; set; }
            public string ShipRegion { get; set; }
            public string ShipPostalCode { get; set; }
            public string ShipCountry { get; set; }

            public virtual Customers Customers { get; set; }
            public virtual Employees Employees { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Order_Details> Order_Details { get; set; }
            public virtual Shippers Shippers { get; set; }
        }
        public class Region
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Region()
            {
                this.Territories = new HashSet<Territories>();
            }

            public int RegionID { get; set; }
            public string RegionDescription { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Territories> Territories { get; set; }
        }
        public class Shippers
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Shippers()
            {
                this.Orders = new HashSet<Orders>();
            }

            public int ShipperID { get; set; }
            public string CompanyName { get; set; }
            public string Phone { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Orders> Orders { get; set; }
        }
        public class Territories
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Territories()
            {
                this.Employees = new HashSet<Employees>();
            }

            public string TerritoryID { get; set; }
            public string TerritoryDescription { get; set; }
            public int RegionID { get; set; }

            public virtual Region Region { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<Employees> Employees { get; set; }
        }
        public class Users
        {
            public string UserID { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }
    }
}
