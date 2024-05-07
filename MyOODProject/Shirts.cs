using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

//using EntityFramework;

namespace MyOODProject
{
    public /*abstract*/class Shirts //: IComparable
    {
        //properties
        public int ShirtsID { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int YearFormed { get; set; }

        public virtual List<Price> Prices { get; set; }
        public Shirts()
        {
            Price price = new Price();
        }

    }

    public class Price
    {
        public int PriceID { get; set; }
        public int TotalAmount { get; set; }

        public int ShirtsID { get; set; }
        public virtual Shirts Shirts { get; set; }

       
    }





    public class MyDataBase : DbContext
    {
        public MyDataBase()
        {
        }

        public MyDataBase(string databaseName) : base(databaseName){ }
        public DbSet<Shirts> Shirts {  set; get; }
        public DbSet<Price> Prices { set; get; }

        
    }



    //    //constructors
    //    public Shirts(string shirtNames, string info, int yearFormed)
    //    {
    //        ShirtNames = shirtNames;
    //        Info = info;

            
    //        YearFormed = yearFormed;
    //    }
    //    public Shirts() 
    //    {
            
    //    }

    //    //methods
    //    public override string ToString()
    //    {
    //        return ShirtNames;
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        Shirts othershirts = obj as Shirts;
    //        return this.ShirtNames.CompareTo(othershirts.ShirtNames);
    //    }
    //}

    //public class Connachta : Shirts
    //{
    //    public override string ToString()
    //    {
    //        return base.ToString(); 
    //    }
    //}
    //public class Munster : Shirts
    //{
    //    public override string ToString()
    //    {
    //        return base.ToString();
    //    }
    //}
    //public class Leinster : Shirts
    //{
    //    public override string ToString()
    //    {
    //        return base.ToString();
    //    }
    //}




    //public class ShirtsData : DbContext
    //{
    //    public ShirtsData() { }
        
    //    public DBSet<Price> Price { get; set; }


    //}

}


