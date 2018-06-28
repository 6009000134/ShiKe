using System;
using System.Collections.Generic;
using System.Text;
using ConsoleClient.Virtual;
using ConsoleClient.Factory;
using System.Web;
using System.Data;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory
            DBFactory f = new DBFactory();
            Console.WriteLine(f.GetCarName("Suv"));
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("d");
            dt.Columns.Add(dc);
            for (int i = 0; i < 1000; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = "DataDataDataDataDataDataDataDataDataDataDataDataDataDataDataDataDataDataDataData";
                dt.Rows.Add(dr);
            }
            System.Web.Caching.Cache ca = HttpRuntime.Cache;

            ca.Insert("aa", f);
            ca.Insert("aaa", dt);

            DataTable dt2 = (DataTable)ca["aaa"];
            #endregion
            #region Virtual And Abstract
            //ParentVirtual pv = new ParentVirtual();
            //Console.WriteLine("ParentVirtual:");
            //Console.WriteLine("Factory:"+pv.Factory());
            //Console.WriteLine("FactoryVirtual:" + pv.FactoryVirtual());
            //Children c = new Children();
            //Console.WriteLine("Children:");
            //Console.WriteLine("Factory:" + c.Factory());
            //Console.WriteLine("FactoryVirtual:" + c.FactoryVirtual());
            //Console.WriteLine("数据库:");
            //Console.WriteLine(EnumObject.SqlServer.ToString()+":"+(int)EnumObject.SqlServer);
            //Console.WriteLine(EnumObject.Oracle.ToString()+ ":" + (int)EnumObject.Oracle);
            //Console.WriteLine(EnumObject.MySql.ToString()+ ":" + (int)EnumObject.MySql);
            #endregion


            Console.ReadLine();
        }
    }
}
