using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DejarRojo1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] waypoints;
    int current=0;
    float rotSpeed;
    public float speed;
    float Wpradius=0.05f;
    bool stop=false;
    bool empezar;
    public Rojo1 otro;
    void Start()
    {
        empezar=false;
    }

    // Update is called once per frame
    void Update()
    {
       if(empezar==true)
       {
            if(Vector3.Distance(waypoints[current].transform.position,transform.position)<Wpradius && stop==false)
            {
                current++;
                if(current>=waypoints.Length)
                {
                    stop=true;
                    current=0;
                    empezar=false;
                    Invoke("Dejar",1.0f);
                    
                }
            }
            if(stop==false)
            {
                transform.position=Vector3.MoveTowards(transform.position,waypoints[current].transform.position,Time.deltaTime*speed);
            }
       }
    }
    public void Empezar()
    {
        empezar=true;
    }
    void Dejar()
    {
        otro.GetComponent<Rojo1>().Empezar();
    }
}
