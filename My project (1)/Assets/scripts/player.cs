using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] GameObject world;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void forward()
    {
        world.transform.position += transform.forward * Time.deltaTime;
    }

    public void back()
    {
        world.transform.position -= transform.forward * Time.deltaTime;
    }

    public void right()
    {
        world.transform.position += transform.right * Time.deltaTime;
    }

    public void left()
    {
        world.transform.position -= transform.right * Time.deltaTime;
    }
}
