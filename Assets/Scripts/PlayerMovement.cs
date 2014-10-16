using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 10f;

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * movementSpeed;
        this.gameObject.rigidbody2D.AddForce(new Vector2(horizontalInput, 0));
    }
}
