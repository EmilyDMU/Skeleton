using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture staff ID
        AStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        //capture the staff name
        AStaff.StaffName = txtStaffName.Text;
        //capture date of birth 
        AStaff.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        //capture role
        AStaff.StaffRole = txtStaffRole.Text;
        //capture department
        AStaff.StaffDepartment = txtStaffDepartment.Text;
        //capture status
        AStaff.StaffStatus = txtStaffStatus.Text;
        //capture permission checkbox
        AStaff.StaffPermission = chkStaffPermission.Checked;
        //store the staff in the session objetc
        Session["AStaff"] = AStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create instance of new staff class
        clsStaff AStaff = new clsStaff();
        //create variable to store the primary key
        Int32 StaffId;
        //create var to store result of the find operation
        Boolean Found = false;
        //get primary key entered by the user 
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AStaff.Find(StaffId);
        //if found
        if (Found == true) 
        {
            //display values of the property in the form 
            txtStaffName.Text = AStaff.StaffName;
            txtDateOfBirth.Text = AStaff.DateOfBirth.ToString();
            txtStaffRole.Text = AStaff.StaffRole;
            txtStaffDepartment.Text = AStaff.StaffDepartment;
            txtStaffStatus.Text = AStaff.StaffStatus;
            chkStaffPermission.Checked = AStaff.StaffPermission;
        }

    }
}