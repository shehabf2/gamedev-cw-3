using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerGame1 : MonoBehaviour
{

    int level;
    string currentScreen = "MainMenu";
    string testPass;

  // Start is called before the first frame update
void Start()
{
    ShowMainMenu("Hello Hacker");
}

//Main menu method
void ShowMainMenu(string greeting) {
    Terminal.WriteLine(greeting);
    Terminal.WriteLine("What would you like to hack into?");
    Terminal.WriteLine("Press 1 for coded");
    Terminal.WriteLine("Press 2 for CPES");
    Terminal.WriteLine("Enter your selection: ");
}

    void SetLevel(string selectedLevel)
    {
        if (selectedLevel == "1")
        {

            level = 1;
            Terminal.WriteLine("You selected level 1");
            //SetRandomPass();

        }
        else if (selectedLevel == "2")
        {

            level = 2;
            //SetRandomPass();
            Terminal.WriteLine("You selected level 2");

        }
        else if (selectedLevel == "menu") {
            // take back to main menu
            ShowMainMenu("Welcome Back Hacker!");
        
        }
        else
        {

            Terminal.WriteLine("No 5arabee6 please. Get yourself together.");

        }
    }


    void OnUserInput(string input) {

        if (currentScreen == "MainMenu") {
            // set the level by userinput
            SetLevel(input);

        }
        else if (currentScreen == "password") {
            // checks user input
           // CheckPassword(input);
        }


    }


   /* void StartGame() {

        Terminal.WriteLine("You have selected level: " + level + ". Play now!");
        currentScreen = "password";
    }

    void SetRandomPass()
    {

        StartGame();

        switch (level)
        {

            case 1:
                testPass = "safe";
                break;
            case 2:
                testPass = "safe";
                break;

            default:
                break;

        }

    }


    void CheckPassword(string userInput) {
        if (userInput == testPass)
        {
            Terminal.WriteLine("you won!");
        }
        else {
            Terminal.WriteLine("wrong input :(");
        }
    } */
}