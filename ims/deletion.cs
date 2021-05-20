using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ims
{
    class deletion
    {
        public void delete(object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con); //Here we are using the stored procedure
                cmd.CommandType = CommandType.StoredProcedure; //We specify the type of command that is a stored procedure
                                                               //We proceed to fill the parameters
                cmd.Parameters.AddWithValue(param, id);
             
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG("Data Deleted successfully", "Success...", "Success");
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
