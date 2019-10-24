using System.Linq;

namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			recordCountLabel.Text = string.Empty;
		}

		private void SearchButton_Click(object sender, System.EventArgs e)
		{
			recordCountLabel.Text = string.Empty;

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var data =
					databaseContext.Countries
					.AsQueryable();

				if (string.IsNullOrWhiteSpace(countryNameTextBox.Text) == false)
				{
					data =
						data
						.Where(current => current.Name.Contains(countryNameTextBox.Text))
						;
				}

				if (string.IsNullOrWhiteSpace(countryCodeFromTextBox.Text) == false)
				{
					int countryCodeFrom =
						System.Convert.ToInt32(countryCodeFromTextBox.Text);

					data =
						data
						.Where(current => current.Code >= countryCodeFrom)
						;
				}

				if (string.IsNullOrWhiteSpace(countryCodeToTextBox.Text) == false)
				{
					int countryCodeTo =
						System.Convert.ToInt32(countryCodeToTextBox.Text);

					data =
						data
						.Where(current => current.Code <= countryCodeTo)
						;
				}

				data =
					data.OrderBy(current => current.Code)
					;

				var result =
					data
					.ToList()
					;

				recordCountLabel.Text =
					$"Record Count: { result.Count }";

				countriesListBox.ValueMember = nameof(Models.Country.Id);
				countriesListBox.DisplayMember = nameof(Models.Country.DisplayName);

				countriesListBox.DataSource = result;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
	}
}
