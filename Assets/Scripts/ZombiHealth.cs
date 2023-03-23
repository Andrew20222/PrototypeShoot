using UnityEngine;

public class ZombiHealth : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100;
    private float _currentHealth;
    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        if(_currentHealth <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Bullet>() != null)
        {
            TakeDamage(collision.gameObject.GetComponent<Bullet>()._damage); 
        }
    }
}
