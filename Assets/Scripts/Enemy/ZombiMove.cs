using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class ZombiMove : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private NavMeshAgent _navMeshAgent;
    private Transform _player;
    private string _nameBoolForRun = "IsRun";
    private void Start()
    {
        _player = FindFirstObjectByType<Player>().transform;
    }

    private void Update()
    {
        Move();
        var dis = Vector3.Distance(transform.position, _player.position);
        if(dis < 0.1f)
        {
            _anim.SetBool(_nameBoolForRun, false);
        }
    }

    private void Move()
    {
        _anim.SetBool(_nameBoolForRun,true);
        _navMeshAgent.SetDestination(_player.position);
    }
}
