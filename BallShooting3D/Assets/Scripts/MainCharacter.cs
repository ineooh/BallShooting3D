using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    private void Start()
    {
        // bullet don't collision with bullet
        Physics.IgnoreLayerCollision(7, 7, true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            LevelManager.Instance.LoadScene("LevelScene");
        }
    }
}
