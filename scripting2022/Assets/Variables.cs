using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    void Start()
    {
		string name = "My name is Kaitlyn Graf";
		string ageIntro = "My age is:";
        int age = 19;

		Console.WriteLine(name);
		Console.WriteLine(ageIntro);
		Console.WriteLine(age);

    }

    void Update()
    {
        
    }
}
