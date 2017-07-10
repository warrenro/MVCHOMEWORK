using System.Collections.Generic;
using Dapper;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using WebApplication9.Models.ViewModel;
using System;

namespace WebApplication9.Service
{
    public class UtilMethod
    {
       

        //public List<SelectListItem> CategoryList()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();

        //    var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                
                  
        //    var query = conn.Query("select Categoryyy from AccountBook").AsList();
        //    conn.Close();
                 

        //    foreach
        //    (var listData in query)
        //    {list.Add(new SelectListItem
        //        { Text = listData.Categoryyy.ToString(),
        //          Value = listData.Categoryyy.ToString()
        //    });
        //    }
        //    return list;

        //}

        public List<DataViewModel> grid()
        {
            

            var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);


            var query = conn.Query("select * from AccountBook").AsList();
            conn.Close();

            var list = new List<DataViewModel>();
            string category = "";

            foreach (var listData in query)
            {
                if (listData.Categoryyy == 1)
                { category = "支出"; }
                else
                { category = "收入"; }

                list.Add(new DataViewModel
                {
                    ID = listData.Id.ToString(),
                    Category = category,
                    InputDate = listData.Dateee,
                    Money = listData.Amounttt,
                    Message = listData.Remarkkk.ToString(),
                    
                });
            }
            return list;

           



            
        }

        
    }
}

