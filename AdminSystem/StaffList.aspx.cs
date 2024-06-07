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
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time page is displayed
        if (IsPostBack == false)
        {
            //update list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
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
}