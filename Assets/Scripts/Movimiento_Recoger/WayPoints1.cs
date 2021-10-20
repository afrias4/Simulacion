using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints1 : MonoBehaviour
{
    public GameObject[] waypoints;
    int current=0;
    float rotSpeed;
    public float speed;
    float Wpradius=0.05f;
    bool stop=false;
    public Recoger1 otro;
    

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(waypoints[current].transform.position,transform.position)<Wpradius && stop==false)
        {
            current++;
            if(current>=waypoints.Length)
            {
                stop=true;
                current=0;
                Invoke("RecogerPlanta1",1.2f);
                
                
            }
        }
        if(stop==false)
        {
            transform.position=Vector3.MoveTowards(transform.position,waypoints[current].transform.position,Time.deltaTime*speed);
        }
    }
    void RecogerPlanta1()
    {
        otro.GetComponent<Recoger1>().Activar();
    }
}
