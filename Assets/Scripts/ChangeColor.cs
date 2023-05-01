using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //declarar variables
    public Color32 Color;
    public Color32 Color2;
    public Color32 Color3;
    public Color32 Color4;
    bool flag = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //condicionales para un cambio de color al obtener un input de tecla 
        if(Input.GetKeyDown(KeyCode.Alpha1))
            GetComponent<Renderer>().material.color = Color;

        if (Input.GetKeyDown(KeyCode.Alpha2))
            GetComponent<Renderer>().material.color = Color2;
    }
    public void UpdateColor()
    {
        //Funcion para cambiar entre dos colores 
        if (flag)
        {
            flag = false;
            GetComponent<Renderer>().material.color = Color3;
        }
        else
        {
            flag = true;
            GetComponent<Renderer>().material.color = Color4;
        }
    }
}
