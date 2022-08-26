using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    void Start()
    {
        string[] veggies = {"Carrots", "Cucumbers", "Green Peppers", "Broccoli"};
        
        for(int i = 0; i < veggies.Length; i++)
        {
            Console.WriteLine(veggies[i]);
        }
    }

    void Update()
    {
        
    }
}
