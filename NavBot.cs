using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavBot : MonoBehaviour
{
    [SerializeField]
    Transform goal;
    void Start()
    {
        var BotAgent = GetComponent<NavMeshAgent>();
        BotAgent.destination = goal.position;
    }

}
