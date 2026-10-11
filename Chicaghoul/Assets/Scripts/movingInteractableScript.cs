using UnityEngine;

public class movingInteractableScript : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        RandomizeMovement();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3f)
        {
            RandomizeMovement();
            timer = 0f;
        }
    }

    void RandomizeMovement()
    {
        float xDirection = Random.Range(-1f, 1f);
        float yDirection = Random.Range(-1f, 1f);

        Vector2 randomDirection = new Vector2(xDirection, yDirection).normalized;

        rb.linearVelocity = randomDirection * speed;
    }
}
