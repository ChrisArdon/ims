using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    class retrieval
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statGV,string data=null) //variable data is optional
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUsersDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                //SqlCommand cmd = new SqlCommand("st_getUsersData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                statGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn statGV) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con); ;               
                //SqlCommand cmd = new SqlCommand("st_getUsersData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
            }
        }
        public void getList(string proc, ComboBox cb, string displayMember, string valueMember) //Global function to get a List and fill it in a combobox
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = null;
                //cb.Items.Insert(0, "Select...");

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr,0);
                
                cb.DisplayMember = displayMember; //category
                cb.ValueMember = valueMember; //ID
                cb.DataSource = dt;

            }
            catch (Exception ex)
            {

            }
        }
        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2) 
        {
            try
            {
                //cb.Items.Clear();
                cb.DataSource = null;
                //cb.Items.Insert(0, "Select...");

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);

                cb.DisplayMember = displayMember; //category
                cb.ValueMember = valueMember; //ID
                cb.DataSource = dt;

            }
            catch (Exception ex)
            {

            }
        }
        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, DataGridViewColumn priceGV, DataGridViewColumn barcodeGV, DataGridViewColumn catIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con); ;
                //SqlCommand cmd = new SqlCommand("st_getUsersData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product_ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category_ID"].ToString();


                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
            }
        }
        public static int USER_ID //Create an int variable for the user ID, 
        {
            get;
            private set; //We set the variable private, meaning that only in this class could be modificated
        }
        public static string EMP_NAME //Employee name, Creating a public string variable 
        {
            get;
            private set;//We set the variable private, meaning that only in this class could be modificated
        }
        private static string user_name=null, pass_word=null;
        private static bool checkLogin;
        public static bool getUserDetails(string username, string password) //We get the username and password from the login screen
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user",username);
                cmd.Parameters.AddWithValue("@pass",password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); 
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read()) //while the reader is reading something
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null) //if username and passworn are not null
                    {
                        if (user_name != username && pass_word == password) //if the username is incorrect but the password is correct
                        {
                            MainClass.ShowMSG("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password) //if the username is correct but the password is not
                        {
                            MainClass.ShowMSG("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password) //if both username and password are incorrect
                        {
                            MainClass.ShowMSG("Invalid Username and Password", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.ShowMSG("Unable to login...", "Error", "Error");
            }
            return checkLogin;
        }
        public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn conNameGV, DataGridViewColumn personGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, 
            DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con); ;
                //SqlCommand cmd = new SqlCommand("st_getUsersData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                conNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();


                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load supplier data.", "Error", "Error");
            }
        }
        private string[] productsData = new string[4]; // Array that will get three parameters (the parameters of the stored procedure): ID, Product, Price and Barcode
        public string[] getProductsWRTBarcodeList(string barcode) //Get products with respect to barcode
        {
            try
            {
                

                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        //Here we fill the array 
                        productsData[0] = dr[0].ToString(); //ID
                        productsData[1] = dr[1].ToString(); //Product
                        productsData[2] = dr[2].ToString(); //Price
                        productsData[3] = dr[3].ToString(); //Barcode
                    }
                }
                else
                {
                    //MainClass.ShowMSG("No product available", "Error", "Error");
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
            }
            return productsData;
        }
        public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quantGV, DataGridViewColumn pupGV, DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid",pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                quantGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                pupGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                totGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data.", "Error", "Error");
            }
        }
        private object productStockCount = 0;
        public object getProductQuantity(int proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);

                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception)
            {
            }
            return productStockCount;
        }
    }
}
