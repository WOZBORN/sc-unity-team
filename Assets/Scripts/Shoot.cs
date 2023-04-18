using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public float damage = 20f;
    public float range = 150f;
    public float timer = 5;
    public float magaz = 30;
    public AudioSource shotSound;

    public Camera fpsCam;
    public ParticleSystem muzzleflash;
    public Text magaztext;

    void Start()
    {
        magaztext.text = magaz.ToString();
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (magaz >= 1)
            {
                timer += 2 * Time.deltaTime;
                if (timer >= 0.5f)
                {
                    Shoots();
                    magaz -= 1;
                    timer = 0;
                }
            }
        }
        if (magaz == 0)
        {
            if (timer >= 6)
            {
                magaz = 30;
            }
            timer += 2 * Time.deltaTime;
        }
        magaztext.text = Mathf.Round(magaz).ToString();
    }
    void Shoots()
    {
        muzzleflash.Play();
        shotSound.PlayOneShot(shotSound.clip);
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