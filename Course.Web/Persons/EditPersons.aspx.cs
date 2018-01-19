using Course.Data.PersonRepository;
using Course.Entity;
using Course.Web.Helpers;
using System;
using System.Web.UI;

namespace Course.Web.Persons
{
    public partial class EditPerson : BasePage
    {
        PersonData personRepository;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = -1;
                id = Util.ParseInt32(Request["id"], -1);
                if (id == -1)
                {
                    lblId.Text = id.ToString();
                    txtEmail.Text = string.Empty;
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtPhone.Text = string.Empty;
                }
                else
                {
                    personRepository = new PersonData();

                    Person person = personRepository.GetPerson(id);

                    lblId.Text = person.Id.ToString();
                    txtEmail.Text = person.EmailAddress;
                    txtFirstName.Text = person.FirstName;
                    txtLastName.Text = person.LastName;
                    txtPhone.Text = person.PhoneNumber;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person();
                person.EmailAddress = txtEmail.Text;
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.PhoneNumber = txtPhone.Text;


                personRepository = new PersonData();
                if (lblId.Text == "-1")
                    lblId.Text = personRepository.SavePerson(person).ToString();
                else
                {
                    person.Id = int.Parse(lblId.Text);
                    personRepository.UpdatePerson(person);
                }
            }
            catch (Exception ex)
            {
                AddMessage(ex);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToList();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "-1")
                    return;
                else
                {
                    Person person = new Person();
                    person.Id = int.Parse(lblId.Text);
                    personRepository = new PersonData();
                    personRepository.RemovePerson(person);
                    ReturnToList();
                }
            }
            catch (Exception ex)
            {
                AddMessage(ex);
            }
        }

        private void ReturnToList()
        {
            Response.Redirect("ListPersons.aspx");
        }

    }
}