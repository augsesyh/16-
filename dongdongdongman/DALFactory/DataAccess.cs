﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using Models;
using IDAL;

namespace DALFactory
{
    public class DataAccess
    {
        private static readonly string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static readonly string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
         }
        public static IUser_detail CreateUser_detail()
        {
            string className = AssemblyName + "." + db + "User_detail";
            return (IUser_detail)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IComic CreateComic()
        {
            string className = AssemblyName + "." + db + "Comic";
            return (IComic)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVideo CreateVideo()
        {
            string className = AssemblyName + "." + db + "Video";
            return (IVideo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IGoods CreateGoods()
        {
            string className = AssemblyName + "." + db + "Goods";
            return (IGoods)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ISubscribe CreateSubscribe()
        {
            string className = AssemblyName + "." + db + "Subscribe";
            return (ISubscribe)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IComic_chapter CreateComic_chapter()
        {
            string className = AssemblyName + "." + db + "Comic_chapter";
            return (IComic_chapter)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IComic_pager CreateComic_pager()
        {
            string className = AssemblyName + "." + db + "Comic_pager";
            return (IComic_pager)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAdmin CreateAdmin()
        {
            string className = AssemblyName + "." + db + "admin";
            return (IAdmin)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IReport CreateReport()
        {
            string className = AssemblyName + "." + db + "Report";
            return (IReport)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IGood_Cate CreateGood_Cate()
        {
            string className = AssemblyName + "." + db + "Good_Cate";
            return (IGood_Cate)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IGoods_Assess CreateGoods_Assess()
        {
            string className = AssemblyName + "." + db + "Goods_Assess";
            return (IGoods_Assess)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IFollow CreateFollow()
        {
            string className = AssemblyName + "." + db + "Follow";
            return (IFollow)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IComment CreateComment()
        {
            string className = AssemblyName + "." + db + "Comment";
            return (IComment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAddress CreateAddress()
        {
            string className = AssemblyName + "." + db + "Address";
            return (IAddress)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IShoppingCart CreateShoppingCart()
        {
            string className = AssemblyName + "." + db + "ShoppingCart";
            return (IShoppingCart)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ICollection CreateCollection()
        {
            string className = AssemblyName + "." + db + "Collection";
            return (ICollection)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
