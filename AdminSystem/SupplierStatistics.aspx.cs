using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClassLibrary;

public partial class SupplierStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSupplier clssuppliers = new clsSupplier();
        DataTable dT = clssuppliers.StatisticsGroupedByStreet();
        GridViewStGroupbyStreet.DataSource = dT;
        GridViewStGroupbyStreet.DataBind();
        GridViewStGroupbyStreet.HeaderRow.Cells[0].Text = "Total";


        dT = clssuppliers.StatisticsGroupedRegistratedDate();
        GridViewStGroupbyRegistratedDate.DataSource = dT;
        GridViewStGroupbyRegistratedDate.DataBind();
        GridViewStGroupbyRegistratedDate.HeaderRow.Cells[0].Text = "Total";



    }
}
