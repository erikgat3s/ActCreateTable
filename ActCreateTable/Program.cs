using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ActCreateTable
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MSI;Database=ProdiTI;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Mahasiswa_Lagi (NIM char(12) not null primary key, Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
