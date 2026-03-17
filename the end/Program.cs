

// cyberpunk rouglike intro
Console.WriteLine("The end is nigh");
Console.WriteLine("Hi player you are here to kill the bad guys ");
Console.WriteLine(" chose a character and kill them if you can");


string[] character = ["toy t-rex", "cyborg 1", "penutbutter"];

Console.WriteLine(" your characters are ");
Console.WriteLine(character[0]);
Console.WriteLine(character[1]);
Console.WriteLine(character[2]);
answerCorrecter(3, ["toy t-rex", "cyborg 1", "penutbutter"]);


// // // dificulties complex alg
// // // -------------------------------------------------------methods-------------------------------------------------------------


static void answerCorrecter(int setAmoutOfAnswers, string[] textOnTheBord) //komplex algortihm
{
  string playerAnswer = ""; // extract to see which charachter is picked
  playerAnswer = Console.ReadLine();

  for (int i = 0; i < setAmoutOfAnswers - 1; i++)
  {

    while (playerAnswer != textOnTheBord[i])
    {
     
      
      if (playerAnswer != textOnTheBord[setAmoutOfAnswers-1])
      {
        Console.WriteLine("pick a character");
      }
      

    }

  }


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





//need type converting (stamina option), random chance,pseudo code,if and else, return valiue, do not need complex algorittms for the entire code


//story





Console.ReadLine();




