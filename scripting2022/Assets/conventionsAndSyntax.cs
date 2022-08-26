using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conventionsAndSyntax : MonoBehaviour
{
    void Start()
    {
         //this line tells me the x position of my object

        /*first line
         * second line
         * */
        Debug.Log(transform.position.x);
        
        if(transform.position.y <= 5f)
        {
            Debug.Log ("I'm about to hit the ground!");
        }
    }
		void Update()
    		{
        
    		}

}
