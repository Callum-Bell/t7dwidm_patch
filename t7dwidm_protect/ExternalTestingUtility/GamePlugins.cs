using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class GamePlugins
{
    public List<string> PluginFileLocations { get; private set; }
    private const string FileName = "plugins.json";

    public static GamePlugins Instance { get; private set; } = new GamePlugins();

    public GamePlugins()
    {
        PluginFileLocations = new List<string>();
    }

    public void Initialize()
    {
        LoadFromFile();
    }

    public void AddPlugin(string filePath)
    {
        if (!string.IsNullOrEmpty(filePath) && !PluginFileLocations.Contains(filePath))
        {
            PluginFileLocations.Add(filePath);
            SaveToFile();
        }
    }

    public void RemovePlugin(string filePath)
    {
        if (PluginFileLocations.Contains(filePath))
        {
            PluginFileLocations.Remove(filePath);
            SaveToFile();
        }
    }

    public List<string> GetPlugins()
    {
        return PluginFileLocations;
    }


    public void SaveToFile()
    {
        string json = JsonConvert.SerializeObject(this, Formatting.Indented);
        File.WriteAllText(FileName, json);
    }


    private void LoadFromFile()
    {
        if (File.Exists(FileName))
        {
            string json = File.ReadAllText(FileName);
            var loadedPlugins = JsonConvert.DeserializeObject<GamePlugins>(json);
            PluginFileLocations = loadedPlugins.PluginFileLocations;
            PluginFileLocations.RemoveAll(file => !File.Exists(file));
            SaveToFile();
        }
    }
}
