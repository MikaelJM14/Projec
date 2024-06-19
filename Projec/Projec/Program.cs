using Projec;

int int1 = 150;
int int2 = 400;
long long1 = 600;
long long2 = 1000;
short short1 = 17;
short short2 = 15;
decimal decimal1 = 91;
decimal decimal2 = 100;
float float1 = 7.64f;
float float2 = 13.70f;
var list = new ist();
list.ints.Add(4);
list.ints.Add(79);
list.ints.Add(11);
list.ints.Add(369);
list.ints.Add(int1);
list.ints.Add(int2);
list.longs.Add(long1);
list.longs.Add(long2);
list.shorts.Add(short1);
list.shorts.Add(short2);
list.decimals.Add(decimal1);
list.decimals.Add(decimal2);
list.floats.Add(float1);
list.floats.Add(float2);

var FileName = "Mat.txt";

using (var writer = File.AppendText(FileName))
{
    foreach (var myInt in list.ints)
    {
        writer.WriteLine(myInt);
    }
    foreach (var mylong in list.longs)
    {
        writer.WriteLine(mylong);
    }
    foreach (var myshort in list.shorts)
    {
        writer.WriteLine(myshort);
    }
    foreach (var mydecimal in list.decimals)
    {
        writer.WriteLine(mydecimal);
    }
    foreach (var myfloat in list.floats)
    {
        writer.WriteLine(myfloat);
    }
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