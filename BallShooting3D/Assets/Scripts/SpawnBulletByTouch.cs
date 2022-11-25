using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletByTouch : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    private float delayTime = 0.2f;
    private float delay = 0.0f;

    Rigidbody _mcRb;

    // Start is called before the first frame update
    void Start()
    {
        _mcRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, float.MaxValue))
        {
            var lookDir = hit.point - transform.position;
            float angle = Mathf.Atan2(lookDir.x, lookDir.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, angle, transform.rotation.z));

            if (Input.GetButtonUp("Fire1") && delay <= 0)
            {
                lookDir.y = 0;
                delay = delayTime;

                GameObject spawnedBullet = Instantiate(bullet,
                                                this.transform.position + new Vector3(0, 1.55f, 0),
                                                Quaternion.identity);

                //spawnedBullet.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0 , 0));

                float minXZ = Mathf.Min(lookDir.x, lookDir.z);
                if (minXZ < 1)
                {
                    float mul = (1 / minXZ) + 1;
                    lookDir.x *= mul;
                    lookDir.z *= mul;
                }

                spawnedBullet.GetComponent<Rigidbody>().velocity = lookDir * 2.5f;
            }
        }
    }
}
