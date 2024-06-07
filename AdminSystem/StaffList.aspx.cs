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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store pk for record to be deleted
        Int32 StaffId;
        //if a record has been selected from the list 
        if (lstStaffList.SelectedIndex != -1)
        {
            //get pk value of the record delete
            StaffId = Convert.ToInt32(lstStaffList.SelectedIndex);
            //store data in a session object
            Session["StaffId"] = StaffId;
            //redirect to delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please select a record from the list to delete";
        }
            

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //new instance of staff object
        clsStaffCollection AStaff = new clsStaffCollection();
        //retrieve value of dep from presentation layer
        AStaff.ReportByDepartment(txtReportDep.Text);
        //set data src to list of staff in collection
        lstStaffList.DataSource = AStaff.StaffList;
        //set name of pk
        lstStaffList.DataValueField = "StaffId";
        //set name of field to display
        lstStaffList.DataTextField = "StaffDepartment";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //new instance of staff object
        clsStaffCollection AStaff = new clsStaffCollection();
        //set empty string
        AStaff.ReportByDepartment("");
        //clear any existing filter to tidy interface
        txtReportDep.Text = "";
        //set data src
        lstStaffList.DataSource = AStaff.StaffList;
        //set name of pk
        lstStaffList.DataValueField = "StaffId";
        //set name of field to display
        lstStaffList.DataTextField = "StaffDepartment";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}