using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // Awake
    GameManager GM;
    
    // Inspector
    [SerializeField] Transform target;
    
    // Private
    NavMeshAgent agent;
    
    
    // === Life Cycle === //
    void Awake()
    {
        GM = GameObject.FindWithTag("GameManager")
            .GetComponent<GameManager>();
        
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (GM.IsGameOver()) return;
        print(GM.IsGameOver());
        
        Chase();
    }

    void Chase()
    {
        if (target is null) return;
        
        agent.SetDestination(target.position);
    }
}
