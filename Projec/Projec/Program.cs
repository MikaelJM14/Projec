using Projec;

var list = new ist();
list.ints.Add(4);
list.ints.Add(79);
list.ints.Add(11);
list.ints.Add(369);

var FileName = "Mat.txt";

for (var writer = File.AppendText(FileName))
{
    writer.WriteLine(list.ints);
}
if (File.Exists(FileName))
{
    using (var reader = File.OpenText(FileName))
    {
        var line = reader.ReadToEnd();
        while (line != null)
        {
            Console.WriteLine(line);
        }
    }
}