List<string> films = new List <string>();


string command = "";

while (!command.Equals ("QUIT")) 
{
    Console.WriteLine("");
    Console.WriteLine("COMMAND?");
    string? line = Console.ReadLine();

    if(line == null)
        {
        command = "QUIT";
        continue;
        }


        command = line.ToUpper();
    
    if(command.Equals("ADD"))
    {
        Console.WriteLine("");
        Console.WriteLine("VHS Title?");
        string? film = Console.ReadLine();

        if(film != null)
        {
            films.Add(film);

        }

    }
    else if (command.Equals("LIST"))
    {
        Console.WriteLine("Film List");
        Console.WriteLine("");
        foreach (string film in films)
        {
        Console.WriteLine(film);
        }
    }

    if(command.Equals("REMOVE"))
    {
        Console.WriteLine("");
        Console.WriteLine("Which VHS?");
        string? film = Console.ReadLine();
    
            if(film != null)
        {
            films.Remove(film);
            
        }
    }
}