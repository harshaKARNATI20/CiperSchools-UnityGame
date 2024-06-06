using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*   for(int i= 0; i<= 10; i++)
           {
               Debug.Log(i);
           }
        int i = 0;
        while (i <= 10)
        {
            Debug.Log("The vale of i is " + i);
            i++;
        }
        */
        int i = 0;
        do
        {
            Debug.Log("Value of i is : " + i);
            i++;
        } while (i <= 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
