using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using UserLoginApp.Models;

namespace UserLoginApp.Services;

public class FileService
{
    private const string FilePath = "../../../Users.json";

    public void WriteUsers(List<User> users)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        string json = JsonSerializer.Serialize(users, options);
        File.WriteAllText(FilePath, json);
    }

    public List<User> ReadUsers()
    {
        if (!File.Exists(FilePath))
        {
            return new List<User>();
        }

        string json = File.ReadAllText(FilePath);

        if (string.IsNullOrWhiteSpace(json))
        {
            return new List<User>();
        }

        var users = JsonSerializer.Deserialize<List<User>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return users ?? new List<User>();
    }
}