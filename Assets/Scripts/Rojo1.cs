using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rojo1 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Dejar;
    public GameObject Espacio;
    public bool empezar;
    void Start()
    {
        empezar=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(empezar==true)
        {
            Dejar=this.gameObject.transform.GetChild(0).gameObject;
            Dejar.transform.parent = null;
            Dejar.transform.position=new Vector3(Espacio.transform.position.x,Espacio.transform.position.y+1,Espacio.transform.position.z);
            empezar=false;
        }
    }
    public void Empezar()
    {
        empezar=true;
    }
}
