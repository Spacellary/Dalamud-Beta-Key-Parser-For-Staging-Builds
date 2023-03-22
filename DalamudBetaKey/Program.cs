using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var client = new HttpClient();
            var response = await client.GetAsync("https://raw.githubusercontent.com/goatcorp/dalamud-distrib/main/stg/version");
            var content = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(content);

            Console.WriteLine("Here's the updated Dalamud Staging Beta Build information:");
            Console.WriteLine();

            foreach (var property in json.Properties())
            {
                Console.WriteLine($"{property.Name}: {property.Value}");
            }

            Console.WriteLine();

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "XIVLauncher", "dalamudConfig.json");

            Console.Write("Would you like to open the dalamudConfig.json file? (y/N): ");
            var answer = Console.ReadLine();

            if (answer != null && answer.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                var psi = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}
