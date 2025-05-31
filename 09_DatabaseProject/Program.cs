using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secim;

            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Görmek istediğiniz tablo numarasını yazınız: ");
            secim = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MHCSA80\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TblCategory", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sqlConnection.Close();

            foreach (DataRow row in dataTable.Rows) 
            {
                foreach (var item in row.ItemArray) 
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}
