using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    public GameObject cubePrefabs;
    public string tagName = "Cube";
    ObjectPooler objectPooler;
    // Start is called before the first frame update
    void Start()
    {
        objectPooler = ObjectPooler.instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Instantiate(cubePrefabs, transform.position, Quaternion.identity);
        objectPooler.SpawnFromPool(tagName, transform.position, Quaternion.identity);
    }


}
