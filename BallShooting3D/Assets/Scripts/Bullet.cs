using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    float moveSpeed = 2.5f;
    Vector3 rot;

    // Start is called before the first frame update
    void Start()
    {
        rot = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        this.transform.rotation = Quaternion.LookRotation(rot);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += rot * Time.deltaTime * moveSpeed;
    }
}
