using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    [SerializeField] GameObject world;

    [SerializeField] GameObject universe;

    public float move = 1;

    bool isstop = false;

    GameObject dec;

    public Text coins;

    public int c;

    public Text points;

    public int p;

    public Text health;

    public int h;

    void Update()
    {
        if (!isstop)
        {
            world.transform.position -= transform.forward * move * Time.deltaTime;
        }

    }

    public void right()
    {
        universe.transform.Rotate(new Vector3(0, -10, 0));
    }

    public void left()
    {
        universe.transform.Rotate(new Vector3(0, 10, 0));
    }

    public void attack()
    {
        try
        {
            Destroy(dec);
        }
        catch
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "decor":
                isstop = true;
                dec = other.gameObject;
                break;
            case "bronzecoin":
                c += 1;
                break;
            case "silvercoin":
                c += 3;
                break;
            case "goldcoin":
                c += 10;
                break;
            case "carrot":
                p += 10;
                break;
            case "kapusta":
                p += 20;
                break;
            case "mushroom":
                p += 5;
                break;
            case "trap":
                h -= 1;
                break;
            default:
                Debug.Log("shit");
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case "decor":
                isstop = false;
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
                break;
        }
    }
}
