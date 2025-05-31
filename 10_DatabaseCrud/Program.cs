using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-MHCSA80\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            #region kategori ekleme


            //Console.WriteLine("Kaydetmek istediğiniz kategori adını giriniz: ");
            //string kategoriAd= Console.ReadLine();

            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",sqlConnection);
            //cmd.Parameters.AddWithValue("@p1",kategoriAd);
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Kategori ekleme işlemi gerçekleşmiştir");
            #endregion

            #region Ürün Listeleme
            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM TblProduct",sqlConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows) 
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //sqlConnection.Close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.WriteLine("Silinecek Ürünün Idsini Giriniz:");
            //int silinecekId = int.Parse(Console.ReadLine());

            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("delete from TblProduct Where ProductId=@p1",sqlConnection);
            //cmd.Parameters.AddWithValue("@p1", silinecekId);
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();
            //Console.WriteLine("Silme İşlemi Gerçekleştirildi.");
            #endregion

            #region Ürün Güncelleme İşlemi
            //Console.WriteLine("Güncellenecek Ürünün Idsini Giriniz:");
            //int productId = int.Parse(Console.ReadLine());

            //Console.WriteLine("Güncellenecek Ürünün Yeni Adını Giriniz:");
            //string productName = Console.ReadLine();

            //Console.WriteLine("Güncellenecek Ürünün Yeni Fiyatını Giriniz:");
            //double productPrice = double.Parse(Console.ReadLine());

            //sqlConnection.Open();
            //SqlCommand cmd = new SqlCommand("update TblProduct set ProductName=@p1 , ProductPrice=@p2 where ProductId=@p3",sqlConnection);
            //cmd.Parameters.AddWithValue("@p1",productName);
            //cmd.Parameters.AddWithValue("@p2", productPrice);
            //cmd.Parameters.AddWithValue("@p3", productId);
            //cmd.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Güncelleme İşlemi Gerçekleştirildi.");

            #endregion



            Console.Read();
        }
    }
}
