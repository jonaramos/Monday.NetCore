# Monday.NetCore
A .NET Standard/C# implementation of Monday.com API.

This Project is based on the original work from **Clint Masden** at https://github.com/clintmasden/monday.client.v2.

| Name | Resources |
| ------ | ------ |
| APIs | https://developers.monday.com/ |
| References | https://github.com/LucyParry/MondayAPIV2_BasicExample |

#### Getting Started:
```
using System;
using Monday.Client;

namespace Monday.App
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var client = new MondayClient("APIKEY");

            var users = client.GetUsers().Result;

            users.ForEach(user => Console.WriteLine($"{user.Id}. {user.Name}"));
            Console.Read();
        }
    }
}
```
