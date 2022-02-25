using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    void Start()
    {
        int fruit = 3;
        
        switch (fruit)
        {
            case 1:
                Console.WriteLine("You have a banana");
                break;
            case 2:
                Console.WriteLine("You have a strawberry");
                break;
            case 3:
                Console.WriteLine("You have an apple");
                break;
            case 4:
                Console.WriteLine("You have grapes");
                break;
        }
    }
    
    void Update()
    {
        
    }
}
