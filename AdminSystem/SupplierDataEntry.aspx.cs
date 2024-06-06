using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        if (IsPostBack == false)
        {
            if (SupplierId != 1)
            {
                DisplaySupplier();
            }
        }
    }

    void DisplaySupplier()
    {
        clsSupplierCollection Supplier = new clsSupplierCollection();
        Supplier.ThisSupplier.Find(SupplierId);
        txtSupplierId.Text = Supplier.ThisSupplier.SupplierId.ToString();
        txtStreet.Text = Supplier.ThisSupplier.Street.ToString();
        txtStreetNum.Text = Supplier.ThisSupplier.StreetNum.ToString();
        txtPostCode.Text = Supplier.ThisSupplier.PostCode.ToString();
        txtPhoneNum.Text = Supplier.ThisSupplier.PhoneNum.ToString();
        txtRegistrationDate.Text = Supplier.ThisSupplier.RegistrationDate.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        string Street = txtStreet.Text;
        string StreetNum = txtStreetNum.Text;
        string SupplierName = txtSupplierName.Text;
        string PhoneNum = txtPhoneNum.Text;
        string PostCode = txtPostCode.Text;
        string RegistrationDate = txtRegistrationDate.Text;
        string Error = "";
        Error = AnSupplier.Valid(RegistrationDate, Street, StreetNum, PostCode, SupplierName, PhoneNum);
        if (Error == "")
        {
            AnSupplier.SupplierId = SupplierId;
            AnSupplier.Street = Street;
            AnSupplier.StreetNum = StreetNum;
            AnSupplier.PostCode = PostCode;
            AnSupplier.PhoneNum = PhoneNum;
            AnSupplier.SupplierName = SupplierName;
            AnSupplier.RegistrationDate = Convert.ToDateTime(RegistrationDate);
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            if (SupplierId == -1)
            {
                SupplierList.ThisSupplier = AnSupplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierId);
                SupplierList.ThisSupplier = AnSupplier;
                SupplierList.Update();
            }

            Response.Redirect("SupplierList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }


    }
}
