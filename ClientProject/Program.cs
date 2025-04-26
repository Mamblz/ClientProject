using System.Threading.Tasks;
using Newtonsoft.Json;
using ClientProject.Models;

namespace ClientProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7245");
            Console.WriteLine("Hello, World!");
            HttpResponseMessage message = await client.GetAsync("deviceslist");
            string str = await message.Content.ReadAsStringAsync();
            List<Device> device = JsonConvert.DeserializeObject<List<Device>>(str);
        }
    }
}
