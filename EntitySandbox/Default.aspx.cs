using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntitySandbox
{
	public partial class Default : System.Web.UI.Page
	{
		private void DisplayPersons()
		{
			using (EntitiesContext context = new EntitiesContext())
			{
				List<Person> persons = context.Persons.ToList();

				List<string> _persons = persons.Select(x => String.Format("{0} {1} {2} {3}", x.ID, x.FirstName, x.LastName, x.Hobby)).ToList();

				tbPersons.Text = String.Join("\r\n", _persons);
			}
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			DisplayPersons();
		}

		protected void btnAddPerson_Click(object sender, EventArgs e)
		{
			using (EntitiesContext context = new EntitiesContext())
			{
				Person _person = context.Persons.FirstOrDefault(x => x.FirstName == tbFirstName.Text && x.LastName == tbLastName.Text);

				if (_person == null)
				{
					Person newPerson = new Person()
					{
						ID = -1,
						FirstName = tbFirstName.Text,
						LastName = tbLastName.Text,
						Hobby = tbHobby.Text
					};

					context.Persons.Add(newPerson);
				}
				else
				{
					_person.Hobby = tbHobby.Text;
					//context.Persons.Attach(_person);
					//context.Entry(_person).State = EntityState.Modified;
				}

				context.SaveChanges();
			}

			DisplayPersons();
		}
	}
}