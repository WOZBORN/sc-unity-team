using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private int damage;
    void Start()
    {
        Destroy(gameObject, 4f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
