using Course.Data.GiftRepository;
using Course.Entity;
using Course.Web.Helpers;
using System;
using System.Web.UI;

namespace Course.Web.Gifts
{
    public partial class RegisterGift : BasePage
    {
        GiftData giftRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = -1;
                id = Util.ParseInt32(Request["id"], -1);
                if (id == -1)
                {
                    lblId.Text = id.ToString();
                    ddlGenero.SelectedIndex = 0;
                    txtPrecio.Text = string.Empty;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                    return;

                Gift person = new Gift();
                person.Price = double.Parse(txtPrecio.Text);
                person.Genere = ddlGenero.SelectedValue;
                giftRepository = new GiftData();
                lblId.Text = giftRepository.SaveGift(person).ToString();
            }
            catch (Exception ex)
            {
                AddMessage(ex);
            }
        }

        private bool ValidateForm()
        {
            bool result = false;

            if (ddlGenero.SelectedValue.Equals(string.Empty))
            {
                AddMessage("Debe seleccionar el Genero de la Persona");
                result = true;
            }

            if (txtPrecio.Text.Equals(string.Empty))
            {
                AddMessage("Debe ingresar el Precio del Regalo");
                result = true;
            }

            return result;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToList();
        }
    }
}