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

        //capture the note	
        AnOrder.Note = txtNote.Text;

        //store the order in the session object 	
        Session["AnOrder"] = AnOrder;

        //naviagte to view page 
        Response.Redirect("OrderViewer.aspx");
    }

    protected void txtNote_TextChanged(object sender, EventArgs e)
    {

    }
}