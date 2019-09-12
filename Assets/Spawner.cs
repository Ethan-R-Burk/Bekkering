using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject nailPrefab;

    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
        {
            SpawnNail();
        }
    }

    void SpawnNail()
    {
        Instantiate(nailPrefab, transform.position, transform.rotation);
    }

}
