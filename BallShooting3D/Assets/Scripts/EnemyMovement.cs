using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    [SerializeField]
    private NavMeshAgent agent;

    void Update()
    {
        agent.SetDestination(new Vector3(0, 0, 0.38f));
    }
}
