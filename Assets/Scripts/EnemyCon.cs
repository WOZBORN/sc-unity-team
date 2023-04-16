using UnityEngine.AI;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    public float health = 100f;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] NavMeshAgent navAgent;
    private Transform player;
    private Vector3 startPosition;

    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPosition = transform.position;
    }

    void Update()
    {

        if (Vector3.Distance(transform.position, player.position) <= 10)
        {
            navAgent.destination = player.transform.position;
        }
        else
        {
            navAgent.destination = startPosition;
        }
    }


    public void TakeDameg(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            Dii();
        }
    }
    public void Dii()
    {
        Destroy(gameObject);
    }
}
