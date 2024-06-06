using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional_Statements : MonoBehaviour
{
    //If the age is above 18,the person can vote
    //public int age;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        /* if (age < 18)
         {
             Debug.Log("You are a Teenager");
         }
         else if (age >= 18 && age<60)
         {
             Debug.Log("You're above 18 years and below 60 years.You can Vote");
         }
         else
         {
             Debug.Log("You are Old");
         }*/
        switch(score){
            case 10:
                Debug.Log("Perfect Score");
                break;
            case 5:
                Debug.Log("The score is half");
                break;
            default:
                Debug.Log("The Score is not good enough");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
