// // cyberpunk rouglike intro
// Console.WriteLine("The end is nigh");
// Console.WriteLine("Hi player you are here to kill the bad guys ");
// Console.WriteLine(" chose a character and kill them if you can");


// string[] character= ["toy t-rex", "cyborg 1", "penutbutter"];

// Console.WriteLine($" your characters are {character}");
// string characterChosen= Console.ReadLine();


// // dificulties
// // -------------------------------------------------------methods-------------------------------------------------------------



// Console.ReadLine();









static void answerCorrecter(int setAmoutOfAnswers, string[] textOnTheBord)
{


    string playerAnswer = Console.ReadLine();


    for (int i = 0; i < setAmoutOfAnswers - 1; i++)
    {
        while (playerAnswer != textOnTheBord[i])
        {
            Console.WriteLine("pick a character");
        }

        break;

    }

}

answerCorrecter(2, ["test", "test 2"]);

Console.ReadLine();




