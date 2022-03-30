using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coreSpin : MonoBehaviour
{
    public float rx;

    public float ry;

    public float rz;

    public float fl;

    float t;

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(rx,ry,rz) * Time.deltaTime);
        t += Time.deltaTime;
        gameObject.transform.position += new Vector3(0, 1, 0) * Time.deltaTime * fl * (t - Mathf.Round(t));
    }
}
