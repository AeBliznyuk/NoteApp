using Newtonsoft.Json;
using System.IO;


namespace NoteApp
{
    static public class ProjectManager
    {
        static public Project LoadFromFile(string path)
        {
            if (File.Exists(path))
            {
                Project project = null;
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(@"c:\json.txt"))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = (Project)serializer.Deserialize<Project>(reader);
                }
                return project;
            }
            else return null;
        }
        static public void SaveToFile(string path, Project project)
        {
            if (!File.Exists(path))
            {
                using (FileStream fileStream = File.Create(path)) { }
            }
            
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter streamWriter = new StreamWriter(path))

            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(writer, project);
            }
        }
    }
}
