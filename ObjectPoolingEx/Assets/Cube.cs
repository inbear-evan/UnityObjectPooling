using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, InterfacePool
{
    public float upForce = 1f;
    public float sideForce = 0.1f;

    // Start is called before the first frame update
    public void OnObjectSpawn()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);
        GetComponent<Rigidbody>().velocity = force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
