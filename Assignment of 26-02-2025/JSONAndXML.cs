using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

class User {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program {
    static void Main() {
        string jsonContent = File.ReadAllText("data.json");
        JObject jsonObject = JObject.Parse(jsonContent);
        PrintJsonKeysAndValues(jsonObject);
        List<User> users = new List<User> {
            new User { Name = "Amit", Age = 30, Email = "amit@example.com" },
            new User { Name = "Priya", Age = 22, Email = "priya@example.com" }
        };
        string jsonArrayString = JsonConvert.SerializeObject(users, Formatting.Indented);
        Console.WriteLine(jsonArrayString);
        JArray jsonArray = JArray.Parse(jsonContent);
        foreach (var item in jsonArray) {
            if (item["age"].Value<int>() > 25) {
                Console.WriteLine(item.ToString(Formatting.Indented));
            }
        }

        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'Email': {
                    'type': 'string',
                    'format': 'email'
                }
            },
            'required': ['Email']
        }";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject emailJson = JObject.Parse("{ 'Email': 'valid@example.com' }");
        bool isValid = emailJson.IsValid(schema, out IList<string> errorMessages);
        Console.WriteLine("Is Valid Email: " + isValid);
        foreach (var error in errorMessages) {
            Console.WriteLine("Error: " + error);
        }

        string jsonFile1 = File.ReadAllText("file1.json");
        string jsonFile2 = File.ReadAllText("file2.json");
        JObject jsonObject1 = JObject.Parse(jsonFile1);
        JObject jsonObject2 = JObject.Parse(jsonFile2);
        jsonObject1.Merge(jsonObject2, new JsonMergeSettings {
            MergeArrayHandling = MergeArrayHandling.Union
        });
        Console.WriteLine(jsonObject1.ToString(Formatting.Indented));

        string sampleJson = @"{ 'Name': 'Rohit', 'Age': 28 }";
        XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(sampleJson, "User");
        Console.WriteLine(xmlDocument.OuterXml);

        string[] csvLines = File.ReadAllLines("data.csv");
        List<Dictionary<string, string>> csvData = new List<Dictionary<string, string>>();
        string[] headers = csvLines[0].Split(',');
        for (int i = 1; i < csvLines.Length; i++) {
            string[] row = csvLines[i].Split(',');
            Dictionary<string, string> rowData = new Dictionary<string, string>();
            for (int j = 0; j < headers.Length; j++) {
                rowData[headers[j]] = row[j];
            }
            csvData.Add(rowData);
        }
        string csvToJson = JsonConvert.SerializeObject(csvData, Formatting.Indented);
        Console.WriteLine(csvToJson);

        string connectionString = "your_connection_string_here";
        using (SqlConnection connection = new SqlConnection(connectionString)) {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Name, Age, Email FROM Users", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<User> userList = new List<User>();
            while (reader.Read()) {
                userList.Add(new User {
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Email = reader["Email"].ToString()
                });
            }
            reader.Close();
            string jsonReport = JsonConvert.SerializeObject(userList, Formatting.Indented);
            Console.WriteLine(jsonReport);
        }
    }

    static void PrintJsonKeysAndValues(JObject jsonObject) {
        foreach (var property in jsonObject.Properties()) {
            Console.WriteLine($"{property.Name}: {property.Value}");
            if (property.Value is JObject childObject) {
                PrintJsonKeysAndValues(childObject);
            }
            if (property.Value is JArray childArray) {
                foreach (var item in childArray) {
                    if (item is JObject arrayObject) {
                        PrintJsonKeysAndValues(arrayObject);
                    }
                }
            }
        }
    }
}
