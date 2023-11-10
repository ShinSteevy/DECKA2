using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEcoBrick : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int numberOfObjectsToSpawn;

    private void Start()
    {
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(11, -11), Random.Range(4, -7));
            Instantiate(objectToSpawn, randomPos, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        }
    }


}
