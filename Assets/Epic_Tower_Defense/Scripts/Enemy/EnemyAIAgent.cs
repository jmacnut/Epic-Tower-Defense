using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ETD.Scripts.Enemy
{
    public class EnemyAIAgent : MonoBehaviour
    {
        private NavMeshAgent _agent;

        private void OnEnable()
        {
            // performance cost in onenable() - put in else block
            // _agent = GetComponent<NavMeshAgent>();

            if (_agent != null)
            {
                _agent.SetDestination(Vector3.zero);
            }
            else
            {
                // Debug.LogError("EnemyAIAgent::OnEnable: NavMeshAgent _agent is NULL.");
                _agent = GetComponent<NavMeshAgent>();
                _agent.SetDestination(Vector3.zero);
            }

            // or

            try
            {
                _agent.SetDestination(Vector3.zero);
            }
            catch
            {
                // Debug.LogError("EnemyAIAgent::OnEnable: NavMeshAgent _agent is NULL.");
                _agent = GetComponent<NavMeshAgent>();
                _agent.SetDestination(Vector3.zero);
            }
        }
    } 
}
