using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private PlacementIndicator placementIndicator;

    void Start ()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    void Update ()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            // Rastgele bir konum üretmek 
            Vector3 randomPosition = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));

            // Yaratılan nesneyi PlacementIndicator'ün konumuna ekle
            GameObject obj = Instantiate(objectToSpawn, placementIndicator.transform.position + randomPosition, placementIndicator.transform.rotation);
        }
    }
}