using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private float _moveSpeed = 1.0f;
    private NavMeshAgent _navMeshAgent;
    

    private void Start()
    {   
        _navMeshAgent = GetComponent<NavMeshAgent>();
        // STEP 1 -------------------------------------------------------------
        // In the Start method, set the NavMeshAgent's speed to _moveSpeed.
        //      This will make the Deer move at the speed we set in the Inspector.
        _navMeshAgent.speed = _moveSpeed;
        _navMeshAgent.SetDestination(_targetTransform.position);

    }
    
} 
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...