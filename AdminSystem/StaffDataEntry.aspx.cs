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
        //accidentally worked in master branch. no issues though
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture staff ID
        string StaffId = txtStaffId.Text;
        //capture the staff name
        string StaffName = txtStaffName.Text;
        //capture date of birth 
        string DateOfBirth = txtDateOfBirth.Text;
        //capture role
        string StaffRole = txtStaffRole.Text;
        //capture department
        string StaffDepartment = txtStaffDepartment.Text;
        //capture status
        string StaffStatus = txtStaffStatus.Text;
        //capture permission checkbox
        string StaffPermission = chkStaffPermission.Text;
        //variable to store any error messages
        string Error = "";
        //validate the date
        Error = AStaff.Valid(StaffId, StaffName, DateOfBirth, StaffDepartment, StaffStatus);
        if (Error == "")
        {
            //capture staff id 
            AStaff.StaffId = Convert.ToInt32(StaffId);
            //capture staff name
            AStaff.StaffName = StaffName;
            //capture  date of birth 
            AStaff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture staff role
            AStaff.StaffRole = StaffRole;
            //capture staff department
            AStaff.StaffDepartment = StaffDepartment;
            //capture staff status
            AStaff.StaffStatus = StaffStatus;
            //capture staff permission
            AStaff.StaffPermission = chkStaffPermission.Checked;
            //create new instance of staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the ThisStaff property
            StaffList.ThisStaff = AStaff;
            //add the new record
            StaffList.Add();
            //redirect to list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

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