// See https://aka.ms/new-console-template for more information
static void main(string[] args){
Console.WriteLine("welcom to my first game ");
Console.WriteLine("this game is accessible for children ");
Console.WriteLine("how old are you?");
int age = int.Parse(Console.ReadLine());
if (age<15)
{Console.WriteLine("welcome,i hope you enjoy the game");}
else
{
    Console.WriteLine("go and play call of duty...");
}
Console.WriteLine("start the game");
Console.WriteLine("enter your name player1: ");
string name1 = Console.ReadLine();
Console.WriteLine("enter your name player2:");
string name2 = Console.ReadLine();
Console.WriteLine("choose rock,paper or scissers player1: ");
string choose1 = Console.ReadLine();
Console.WriteLine("choose rock,paper or scissers player2: ");
string choose2 = Console.ReadLine();
if (choose1==choose2)
{ Console.WriteLine("mosavi");
    
}
if (choose1=="rock" && choose2=="scissers")
{Console.WriteLine("player1 is winner");
    
}
if (choose1=="rock" && choose2=="paper")
{Console.WriteLine("player2 is winner");
    
}
Console.ReadKey();












}
