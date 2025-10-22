using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 15;

    Rigidbody rb;
    int damage;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.linearVelocity = transform.forward * speed;
    }

    public void Init(int damage)
    {
        this.damage = damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        playerHealth?.TakeDamage(damage);

        Destroy(this.gameObject);
    }
}
