using System.Text.Json;

string fileName = "movies.json";
string folderName = "Data";
string rootPath = Environment.CurrentDirectory;
string fullPath = Path.Combine(rootPath, folderName, fileName);

string strJSON = File.ReadAllText(fullPath);