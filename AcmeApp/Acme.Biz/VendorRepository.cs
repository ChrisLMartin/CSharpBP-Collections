﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;
        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public T RetrieveValue<T>(string sql, T defaultValue) // where T : struct
        {
            // Call the database to retrieve the value
            // If no value is returned, return the default value
            T value = defaultValue;

            return value;
        }


        // Overload required due to generic constraint limitations
        //public string RetreiveValue<T>(string sql, string defaultValue)
        //{
        //    // Call the database to retrieve the value
        //    // If no value is returned, return the default value
        //    string value = defaultValue;

        //    return value;
        //}

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }

        //public Vendor[] RetrieveArray()
        //{
        //    var vendors = new Vendor[2]
        //    {
        //        new Vendor()
        //            { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" },
        //        new Vendor()
        //            { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" },
        //    };

        //    return vendors;
        //}

            // IEnumerable prevents addition or removal of elements from collection
            // while allowing iteration (could use ReadOnly collection)
        public IEnumerable<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor()
                    { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                vendors.Add(new Vendor()
                    { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            }

            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);
            }

            

            //foreach (var vendor in vendors)
            //{
            //    Console.WriteLine(vendor);
            //}
            

            return vendors;
        }

        public IEnumerable<Vendor> RetrieveAll()
        {
            var vendors = new List<Vendor>()
                {
                    { new Vendor()
                        { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" } },
                    { new Vendor()
                        { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" } },
                    { new Vendor()
                        { VendorId = 12, CompanyName = "EFG Ltd", Email = "efg@efg.com" } },
                    { new Vendor()
                        { VendorId = 17, CompanyName = "HIJ AG", Email = "hij@hij.com" } },
                    { new Vendor()
                        { VendorId = 22, CompanyName = "Almagamated Toys", Email = "a@abc.com" } },
                    { new Vendor()
                        { VendorId = 28, CompanyName = "Toy Blocks Inc", Email = "blocks@abc.com" } },
                    { new Vendor()
                        { VendorId = 31, CompanyName = "Home Products Inc", Email = "home@abc.com" } },
                    { new Vendor()
                        { VendorId = 35, CompanyName = "Car Toys", Email = "car@abc.com" } },
                    { new Vendor()
                        { VendorId = 42, CompanyName = "Toys for Fun", Email = "fun@abc.com" } }
                };
            return vendors;
        }

        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            // Get the data from the database
            this.Retrieve();

            foreach (var vendor in vendors)
            {
                Console.WriteLine($"Vendor Id: {vendor.VendorId}");
                yield return vendor;
            }
        }

        //public Dictionary<string, Vendor> RetrieveWithKeys()
        //{
        //    var vendors = new Dictionary<string, Vendor>()
        //    {
        //        { "ABC Corp", new Vendor()
        //            { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" } },
        //        { "XYZ Inc",  new Vendor()
        //            { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" } },
        //    };

        //    foreach (var element in vendors)
        //    {
        //        var vendor = element.Value;
        //        var key = element.Key;
        //        Console.WriteLine($"Key: {key} Value: {vendor}");
        //    }

            //foreach (var vendor in vendors.Values)
            //{
            //    Console.WriteLine(vendor);
            //}

            //foreach (var companyName in vendors.Keys)
            //{
            //    Console.WriteLine(vendors[companyName]);
            //}

            ////Checks key twice - slower
            //if (vendors.ContainsKey("XYZ"))
            //{
            //    Console.WriteLine(vendors["XYZ"]);
            //}

            ////Checks key once - faster
            //Vendor vendor;
            //if (vendors.TryGetValue("XYZ", out vendor))
            //{
            //    Console.WriteLine(vendor);
            //}

        //    return vendors;
        //}
    }
}
