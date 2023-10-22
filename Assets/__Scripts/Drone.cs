using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float gameRestartDelay = 2f;
    public GameObject projectilePrefab;
    public float projectileSpeed = 40;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TempFire();
        }
    }
    void TempFire()
    {
        GameObject projGO = Instantiate<GameObject>(projectilePrefab);
        projGO.transform.position = transform.position;
        Rigidbody rigidB = projGO.GetComponent<Rigidbody>();
        rigidB.velocity = Vector3.up * projectileSpeed;
    }
}
