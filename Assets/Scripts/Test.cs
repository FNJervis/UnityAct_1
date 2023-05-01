using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Variables
    int int_num = 10;
    double dec_num = 3.1415;
    char letter= 'A';
    string text = "Hello";
    bool bol= false;
    // Start is called before the first frame update
    void Start()
    {
        //Mensajes hacia el log de unity utilizando diferentes variables
        Debug.Log("The int is" + int_num);
        Debug.Log("The dec is" + dec_num);
        Debug.Log("The letter is" + letter);
        Debug.Log("The text is" + text);
        Debug.Log("The bol is" + bol);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
