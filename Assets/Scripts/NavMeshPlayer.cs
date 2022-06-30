using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPlayer : MonoBehaviour
{
    [SerializeField] Transform _destination;
    NavMeshAgent _navMeshAgent;
    [SerializeField] float playerStartSpeed;
    public static float playerCarSpeed;
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        _navMeshAgent.speed = playerStartSpeed;
        if (_navMeshAgent != null)
        {
            SetDestination();
        }
    }
    private void FixedUpdate()
    {
        playerCarSpeed = _navMeshAgent.speed * 20;
    }
    void SetDestination()
    {
        Debug.Log("SetDestination");
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}
