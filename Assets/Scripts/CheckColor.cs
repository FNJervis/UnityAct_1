using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
        //Funcion que detecta una colisi�n y llama la funci�n updatecolor que se encuentra en otro script
    {
        collision.gameObject.GetComponent<ChangeColor>().UpdateColor();
    }
}
