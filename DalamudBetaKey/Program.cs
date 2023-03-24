using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        private static async Task MainAsync(string[] args)
        {
            try
            {
                string ab12 = "://"; string fc19 = "/"; string gx98 = "."; string be84 = "goatcorp";
                string hu93 = "stg"; string ly06 = "version"; string pd67 = "dalamud-distrib"; string qk56 = "com";
                string tn42 = "raw"; string vw23 = "githubusercontent"; string xm30 = "main"; string zj71 = "https";
                string url = $"{zj71}{ab12}{tn42}{gx98}{vw23}{gx98}" +
                             $"{qk56}{fc19}{be84}{fc19}{pd67}{fc19}" +
                             $"{xm30}{fc19}{hu93}{fc19}{ly06}";

                var client = new HttpClient();
                var response = await client.GetAsync(url).ConfigureAwait(false);
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var json = JObject.Parse(content);

                Console.WriteLine("Here's the updated Dalamud Staging Beta Build information:");
                Console.WriteLine();
                foreach (var property in json.Properties())
                {
                    Console.WriteLine($"{property.Name}: {property.Value}");
                }
                Console.WriteLine();

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "XIVLauncher", "dalamudConfig.json");
                string? answer = "";
                while (answer != "y" && answer != "n")
                {
                    Console.Write("Would you like to open the dalamudConfig.json file? (y/N): ");
                    answer = Console.ReadLine()?.ToLower();
                    if (string.IsNullOrWhiteSpace(answer))
                    {
                        answer = "n";
                    }
                }
                if (answer == "y")
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("There was an error retrieving data from the API:");
                Console.WriteLine(ex.Message);
            }
            catch (JsonReaderException ex)
            {
                Console.WriteLine("There was an error parsing the JSON data:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an error:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
