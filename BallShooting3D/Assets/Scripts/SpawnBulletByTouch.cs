using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletByTouch : MonoBehaviour
{
    Rigidbody _mcRb;

    // Start is called before the first frame update
    void Start()
    {
        _mcRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, float.MaxValue))
        {
            Vector3 mousePos = hit.point;
            //point.transform.position = hit.point;

            var lookDir = hit.point - transform.position;
            float angle = Mathf.Atan2(lookDir.x, lookDir.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, angle, transform.rotation.z));
        }


        ////if (Input.GetButton("Fire1"))
        ////{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Plane")
        //    {
        //        //Vector3 relativePos = hit.point - _mainCharacter.transform.position;

        //        //Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        //        //Vector3 v = rotation.ToEulerAngles();


        //        //_mainCharacter.transform.rotation = rotation;

        //        Vector3 lookDir = hit.point - _mainCharacter.transform.position;

        //        float angle = Mathf.Atan2(lookDir.z, lookDir.x) * Mathf.Rad2Deg - 90f;

        //        Debug.Log(angle);

        //    //_mainCharacter.transform.rotation = new Quaternion(0, angle, 0, 1);
        //    //_mainCharacter.transform.Rotate(new Vector3(0, angle, 0));
        //    _mainCharacter.transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
        //}
        ////}
        ///



    }
}
