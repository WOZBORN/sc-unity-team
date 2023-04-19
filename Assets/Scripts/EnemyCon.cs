using UnityEngine.AI;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    [SerializeField] QuestController enemyRoom;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] NavMeshAgent navAgent;
    public float health = 100f;
    private Transform player;
    private Vector3 startPosition;

    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPosition = transform.position;
        enemyRoom.enemyCount += 1;
    }

    void Update()
    {

        if (Vector3.Distance(transform.position, player.position) <= 30)
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

    private void OnDestroy()
    {
        enemyRoom.ReduceEnemyCount();
    }
}
