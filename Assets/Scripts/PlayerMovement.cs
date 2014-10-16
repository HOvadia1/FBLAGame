using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Gun gun;

    public float movementSpeed = 10f;


    void Awake()
    {
        gun = GameObject.Find("Gun").GetComponent<Gun>();
    }
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * movementSpeed;
        this.gameObject.rigidbody2D.AddForce(new Vector2(horizontalInput, 0));
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            gun.SendBullet();
        }
    }
}
