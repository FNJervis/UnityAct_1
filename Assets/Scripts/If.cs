using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    //variable publica, es decir se puede acceder entre otros scripts y ddesde uinity
    public int age = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //condicional para imprimir un mensaje en el log de unity
        if (age > 21)
            Debug.Log("you are old enough");
        else
            Debug.Log("you are not old enough");
    }
}
