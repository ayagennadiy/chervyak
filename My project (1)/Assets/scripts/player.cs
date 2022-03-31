using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    [SerializeField] GameObject world;

    [SerializeField] GameObject universe;

    public float r = 30;

    public float move = 1;

    bool isstop = false;

    GameObject dec;

    public Text coins;

    public int c;

    public Text points;

    public int p;

    public Text health;

    public int h = 10;

    void Start()
    {
        coins.text = "coins: " + c;
        points.text = "points: " + p;
        health.text = "health: " + h;
    }

    void Update()
    {
        if (!isstop)
        {
            world.transform.position -= transform.forward * move * Time.deltaTime;
        }

    }

    public void right()
    {
        universe.transform.Rotate(new Vector3(0, -r, 0));
    }

    public void left()
    {
        universe.transform.Rotate(new Vector3(0, r, 0));
    }

    public void attack()
    {
        try
        {
            Destroy(dec);
            isstop = false;

        }
        catch
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("shit1");
        switch (other.tag)
        {
            case "decor":
                isstop = true;
                Debug.Log("shit2");
                dec = other.gameObject;
                break;
            case "bronzecoin":
                c += 1;
                Debug.Log("shit3");
                break;
            case "silvercoin":
                c += 3;
                Debug.Log("shit4");
                break;
            case "goldcoin":
                c += 10;
                Debug.Log("shit5");
                break;
            case "carrot":
                p += 10;
                Debug.Log("shit6");
                break;
            case "kapusta":
                p += 20;
                Debug.Log("shit7");
                break;
            case "mushroom":
                p += 5;
                Debug.Log("shit8");
                break;
            case "trap":
                h -= 1;
                Debug.Log("shit9");
                break;
            default:
                Debug.Log("shit");
                break;
        }
        coins.text = "coins: " + c;
        points.text = "points: " + p;
        health.text = "health: " + h;
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case "decor":
                isstop = false;
                Debug.Log("shiit");
                break;
            case "bronzecoin":
                Destroy(other.gameObject);
                break;
            case "silvercoin":
                Destroy(other.gameObject);
                break;
            case "goldcoin":
                Destroy(other.gameObject);
                break;
            case "carrot":
                Destroy(other.gameObject);
                break;
            case "kapusta":
                Destroy(other.gameObject);
                break;
            case "mushroom":
                Destroy(other.gameObject);
                break;
            case "trap":
                break;
            default:
                Debug.Log("shet");
                break;
        }
    }
}
