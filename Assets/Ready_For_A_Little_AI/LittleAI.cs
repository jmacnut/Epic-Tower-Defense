using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Ready_For_A_Little_AI.Scripts
{
    public class LittleAI : MonoBehaviour
    {
        // define target
        [SerializeField] private GameObject _target;

        // NavMeshAgent handle
        [SerializeField] private NavMeshAgent _agent;


        void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
            _agent.SetDestination(_target.transform.position);
        }

        void Update()
        {
            // use NavMesh Agent to move toward the target
            // Docs: NavMeshAgent.SetDestination

        }
    } 
}
