using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store pk with page level scope
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {

        //if firdt time page is displayed
        if (StaffId != -1)
        {
            //display current data
            DisplayMultipleStaff();
        }

    }

    void DisplayMultipleStaff()
    {
        //create instance of staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set data source to list of staff in collection
        lstStaffList.DataSource = Staff.StaffList;
        //set name of primary key
        lstStaffList.DataValueField = "StaffId";
        //set data field to display
        lstStaffList.DataTextField = "StaffName";
        //bind data to list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //var to store primary key value of record to be editted
        Int32 StaffId;
        //if a record has been selected from the list 
        if(lstStaffList.SelectedIndex != -1) 
        {
            //get pk value of record to edit 
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store data in session object
            Session["StaffId"] = StaffId;
            //redirect to edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select record from the list to edit";
        }
    }
}