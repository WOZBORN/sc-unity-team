using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform shootPoint;
    [SerializeField] float power;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bullet, shootPoint.position, bullet.transform.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(shootPoint.forward * power * Time.deltaTime, ForceMode.Impulse);
            newBullet.transform.rotation = transform.root.rotation;
        }
    }
}
