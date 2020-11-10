using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavBot : MonoBehaviour
{
    [SerializeField]
    Transform goal; //Create Transform variable "goal"
    void Start()
    {
        var BotAgent = GetComponent<NavMeshAgent>(); //Create variable "BotAgent" and Get NavMeshAgent component
        BotAgent.destination = goal.position; // Set destination of "BotAgent" equal position of "goal"
    }

}
