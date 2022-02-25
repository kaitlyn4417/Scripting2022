using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    void Start()
    {
      int numberSum = 539 + 243 + 189;

        if(numberSum > 1000)
        {
          Console.WriteLine("Number is more than 1000");
        }
        else
        {
          Console.WriteLine("Number is less than 1000");
        }
    }

    void Update()
    {
        
    }
}
