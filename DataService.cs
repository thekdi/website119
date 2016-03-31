using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


/// <summary>
/// Summary description for DataService
/// </summary>
public class DataService
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    SqlDataAdapter da;
    SqlCommand cmd;
    DataTable dt;
	public DataService()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void insertinfo(PropertyService p)
    {
        cmd = new SqlCommand("insertinfo", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@fname", p.fname);
        cmd.Parameters.AddWithValue("@lname", p.lname);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public DataTable getinfo()
    {
        da = new SqlDataAdapter("getinfo", con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        dt = new DataTable();
        da.Fill(dt);
        return dt;
        
    }
    

}