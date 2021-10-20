using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoger1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject planta1;
    public bool empezar=false;
    public DejarRojo1 otro;
   

    // Update is called once per frame
    void Update()
    {
        if(empezar==true)
        {
            print(planta1.tag);
            planta1.transform.position=new Vector3(gameObject.transform.position.x,gameObject.transform.position.y+1,gameObject.transform.position.z);
            planta1.transform.parent=gameObject.transform;
            empezar=false;
            otro.GetComponent<DejarRojo1>().Empezar();
        }
    }
    public void Activar()
    {
        empezar=true;
    }
}
