using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] GameObject world;

    Vector3 move;

    void Start()
    {
        move = transform.forward;
    }

    void Update()
    {
        world.transform.position -= move * Time.deltaTime;
    }

    public void forward()
    {
        move = transform.forward;
    }

    public void back()
    {
        move = -transform.forward;
    }

    public void right()
    {
        move = transform.right;
    }

    public void left()
    {
        move = -transform.right;
    }
}
