using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //store pk of record to be deleted
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create new instance of staff
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find record to delete
        StaffBook.ThisStaff.Find(StaffId);
        //delete record
        StaffBook.Delete();
        //redirect to main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to main page
        Response.Redirect("StaffList.aspx");
    }
}