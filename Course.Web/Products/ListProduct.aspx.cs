using Course.Data.ProductRepository;
using Course.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Course.Web.Products
{
    public partial class ListProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            var personRepository = new ProductData();
            grvProduct.DataSource = personRepository.GetAll();
            grvProduct.DataBind();
        }
        protected override void OnPreRender(EventArgs e)
        {
            if (grvProduct.Rows == null)
            {
                lblRowCount.Text = "0";
            }
            else
            {
                lblRowCount.Text = grvProduct.Rows.Count.ToString();
            }

            base.OnPreRender(e);
        }
        protected void grvProduct_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var category = e.Row.Cells[3].Text;
                e.Row.Cells[3].Text = GetCategoryDescription(category);
            }
        }

        private string GetCategoryDescription(string value)
        {
            string descripcion = string.Empty;
            switch (value)
            {
                case CategoryShortConstants.PORTATILES:
                    {
                        descripcion = CategoryConstants.PORTATILES;
                        break;
                    }
                case CategoryShortConstants.IMPRESION:
                    {
                        descripcion = CategoryConstants.IMPRESION;
                        break;
                    }
                case CategoryShortConstants.ALMACENAMIENTO:
                    {
                        descripcion = CategoryConstants.ALMACENAMIENTO;
                        break;
                    }
                case CategoryShortConstants.SOFTWARE:
                    {
                        descripcion = CategoryConstants.SOFTWARE;
                        break;
                    }
                default:
                    {
                        descripcion = CategoryConstants.TABLETS;
                        break;
                    }
            }
            return descripcion;

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products/EditProduct.aspx?Id=-1");
        }
    }
}