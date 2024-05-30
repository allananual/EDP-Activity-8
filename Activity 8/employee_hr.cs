using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Activity_8
{
    public partial class employee_hr : Form
    {
        private readonly string API = "http://localhost/api.php";
        private int deptOption;
        private int sal_id;

        public employee_hr()
        {
            InitializeComponent();
        }

        private async void GetButton_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(API);

                    if (response.IsSuccessStatusCode)
                    { 
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JArray.Parse(json);
                        HR_dataGridView.DataSource = data.ToObject<DataTable>();
                    }
                    else
                    {
                        MessageBox.Show("Failure to retrieve data from server! Status code: " + response.StatusCode);
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show("Request error: " + httpEx.Message);
                }
                catch (JsonException jsonEx)
                {
                    MessageBox.Show("Error parsing JSON data: " + jsonEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            } 
        }

        private async void PostButton_Click(object sender, EventArgs e)
        {
            if (deptOption == 0)
            {
                MessageBox.Show("Choose a department.");
                return;
            }

            var userData = new
            {
                username = UsernameTB.Text,
                pass = PasswordTB.Text,
                email = EmailTB.Text,
                dept_id = deptOption,
                sal_id = sal_id
            };

            string json = JsonConvert.SerializeObject(userData);

            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(API, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseBody);
                }
                else
                {
                    MessageBox.Show("Failure to post data! Status code: " + response.StatusCode);
                }
            }
        }

        private async Task FetchDeptAndSalary()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"{API}?department={deptOption}");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);

                    if (data["error"] != null)
                    {
                        MessageBox.Show(data["error"].ToString());
                    }
                    else
                    {
                        SalaryTB.Text = data["totalsalary"]?.ToString() ?? "0";
                        sal_id = data["sal_id"]?.ToObject<int>() ?? 0;
                        await FetchDeptAndSalary();
                    }
                }
                else
                {
                    MessageBox.Show("Failure to retrieve data from server! Status code: " + response.StatusCode);
                }
            }
        }

        private async void TechRB_CheckedChanged(object sender, EventArgs e)
        {
            deptOption = 1;
            await FetchDeptAndSalary();
        }

        private async void ResearchRB_CheckedChanged(object sender, EventArgs e)
        {
            deptOption = 3;
            await FetchDeptAndSalary();
        }

        private async void PayrollRB_CheckedChanged(object sender, EventArgs e)
        {
            deptOption = 5;
            await FetchDeptAndSalary();
        }
    }
}
