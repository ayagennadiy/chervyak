using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] GameObject world;

    [SerializeField] GameObject universe;

    public float move = 1;

    void Update()
    {
        world.transform.position -= transform.forward * move * Time.deltaTime;

    }

    public void right()
    {
        universe.transform.Rotate(new Vector3(0, -10, 0));
    }

    public void left()
    {
        universe.transform.Rotate(new Vector3(0, 10, 0));
    }
}
