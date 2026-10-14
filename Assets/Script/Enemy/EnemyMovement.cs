using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // Inspector
    [SerializeField] Transform target;
    
    // Private
    NavMeshAgent agent;
    
    
    // === Life Cycle === //
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
}
