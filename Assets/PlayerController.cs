using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sizeChangeSpeed = 0.1f;

    void Update()
    {
        // Movement Input
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 move = new Vector2(moveX, moveY);

        transform.Translate(move * moveSpeed * Time.deltaTime);

        // Size Increase
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.localScale += new Vector3(sizeChangeSpeed, sizeChangeSpeed, 0);
        }

        // Size Decrease
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.localScale -= new Vector3(sizeChangeSpeed, sizeChangeSpeed, 0);
        }
    }
}
