// See https://aka.ms/new-console-template for more information
using hu_4_mdk0101;

Note_class[] notes= new Note_class[2];
for(int i = 0; i < 8; i++)
{
    notes[i]=new Note_class();
    Console.WriteLine("Фамилия:");
    notes[i].LastName= Console.ReadLine();
    Console.WriteLine("Имя:");
    notes[i].FirstName = Console.ReadLine();
    Console.WriteLine("Номер телефона:");
    notes[i].PhoneNumber = Console.ReadLine();
    notes[i].Birthdate = new int[3];
    Console.WriteLine("Дата рождения (день,месяц,год)");
        for(int j = 0; j<3; j++) 
    {
        notes[i].Birthdate[j]=int.Parse(Console.ReadLine());
    }
}
Array.Sort(notes);
Console.WriteLine("Введите фамилию:");
string searchLastName=Console.ReadLine();
bool found = false;
foreach(var note in notes)
{
    if (note.LastName == searchLastName)
    {
        Console.WriteLine($"Имя:{note.FirstName}");
        Console.WriteLine($"Фамилия{note.LastName}");
        Console.WriteLine($"Телефон{note.PhoneNumber}");
        Console.WriteLine($"дата рождения{note.Birthdate}");
        found = true;
        break;
    }
}
if(!found)
{
    Console.WriteLine("No marching record found");
}

