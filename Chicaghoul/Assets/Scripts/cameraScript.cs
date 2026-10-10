using UnityEngine;
using UnityEngine.UI;

public class cameraScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject collision;
    public Image laser;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); 
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = (transform.up * vertical) + (transform.right * horizontal);
        direction.Normalize();

        Vector3 newPosition = transform.position + (direction * moveSpeed * Time.deltaTime);
        newPosition.y = Mathf.Clamp(newPosition.y, -6f, 10f);

        transform.position = newPosition;

        Vector3 collisionPosition = transform.position + new Vector3(0, 0, 9);
        collision.transform.position = collisionPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            laser.enabled = true;
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            laser.enabled = false;
        }
    }
}
