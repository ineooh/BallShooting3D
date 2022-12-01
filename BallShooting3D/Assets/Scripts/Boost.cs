using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class Boost : MonoBehaviour
{
    [SerializeField]
    private int _boostValue = 10;

    [SerializeField]
    private GameObject _bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Collision: Boost-bullet");
            SpawnBullet();
            Destroy(gameObject); 
        }
    }

    void SpawnBullet()
    {
        float bulletSpeed = 15f;
        for (int i = 0; i < _boostValue; i++)
        {
            Vector3 position = this.gameObject.transform.position;

            GameObject spawnedBullet = Instantiate(_bullet, position, Quaternion.identity);

            Random rnd = new Random();

            Vector3 bulletDir = new Vector3((float)rnd.NextDouble(), 0, (float)rnd.NextDouble());

            spawnedBullet.GetComponent<Rigidbody>().velocity = bulletDir * bulletSpeed;
        }
    }
}
