using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float damage = 20f;
    public float range = 100f;

    public Camera fpsCam;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoots();
        }
    }
    void Shoots()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            EnemyCon target = hit.transform.GetComponent<EnemyCon>();
            if (target != null)
            {
                target.TakeDameg(damage);
            }
        }
    }
}