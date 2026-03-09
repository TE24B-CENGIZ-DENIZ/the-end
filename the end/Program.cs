 // cyberpunk rouglike intro
 Console.WriteLine("The end is nigh");
 Console.WriteLine("Hi player you are here to kill the bad guys ");
 Console.WriteLine(" chose a character and kill them if you can");


 string[] character= ["toy t-rex", "cyborg 1", "penutbutter"];

 Console.WriteLine($" your characters are {character}"); //doesn't work yet
 answerCorrecter(3, ["toy t-rexy", "cyborg 1", "penutbutter" ]);


// // dificulties
// // -------------------------------------------------------methods-------------------------------------------------------------



// Console.ReadLine();









static void answerCorrecter(int setAmoutOfAnswers, string[] textOnTheBord) //komplex algortihm
{
    string playerAnswer = "";

    for (int i = 0; i < setAmoutOfAnswers - 1; i++)
    {
        while (playerAnswer != textOnTheBord[i])  
        {
            playerAnswer = Console.ReadLine();

            if (playerAnswer != textOnTheBord[i])
            {
                Console.WriteLine("pick a character");
            }

        }

    }

}



//the other way for  answercorrecttor
// string[] answerlist= ["hi", "hello"];
// Console.WriteLine(answerlist[0] );
// Console.WriteLine(answerlist[1]);

// string playerAnswer= "";

// while (playerAnswer != "hi" && playerAnswer != "hello" )
// {
//     playerAnswer= Console.ReadLine();

//     if (playerAnswer != "hi" && playerAnswer != "hello")
//     {
//         Console.WriteLine("wrong pick another character");
//     }
// }

Console.ReadLine();




