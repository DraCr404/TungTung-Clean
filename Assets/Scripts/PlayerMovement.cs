using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float horizontalLimit = 3f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        Vector3 newPos = transform.position + new Vector3(move, 0, 0);
        newPos.x = Mathf.Clamp(newPos.x, -horizontalLimit, horizontalLimit);
        transform.position = newPos;
    }
}

