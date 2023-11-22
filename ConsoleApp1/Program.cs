// See https://aka.ms/new-console-template for more information
namespace variables
 {
 
class Program
{
  static void Main(string[] args)
  {

Console.WriteLine("what is your first name?");
string firstName =Console.ReadLine();
Console.WriteLine("what is your last name?");
string lastName =Console.ReadLine();
Console.WriteLine("how old are you?");
int age = int.Parse( Console.ReadLine());
Console.WriteLine("nomarat khod ra vared konid");
double nomre1 = double.Parse(Console.ReadLine());
double nomre2 = double.Parse(Console.ReadLine());
double nomre3 = double.Parse(Console.ReadLine());
double nomre4 = double.Parse(Console.ReadLine());
double nomre5 = double.Parse(Console.ReadLine());

double miangin= (nomre1+nomre2+nomre3+nomre4+nomre5) /5.0;

if (miangin>=18)
Console.WriteLine("awlii");
else if (miangin>=12 && miangin<18)
 {Console.WriteLine("khoob bodi");}
else 
{Console.WriteLine("niaz be talash");}
    


}
}
 }
 