using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // Awake
    NavMeshAgent agent;
    
    
    // === Life Cycle === //
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void Chase(Transform target)
    {
        if (target is null) return;
        
        agent.SetDestination(target.position);
    }
}
