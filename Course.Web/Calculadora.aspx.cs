using System;
using System.Threading;

namespace Course.Web
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(2000);

                int val1 = 0;
                int val2 = 0;

                if (Int32.TryParse(txtValor1.Text, out val1) == true &&
                    Int32.TryParse(txtValor2.Text, out val2) == true)
                {
                    lblSuma.Text = (val1 + val2).ToString();
                }
                else
                {
                    lblSuma.Text = "Ambos valores deben ser Enteros.";
                }
            }
            catch (Exception ex)
            {
                lblSuma.Text = ex.ToString();
            }
        }
    }
}