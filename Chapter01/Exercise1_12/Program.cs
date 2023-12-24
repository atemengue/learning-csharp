static async Task ReadFile(FileStream fileStream)
{

  using (var reader = new StreamReader(fileStream))
  {
    ;

    var content = await reader.ReadToEndAsync();
    var lines = content.Split(Environment.NewLine);
    foreach (var line in lines)
    {
      Console.WriteLine(line);
    }
  }
};


// streamwriter
using (var file = new StreamWriter("Exercise1_12/text.csv", append: true))
{

  file.Write("\n One more mackbook without details");
}

using (var filesStream = new FileStream("Exercise1_12/text.csv", FileMode.Open, FileAccess.Read))
{
  await ReadFile(filesStream);
}