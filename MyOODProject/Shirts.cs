using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

using EntityFramework;

namespace MyOODProject
{
    public abstract class Shirts : IComparable
    {
        //properties
        public int ShirtsID { get; set; }
        public string ShirtNames {  get; set; }
        public string Info { get; set; }
        public int YearFormed { get; set; }
        public  List<Price> Prices{ get; set; }


        //constructors
        public Shirts(string shirtNames, string info, int yearFormed)
        {
            ShirtNames = shirtNames;
            Info = info;

            
            YearFormed = yearFormed;
        }
        public Shirts() 
        {
            
        }

        //methods
        public override string ToString()
        {
            return ShirtNames;
        }

        public int CompareTo(object obj)
        {
            Shirts othershirts = obj as Shirts;
            return this.ShirtNames.CompareTo(othershirts.ShirtNames);
        }
    }

    public class Connachta : Shirts
    {
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
    public class Munster : Shirts
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class Leinster : Shirts
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class ShirtsData : DbContext
    {
        public ShirtsData()
        {
            public DBSet<Price> {get; set;}

        }
    }
}

