
string name = "Ewa";
var gender = "Female";
var age = 25l;
if (gender == "Female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30) 
{
    Console.WriteLine("Ewa,lat 30");
}
else if (gender == "male" && age < 18) 
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Nie spełnia żadnego warunku");
}
        