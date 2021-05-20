using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims
{
    class updation
    {
        public void updateUser(int id, string name, string username, string pass, string email, string phone, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con); //Here we are using the stored procedure
                cmd.CommandType = CommandType.StoredProcedure; //We specify the type of command that is a stored procedure
                                                               //We proceed to fill the parameters
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " updated to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void updateCat(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con); //Here we are using the stored procedure
                cmd.CommandType = CommandType.StoredProcedure; //We specify the type of command that is a stored procedure
                                                               //We proceed to fill the parameters
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@ed", id);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " updated successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void updateProduct(int proID, string product, string barcode, float price, DateTime? expiry, int catID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productUpdate", MainClass.con); //Here we are using the stored procedure
                cmd.CommandType = CommandType.StoredProcedure; //We specify the type of command that is a stored procedure
                                                               //We proceed to fill the parameters
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@expiry", expiry);
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@prodID", proID);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + " updated to the system successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
