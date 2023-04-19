using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject talk;
    public GameObject f;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            talk.SetActive(true);
            f.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void curs()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

}
