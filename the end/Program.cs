
// note: if you cannot do the thing you need with the variables you have try a new variable instead.
// cyberpunk rouglike intro
Console.WriteLine("The end is nigh");
Console.WriteLine("Hi player you are here to kill the bad guys ");
Console.WriteLine(" chose a character and kill them if you can");


string[] character = ["toy t-rex", "cyborg 1", "penutbutter"];

Console.WriteLine(" your characters are ");
Console.WriteLine(character[0]);
Console.WriteLine(character[1]);
Console.WriteLine(character[2]);
AnswerCorrecter(3, ["toy t-rex", "cyborg 1", "penutbutter"]);
Dificulties();


// // // dificulties complex alg
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

      if (PlayerAnswer != TextOnTheBord[i])
      {

        Console.WriteLine("pick one of the options");
      }
      else
      {
        AnswerdCorrect = true;
        Console.WriteLine("you did it");
        
      }

    }

    if (AnswerdCorrect == true)
    {
      break;
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

static void Dificulties() // ++ hp and dmg for 
{
  string[] DificultyList = ["easy baby mode", "normale", "eliv"];

  Console.WriteLine("Now choose a difficultiy from the list");
  Console.WriteLine($"*------{DificultyList[0]}-----*");
  Console.WriteLine($"*------{DificultyList[1]}-----*");
  Console.WriteLine($"*------{DificultyList[2]}-----*");

  string NewPlayerAnswer = AnswerCorrecter(3, ["easy baby mode", "normale", "eliv"]); //rtrn var

  if (NewPlayerAnswer == "easy baby mode")
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
  }
  else if (NewPlayerAnswer == "normale")
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
  }
  else if (NewPlayerAnswer == "eliv")
  {
    Console.WriteLine($"you have picked {NewPlayerAnswer} dificulty ");
  }




}



//need type converting (stamina option), random chance,pseudo code,if and else, return valiue, do not need complex algorittms for the entire code


//story





Console.ReadLine();




