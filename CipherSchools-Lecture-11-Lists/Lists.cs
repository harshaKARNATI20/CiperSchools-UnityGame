using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    // Start is called before the first frame update
     List<string> myList = new List<string>();
    void Start()
    {
        myList.Add("John");
        myList.Add("Harsha");
        myList.Add("Sudha");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
