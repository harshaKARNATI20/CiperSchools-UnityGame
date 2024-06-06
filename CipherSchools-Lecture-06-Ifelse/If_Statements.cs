using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
    //If the age is above 18,the person can vote
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if (age >= 18)
        {
            Debug.Log("You're above 18 years.You can Vote");
        }
        else
        {
            Debug.Log("You can't Vote as you're below 18 yrs age");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
