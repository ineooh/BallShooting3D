using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletByTouch : MonoBehaviour
{
    [SerializeField] private GameObject _mainCharacter;
    [SerializeField] private GameObject _bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Plane")
            {
                Instantiate(_bullet, hit.point, Quaternion.identity);
            }
        }
    }
}
