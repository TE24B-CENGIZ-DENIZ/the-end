
Console.WriteLine("The end is nigh");
Console.WriteLine("Hi player you are here to kill the bad guys ");
Console.WriteLine(" chose a character and kill them if you can");


string[] character = ["toy t-rex", "cyborg 1", "penutbutter"]; //list of characters you can choose 

Console.WriteLine(" your characters are ");
Console.WriteLine($"1: {character[0]}");
Console.WriteLine($"2: {character[1]}");
Console.WriteLine($"3: {character[2]}");
Console.WriteLine("pick the number of the character that you want");

AnswerCorrecter(3, ["1", "2", "3"]);
int HeroHp = 0;
int HeroDamage = 0;
int EnemyHp = 0;
int Enemydamage = 0;
(HeroHp, HeroDamage, Enemydamage, EnemyHp) = Dificulties();
Fighter(HeroHp, HeroDamage, Enemydamage, EnemyHp);


// // // -------------------------------------------------------methods-------------------------------------------------------------


static string AnswerCorrecter(int SetAmoutOfAnswers, string[] TextOnTheBord) 
{
  string PlayerAnswer = ""; 

  while (true)
  {
    bool AnswerdCorrect = false;
    PlayerAnswer = Console.ReadLine();
    for (int i = 0; i < SetAmoutOfAnswers; i++) // loops and chacks every single number in the list to see if the content matches (abt the entire for loop)
    {

      if (PlayerAnswer == TextOnTheBord[i])
      {
        AnswerdCorrect = true;
        Console.WriteLine("you did it");


      }


    }

    if (AnswerdCorrect == true)
    {
      break;
    }
    else
    {
      Console.WriteLine("pick one of the options");

    }

  }
  return PlayerAnswer;

}





static (int, int, int, int) Dificulties() 
{
  int HeroHp = 0;
  int HeroDamage = 0;
  int EnemyHp = 0;
  int EnemyDamage = 0;

  string[] DificultyList = ["easy baby mode", "normale", "eliv"];

  Console.WriteLine("Now choose a difficultiy from the list");
  Console.WriteLine($"*------{DificultyList[0]}-----*");
  Console.WriteLine($"*------{DificultyList[1]}-----*");
  Console.WriteLine($"*------{DificultyList[2]}-----*");

  string NewPlayerAnswer = AnswerCorrecter(3, ["easy baby mode", "normale", "eliv"]); 

  if (NewPlayerAnswer == "easy baby mode")
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
    HeroHp = 10;
    HeroDamage = Random.Shared.Next(2, 6);
    EnemyDamage = Random.Shared.Next(1, 4);
    EnemyHp = 5;

  }
  else if (NewPlayerAnswer == "normale") 
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
    HeroHp = 9;
    HeroDamage = Random.Shared.Next(1, 6); //random hero damage
    EnemyDamage = Random.Shared.Next(2, 5); //random enemy damage
    EnemyHp = 7;
  }
  else if (NewPlayerAnswer == "eliv")
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
    HeroHp = 7;
    HeroDamage = Random.Shared.Next(1, 6);
    EnemyDamage = Random.Shared.Next(4, 9);
    EnemyHp = 10;
  }

  return (HeroHp, HeroDamage, EnemyDamage, EnemyHp); // returned variables


}

static void Fighter(int HeroHp, int HeroDamage, int EnemyDamage, int EnemyHp) 
{
  
  Console.WriteLine("you now get to fight ");

  while (EnemyHp > 0 || HeroHp > 0) 
  {
    Console.WriteLine("how many times would you like to attack? pick from 1 to 3 ");

    int AmountofAttacks;
    string PlayerAnswer = AnswerCorrecter(3, ["1", "2", "3"]);
    Console.WriteLine($"you attack {PlayerAnswer} amount of times");
    int.TryParse(PlayerAnswer, out AmountofAttacks);  

    EnemyHp = EnemyHp - AmountofAttacks * HeroDamage; 

    Console.WriteLine($"it does {AmountofAttacks * HeroDamage} damage");
    Console.WriteLine($"enemy has now {EnemyHp} hp");

    if (EnemyHp <= 0)
    {
      Console.WriteLine("you win");
      break;
    }


    Console.WriteLine("the enemy attacks");
    HeroHp = HeroHp - EnemyDamage; 
    Console.WriteLine($"it does {EnemyDamage} damage");
    Console.WriteLine($"you have now {HeroHp} hp");

    if (HeroHp <= 0)
    {
      Console.WriteLine(" you lose");
      break;
    }


  }


}











Console.ReadLine();




