using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Westcoast_EShop.Models;

public class Storage
{
    private static JsonSerializerOptions _options =
        new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true,
        };

    public static void WriteJson(string path, List<SalesOrder> orders)
    {
        // här skriver vi ner allt till ett json dokument


        var json = JsonSerializer.Serialize(orders, _options);

        File.WriteAllText(path, json);
    }
}
