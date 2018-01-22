using Course.Data.ProductRepository;
using Course.Entity;
using Course.Web.Helpers;
using System;

namespace Course.Web.Products
{
    public partial class EditProduct : BasePage
    {
        ProductData _repository;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = -1;
                id = Util.ParseInt32(Request["id"], -1);
                if (id == -1)
                {
                    lblId.Text = id.ToString();
                    txtStock.Text = "0";
                    txtPrecio.Text = "0";
                    txtName.Text = string.Empty;
                    ddlCategoria.SelectedIndex = 0;
                }
                else
                {
                    _repository = new ProductData();

                    Product product = _repository.GetProduct(id);

                    lblId.Text = product.Id.ToString();
                    txtStock.Text = product.Stock.ToString();
                    txtPrecio.Text = product.Price.ToString();
                    txtName.Text = product.Name;
                    ddlCategoria.SelectedValue = product.Category;
                }
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                    return;

                Product product = new Product();
                product.Name = txtName.Text;
                product.Category = ddlCategoria.SelectedValue;
                product.Price = double.Parse(txtPrecio.Text);
                product.Stock = int.Parse(txtStock.Text);


                _repository = new ProductData();
                if (lblId.Text == "-1")
                    lblId.Text = _repository.SaveProduct(product).ToString();
                else
                {
                    product.Id = int.Parse(lblId.Text);
                    _repository.UpdateProduct(product);
                }
            }
            catch (Exception ex)
            {
                AddMessage(ex);
            }
        }
        private bool ValidateForm()
        {
            bool result = false;

            if (txtName.Text.Equals(string.Empty))
            {
                AddMessage("Debe ingresar el Nombre.");
                result = true;
            }

            if (txtStock.Text.Equals(string.Empty))
            {
                AddMessage("Debe ingresar el Stock.");
                result = true;
            }

            if (txtPrecio.Text.Equals(string.Empty))
            {
                AddMessage("Debe ingresar el Precio.");
                result = true;
            }

            if (ddlCategoria.SelectedValue.Equals(string.Empty))
            {
                AddMessage("Debe seleccionar la Categoría");
                result = true;
            }

            return result;
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToListProduct();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "-1")
                    return;
                else
                {
                    Product product = new Product();
                    product.Id = int.Parse(lblId.Text);
                    _repository = new ProductData();
                    _repository.RemoveProduct(product);
                    ReturnToListProduct();
                }
            }
            catch (Exception ex)
            {
                AddMessage(ex);
            }
        }
    }
}