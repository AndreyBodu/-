StreamReader str = new StreamReader("task1.txt");
string Text = str.ReadToEnd();
int count = 0;
int max_count = 0;
for (int i = 0; i < Text.Length; i++)
{
    if (Text[i] == 'A' || Text[i] == 'O' || Text[i] == 'E' || Text[i] == 'U' || Text[i] == 'Y' || Text[i] == 'I')
    {
        if (max_count < count)
        {
            max_count = count;
        }
        
        count=0;
    }
    else
    {
        count++;
    }


}
Console.WriteLine(max_count);
Console.WriteLine(str.ReadToEnd());