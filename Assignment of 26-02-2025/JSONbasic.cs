using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;

class Student {
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Subjects { get; set; }
}

class Car {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program {
    static void Main() {
        Student student = new Student {
            Name = "Amit Sharma",
            Age = 20,
            Subjects = new List<string> { "Math", "Science", "History" }
        };
        string studentJson = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(studentJson);
        Car car = new Car {
            Make = "Maruti",
            Model = "Swift",
            Year = 2021
        };
        string carJson = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine(carJson);
        Console.WriteLine("\n---- 3️⃣ Read JSON File and Extract Fields ----");
        string jsonFromFile = File.ReadAllText("data.json");
        JArray jsonArray = JArray.Parse(jsonFromFile);
        foreach (var item in jsonArray) {
            Console.WriteLine("Name: " + item["name"]);
            Console.WriteLine("Email: " + item["email"]);
        }
        string json1 = @"{ 'Name': 'Raj', 'Age': 30 }";
        string json2 = @"{ 'Email': 'raj@example.com', 'Country': 'India' }";
        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);
        obj1.Merge(obj2, new JsonMergeSettings {
            MergeArrayHandling = MergeArrayHandling.Union
        });
        Console.WriteLine(obj1.ToString(Formatting.Indented));
        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'Name': {'type': 'string'},
                'Age': {'type': 'integer'}
            },
            'required': ['Name', 'Age']
        }";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject jsonObject = JObject.Parse(json1);
        bool isValid = jsonObject.IsValid(schema, out IList<string> errorMessages);
        Console.WriteLine("Is Valid: " + isValid);
        foreach (var error in errorMessages) {
            Console.WriteLine("Error: " + error);
        }
        List<Car> carList = new List<Car> {
            new Car { Make = "Tata", Model = "Nexon", Year = 2019 },
            new Car { Make = "Mahindra", Model = "Thar", Year = 2022 }
        };
        string jsonArrayString = JsonConvert.SerializeObject(carList, Formatting.Indented);
        Console.WriteLine(jsonArrayString);
        string filterJson = @"[
            { 'Name': 'Vikram', 'Age': 30 },
            { 'Name': 'Ravi', 'Age': 22 },
            { 'Name': 'Anjali', 'Age': 27 }
        ]";
        JArray people = JArray.Parse(filterJson);
        foreach (var person in people) {
            if (person["Age"].Value<int>() > 25) {
                Console.WriteLine(person.ToString(Formatting.Indented));
            }
        }
    }
}
