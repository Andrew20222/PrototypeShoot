using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public float _damage;
    private Transform player;
    private ZombiHealth zombiHealth;
    private void Start()
    {
        player = FindAnyObjectByType<ZombiHealth>().transform;
        zombiHealth = FindAnyObjectByType<ZombiHealth>();
    }

    private void Update()
    {
       var dis = Vector3.Distance(transform.position, player.position);
        if(dis < 0.5)
        {
            zombiHealth.TakeDamage(_damage);
        }
    }
}
