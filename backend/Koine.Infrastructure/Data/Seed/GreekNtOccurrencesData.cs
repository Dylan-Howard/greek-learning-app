using System.Text.Json;

namespace Koine.Infrastructure.Data.Seed
{
    public static class GreekNtOccurrencesData
    {
        public static Dictionary<string, int> Load()
        {
            var candidates = new[]
            {
                Path.Combine(AppContext.BaseDirectory, "Data", "Seed", "greeknt-occurrences.json"),
                Path.Combine(Directory.GetCurrentDirectory(), "Koine.Infrastructure", "Data", "Seed", "greeknt-occurrences.json"),
                Path.Combine(Directory.GetCurrentDirectory(), "backend", "Koine.Infrastructure", "Data", "Seed", "greeknt-occurrences.json"),
            };

            foreach (var candidate in candidates)
            {
                if (!File.Exists(candidate))
                {
                    continue;
                }

                var raw = File.ReadAllText(candidate);
                var data = JsonSerializer.Deserialize<Dictionary<string, int>>(raw);
                if (data != null)
                {
                    return data;
                }
            }

            return new Dictionary<string, int>();
        }
    }
}
