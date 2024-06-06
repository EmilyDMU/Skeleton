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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged2(object sender, EventArgs e)
    {

    }

    protected void TxtCustomerId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtStaffId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder    
        clsOrder AnOrder = new clsOrder();
        
        //capture the Order ID
        //AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        
        //capture the Shoe ID
        //AnOrder.ShoeId = Convert.ToInt32(txtShoeId.Text);

        //capture the Customer ID
        //AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);

        //capture the Staff ID
        //AnOrder.StaffId = Convert.ToInt32(txtStaffId.Text);

        //capture the order Date
        //AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

        //capture the note	
        AnOrder.Note = txtNote.Text;

        //capture the total amount
        AnOrder.TotalAmount = float.Parse(txtTotalAmount.Text);

        //capture the order status
        //AnOrder.OrderStatus = txtOrderStatus.Text;

        //Capture the active
        //AnOrder.Active = chkActive.Checked;

        //store the order in the session object 	
        Session["AnOrder"] = AnOrder;

        //naviagte to view page 
        Response.Redirect("OrderViewer.aspx");
    }

    protected void txtNote_TextChanged(object sender, EventArgs e)
    {

    }
}