using Course.Data.PersonRepository;
using Course.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Course.Web.Persons
{
    public partial class ListPersons : System.Web.UI.Page
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
            var personRepository = new PersonData();
            m_grid.DataSource = personRepository.GetAll();
            m_grid.DataBind();
        }

        protected override void OnPreRender(EventArgs e)
        {
            if (m_grid.Rows == null)
            {
                lblRowCount.Text = "0";
            }
            else
            {
                lblRowCount.Text = m_grid.Rows.Count.ToString();
            }

            base.OnPreRender(e);
        }
    }
}