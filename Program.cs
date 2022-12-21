Console.WriteLine("Input the data, separated by commas.");
string[] massive = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);    
string[] newmassive = new string[massive.Length];                                           
Console.WriteLine("New array:");
for (int i = 0; i < massive.Length; i++)                                                    
{
    if (massive[i].Length <= 3)                                                             
    {
        newmassive[i] = massive[i];
        Console.Write(newmassive[i] + " ");
    }    
}
