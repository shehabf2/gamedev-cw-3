using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerGame1 : MonoBehaviour
{

    int level;
    string currentScreen = "MainMenu";
    string password;
    string [] level1Pass = { "Buckeyes", "Brutus", "Ohio", "Flyers"};
    string[] level2Pass = {"Harbor", "Michigan", "Snow", "Spartans"};

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
            StartGame();

        }
        else if (selectedLevel == "2")
        {

            level = 2;
            StartGame();

        }
        else
        {

            Terminal.WriteLine("No 5arabee6 please. Get yourself together.");

        }
    }


    void OnUserInput(string input) {

        if (input == "menu")
        {
            ShowMainMenu("Welcome Back Hacker.");
            currentScreen = "MainMenu";
            password = null;
        }
        else if (currentScreen == "MainMenu")
        {

            SetLevel(input);

        }
        else if (currentScreen == "password") {
            CheckPassword(input);
        }

    }


    void StartGame() {
        currentScreen = "password";
        Terminal.WriteLine("You have selected level: " + level + ". Hack now!");
        SetRandomPass();
    }

    void CheckPassword(string userInput)
    {
        if (userInput == password)
        {
            Terminal.WriteLine("you won!");
            Terminal.WriteLine("Type menu to go back to the main menu winner!");
        }
        else
        {
            Terminal.WriteLine("wrong input :( check again or go to menu");
        }
    }

    void SetRandomPass()
    {

        switch (level)
        {
            case 1:
                password = level1Pass[Random.Range(0, level1Pass.Length)];
                break;
            case 2:
                password = level2Pass[Random.Range(0, level2Pass.Length)];
                break;
            default:
                break;
        }
        Terminal.WriteLine(password.Anagram());

    }



}