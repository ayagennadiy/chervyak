using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class world : MonoBehaviour
{
    public GameObject bcoin;
    public GameObject scoin;
    public GameObject gcoin;

    public GameObject carrot;
    public GameObject grib;
    public GameObject kapusta;

    public GameObject dub;
    public GameObject elka;

    public GameObject noj;
    public GameObject gun;

    public GameObject word;
    void Start()
    {
        GameObject[] zones = { bcoin, scoin, gcoin, carrot, grib, kapusta, dub, elka, noj, gun };
        foreach (GameObject i in zones)
        {
            for (int j = 0; j <= 150; j++)
            {
                if (i == noj)
                {
                    GameObject a = Instantiate(i, new Vector3(Random.Range(-500, 500), i.transform.position.y, Random.Range(-500, 500)), i.transform.rotation);
                    a.transform.SetParent(word.transform);
                }
                else
                {
                    GameObject a = Instantiate(i, new Vector3(Random.Range(-500, 500), i.transform.position.y, Random.Range(-500, 500)), new Quaternion(i.transform.rotation.x, Random.rotation.y, i.transform.rotation.z, i.transform.rotation.w));
                    a.transform.SetParent(word.transform);
                }
                
            }
        }
    }
}
