using Course.Data.PersonRepository;
using Course.Web.Helpers;
using System;
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
            grvPerson.DataSource = personRepository.GetAll();
            grvPerson.DataBind();
        }
        protected override void OnPreRender(EventArgs e)
        {
            if (grvPerson.Rows == null)
            {
                lblRowCount.Text = "0";
            }
            else
            {
                lblRowCount.Text = grvPerson.Rows.Count.ToString();
            }

            base.OnPreRender(e);
        }
        protected void grvPerson_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var genere = e.Row.Cells[6].Text;
                e.Row.Cells[6].Text = genere.Equals(GenereShortConstants.MASCULINO) ? GenereConstants.MASCULINO : GenereConstants.FEMENINO;
            }
        }
    }
}