using UnityEngine;
using UnityEngine.Timeline;

public class targetScript : MonoBehaviour
{
    public int aliensCaptured = 0;

    private BoxCollider2D collision;

    void Start()
    {
        collision = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            collision.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
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
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Alien"))
        {
            print("MISS");
        }
    }
}
