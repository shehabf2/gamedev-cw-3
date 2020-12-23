using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackerGame1 : MonoBehaviour
{
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
}
