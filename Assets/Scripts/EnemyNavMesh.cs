using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavMesh : MonoBehaviour
{
    [SerializeField] Transform _destination;
    NavMeshAgent _navMeshAgent;
    [SerializeField] float enemySpeed;
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        
        if (_navMeshAgent != null)
        {
            SetDestination();
        }
    }
    private void FixedUpdate()
    {
        _navMeshAgent.speed = enemySpeed + 0.3f;
    }
    void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}
