using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown ( KeyCode.Alpha1 ))
		{
            anim.SetInteger("state", 1);
		}
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetInteger("state", 2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetInteger("state", 3);
        }
    }
}
