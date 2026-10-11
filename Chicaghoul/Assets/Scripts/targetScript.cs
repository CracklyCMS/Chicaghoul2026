using UnityEngine;
using UnityEngine.UI;

public class targetScript : MonoBehaviour
{
    public Camera mainCam;
    public Image laserUI;
    public ParticleSystem explosion;
    public int aliensCaptured = 0;

    private BoxCollider2D collision;

    void Start()
    {
        collision = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        transform.position = mainCam.transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            laserUI.enabled = true;
            collision.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            laserUI.enabled = false;
            collision.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Alien"))
        {
            print("HIT");
            aliensCaptured++;
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
            ParticleSystem boomParticles = Instantiate(explosion, collision.transform.position, Quaternion.identity);
            Destroy(boomParticles.gameObject, boomParticles.main.duration + boomParticles.main.startLifetime.constantMax);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Alien"))
        {
            print("MISS");
        }
    }
}
