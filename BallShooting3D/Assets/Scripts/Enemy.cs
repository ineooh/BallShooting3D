using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private bool _isBoss = false;
    private int _healthRemain = 10; // for boss only

    // Start is called before the first frame update
    void Start()
    {
        if (_isBoss == true)
        {
            this.transform.localScale = Vector3.one;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if (!_isBoss)
            {
                Destroy(gameObject);
            } else
            {
                _healthRemain--;
                if (_healthRemain == 0)
                {
                    Destroy(gameObject);
                }
            }
            
        } else if (collision.gameObject.CompareTag("MainCharacter"))
        {
            // TODO: Replace this to "REAL" GAMEOVER state
            //Debug.Log("GAMEOVER");
        }
    }
}
