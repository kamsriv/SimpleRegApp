using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
namespace APIClient
{
    class StudentClient
    {
        public static void Main(String[] args)
        {
            string s = "Google";
            Console.WriteLine(s);

            HttpClient client = new HttpClient();
            var response = Task.Run(() => client.GetAsync("Student/GetStudent"));
            var responseContent = response.GetAwaiter().GetResult();
            if(responseContent.IsSuccessStatusCode)
            {
                Console.WriteLine(responseContent.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
