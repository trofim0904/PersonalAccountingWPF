using PersonalAccounting.Model.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Services
{
    public class VerificationProcessor
    {
        public static async Task<bool> CheckRegistrationModel(RegistrationModel model)
        {
            string url = $"https://localhost:44396/api/Verification";

            HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync<RegistrationModel>(url, model);
            if (response.IsSuccessStatusCode)
            {
                bool result = await response.Content.ReadAsAsync<bool>();
                return result;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
            
        }
    }
}
