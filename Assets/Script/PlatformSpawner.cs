using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public float spawnlocation = 8.15f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))

        {
            Instantiate(platformPrefab, new Vector3(0, 0,spawnlocation), Quaternion.identity);
        }
    }

}
