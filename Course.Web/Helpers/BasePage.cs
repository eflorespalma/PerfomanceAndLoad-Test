using System;
using System.Web.UI;

namespace Course.Web.Helpers
{
    public class BasePage : Page
    {
        protected void AddMessage(Exception ex)
        {
            AddMessage(ex.ToString());
        }

        protected void AddMessage(string message)
        {
            Validators.Add(new ValidatorMessage(message));
        }
        public void ReturnToList()
        {
            Response.Redirect("~/Persons/ListPersons.aspx");
        }

    }

    public class ValidatorMessage : System.Web.UI.IValidator
    {
        private string m_message = string.Empty;

        public ValidatorMessage(string message)
        {
            m_message = message;
        }

        public string ErrorMessage
        {
            get
            {
                return m_message;
            }
            set
            {
                m_message = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return false;
            }
            set
            {

            }
        }

        public void Validate()
        {
        }
    }
}