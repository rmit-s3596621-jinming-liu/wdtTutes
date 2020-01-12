using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration.Json;

namespace wdtTute02
{
    class Program
    {
        static void Main()
        {
            using var client= new HttpClient();
            var json = client.GetStringAsync("http://coreteaching01.csit.rmit.edu.au/~e87149/wdt/services/example/").Result;

            // Console.WriteLine(json);
            // JsonConvert.DeserializeObject(json);
            var people = JsonConvert.DeserializeObject<List<Person>>(json);

            foreach(var person in people)
            {
                Console.WriteLine(person);
                InsertPerson(person);
            }

        }
        private static void InsertPerson(int personId,string name)
        {
            const string connectionString ="server"
     using var connection = new SqlConnection(connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "insert into Person"

        }
    }
}
