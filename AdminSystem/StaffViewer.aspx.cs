using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get data from session object
        AStaff = (clsStaff)Session["AStaff"];
        //display staff Id
        Response.Write(AStaff.StaffId);
        //display the staff name for this entry
        Response.Write(AStaff.StaffName);
        //display staff date of birth
        Response.Write(AStaff.DateOfBirth);
        //display role
        Response.Write(AStaff.StaffRole);
        //display department
        Response.Write(AStaff.StaffDepartment);
        //display status
        Response.Write(AStaff.StaffStatus);
        //display permission
        Response.Write(AStaff.StaffPermission);
    }
}