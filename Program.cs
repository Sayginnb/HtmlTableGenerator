using System.Text.Json;

string fileName = "movies.json";
string folderName = "Data";
string rootPath = Environment.CurrentDirectory;
string fullPath = Path.Combine(rootPath, folderName, fileName);

string strJSON = File.ReadAllText(fullPath);

var op = new JsonSerializerOptions();
op.PropertyNameCaseInsensitive = false;
var Movies = JsonSerializer.Deserialize<List<Movie>>(strJSON, op);

string strHTML = "";
strHTML += "<table>";

strHTML += "<th>";
strHTML += "<tr>";
strHTML += "<td>id</td>";
strHTML += "<td>title</td>";
strHTML += "<td>rating</td>";
strHTML += "<td>genre</td>";
strHTML += "<td>duration</td>";
strHTML += "</tr>";
strHTML += "</th>";

strHTML += "<tbody>";

foreach (var item in Movies)
{
    strHTML += "<tr>";

    strHTML += "<td>" + item.Id + "</td>";
    strHTML += "<td>" + item.Title + "</td>";
    strHTML += "<td>" + item.Rating + "</td>";
    strHTML += "<td>" + item.Genre + "</td>";
    strHTML += "<td>" + item.Duration + "</td>";

    strHTML += "</tr>";
}

strHTML += "</tbody>";
strHTML += "</table>";

fileName = "output.html";
fullPath = Path.Combine(rootPath,folderName,fileName);
File.WriteAllText(fullPath, strHTML);