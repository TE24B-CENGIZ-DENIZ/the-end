
// last part make a loop for fighting in the end do a random powerup decided by a dice  
// note: if you cannot do the thing you need with the variables you have try a new variable instead.
// cyberpunk turn based fighting system 
Console.WriteLine("The end is nigh");
Console.WriteLine("Hi player you are here to kill the bad guys ");
Console.WriteLine(" chose a character and kill them if you can");


string[] character = ["toy t-rex", "cyborg 1", "penutbutter"];

Console.WriteLine(" your characters are ");
Console.WriteLine($"1: {character[0]}");
Console.WriteLine($"2: {character[1]}");
Console.WriteLine($"3: {character[2]}");
Console.WriteLine("pick the number of the character that you want");

AnswerCorrecter(3, ["1", "2", "3"]);
// int HeroHp = 0;
// int HeroDamage = 0;
// int EnemyHp = 0;
// int Enemydamage = 0;
// (HeroHp, HeroDamage, Enemydamage, EnemyHp) = Dificulties();
// Fighter(HeroHp, HeroDamage, Enemydamage, EnemyHp);


// // // -------------------------------------------------------methods-------------------------------------------------------------


static string AnswerCorrecter(int SetAmoutOfAnswers, string[] TextOnTheBord) //komplex algortihm
{
  string PlayerAnswer = ""; // extract to see which charachter is picked

  while (true)
  {
    bool AnswerdCorrect = false;
    PlayerAnswer = Console.ReadLine();
    for (int i = 0; i < SetAmoutOfAnswers; i++)
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



// //the other way for  answercorrecttor
// // string[] answerlist= ["hi", "hello"];
// // Console.WriteLine(answerlist[0] );
// // Console.WriteLine(answerlist[1]);

// // string playerAnswer= "";

// // while (playerAnswer != "hi" && playerAnswer != "hello" )
// // {
// //     playerAnswer= Console.ReadLine();

// //     if (playerAnswer != "hi" && playerAnswer != "hello")
// //     {
// //         Console.WriteLine("wrong pick another character");
// //     }
// // }

static (int, int, int, int) Dificulties() // ++ hp and dmg for enemy
{
  int HeroHp = 0;
  int HeroDamage = 0;
  int EnemyHp = 0;
  int Enemydamage = 0;

  string[] DificultyList = ["easy baby mode", "normale", "eliv"];

  Console.WriteLine("Now choose a difficultiy from the list");
  Console.WriteLine($"*------{DificultyList[0]}-----*");
  Console.WriteLine($"*------{DificultyList[1]}-----*");
  Console.WriteLine($"*------{DificultyList[2]}-----*");

  string NewPlayerAnswer = AnswerCorrecter(3, ["easy baby mode", "normale", "eliv"]); //rtrn val

  if (NewPlayerAnswer == "easy baby mode")
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
    HeroHp = 10;
    HeroDamage = Random.Shared.Next(2, 6);
    Enemydamage = Random.Shared.Next(1, 4);
    EnemyHp = 5;

  }
  else if (NewPlayerAnswer == "normale") // += where?
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
    HeroHp = 9;
    HeroDamage = Random.Shared.Next(1, 6);
    Enemydamage = Random.Shared.Next(2, 5);
    EnemyHp = 7;
  }
  else if (NewPlayerAnswer == "eliv")
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
    HeroHp = 7;
    HeroDamage = Random.Shared.Next(1, 6);
    Enemydamage = Random.Shared.Next(4, 9);
    EnemyHp = 10;
  }

  return (HeroHp, HeroDamage, Enemydamage, EnemyHp);


}

static void Fighter(int HeroHp, int HeroDamage, int Enemydamage, int EnemyHp) //  nvm you get the insert valiue via transformation of the return valiues 
{
  // end of every loop return the hp of enemys and hero 
  Console.WriteLine("you now get to fight ");

  while (EnemyHp > 0 || HeroHp > 0) // can be && instead
  {
    Console.WriteLine("how many times would you like to attack? pick from 1 to 3 ");

    int AmountOfAttacks;
    string PlayerAnswer = AnswerCorrecter(3, ["1", "2", "3"]);
    Console.WriteLine($"you attack {PlayerAnswer} amount of times");
    int.TryParse(PlayerAnswer, out AmountOfAttacks); //do not need a bool bc answr correcter allready checks 

    EnemyHp = EnemyHp - AmountOfAttacks * HeroDamage; //= new enemy hp 

    Console.WriteLine($"it does {AmountOfAttacks * HeroDamage} damage");
    Console.WriteLine($"enemy has now {EnemyHp} hp");


    Console.WriteLine("the enemy attacks");
    HeroHp = HeroHp - Enemydamage; //hero hp- enemy dmg  = new hero hp
    Console.WriteLine($"it does {Enemydamage} damage");
    Console.WriteLine($"you have now {HeroHp} hp");

    if (HeroHp <= 0)
    {
      Console.WriteLine(" you lose");
      break;
    }
    else if (EnemyHp <= 0)
    {
      Console.WriteLine("you win");
      break;
    }

  }


}

//need pseudo code 
// current agenda QOL








Console.ReadLine();




