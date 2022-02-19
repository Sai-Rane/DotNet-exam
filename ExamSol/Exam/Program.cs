using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        public ActionResult Index()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString= @"Data Sorce=(localdb)\MSSQLLocalDb;"
            cn.Open();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "select * from Product";
            List<ProductCrud> crd = new List<ProductCrud>();
            try
            {
                SqlDataReader dr = cmdInsert.ExecuteReader();
                while (dr.Read())
                {
                    crd.Add(new ProductCrud { ProductId = (int)dr["ProductId "], ProductName= })
                }
                dr.Close();

            }

            catch (Exception ed)
            {
                Console.WriteLine(ed.Message);

            }
            finally 
            {
                cn.Close();
            }
            return View(crd);
        }
    }
}
