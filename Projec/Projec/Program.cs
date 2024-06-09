var FileName = "MAT.txt";

using (var writer = File.AppendText(FileName))
{
    writer.WriteLine("best");
}
if (File.Exists(FileName))
{
    using (var reader = File.OpenText(FileName))
    {
        var line = reader.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
        }
    }
}