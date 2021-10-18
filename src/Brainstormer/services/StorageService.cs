using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Brainstormer.Models.models;
using Microsoft.Extensions.Configuration;

namespace Brainstormer.services
{
    public class StorageService : IStorageService
    {
        private string Path { get; set; }
        
        public StorageService(IConfiguration configuration)
        {
            this.Path = configuration.GetValue<string>("store_uri");
        }
        
        public void StoreIdeas(IEnumerable<Idea> ideas)
        {
            var fs = new FileStream(this.Path, FileMode.Truncate);
            var sw = new StreamWriter(fs);

            var json = JsonSerializer.Serialize(ideas);
            
            sw.Write(json);
            
            fs.Close();
        }

        public IEnumerable<Idea> FetchIdeas()
        {
            var fs = new FileStream(Path, FileMode.Open);
            var sr = new StreamReader(fs);

            var json = sr.ReadToEnd();
            
            fs.Close();

            var ideas = JsonSerializer.Deserialize<IEnumerable<Idea>>(json);
            return ideas ?? new List<Idea>();

        }
    }
}