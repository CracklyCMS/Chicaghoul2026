using UnityEngine;
using UnityEngine.UI;

public class cameraScript : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); 
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = (transform.up * vertical) + (transform.right * horizontal);
        direction.Normalize();

        Vector3 newPosition = transform.position + (direction * moveSpeed * Time.deltaTime);
        newPosition.y = Mathf.Clamp(newPosition.y, -6f, 10f);

        transform.position = newPosition;
    }
}
