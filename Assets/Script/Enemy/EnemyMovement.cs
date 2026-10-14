using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Inspector
    [SerializeField] Transform target;
    
    // Private
    UnityEngine.AI.NavMeshAgent agent;
    
    
    // === Life Cycle === //
    void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
}
