using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoopsWithArrays : MonoBehaviour
{

    void Start()
    {
        string[] evenNumbers = {"two", "four", "six", "eight", "ten"};

        foreach (string i in evenNumbers)
        {
            Console.WriteLine(i);
        }
    }

    void Update()
    {
        
    }
}
