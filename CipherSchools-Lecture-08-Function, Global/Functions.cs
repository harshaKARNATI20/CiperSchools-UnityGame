using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(Add(2,4));
    }

    // Update is called once per frame
    void Update()
    {
        //Add();
    }
    //Customized Function
    public int Add(int num1,int num2)
    {
        int result = num1 + num2;
        Debug.Log("This is Add Function");
        return result;
    }
}
