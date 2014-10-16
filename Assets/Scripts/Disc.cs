using UnityEngine;
using System.Collections;

public class Disc : MonoBehaviour {

    public float bulletDamage = 5.0f;
    public float bulletSpeed = 5.0f;
    public float despawnTimer = 0f;
    float bulletTimer = 2.0f;
   
   void Update()
    {
        despawnTimer += Time.deltaTime;

        this.gameObject.rigidbody2D.velocity = transform.TransformDirection(new Vector3(bulletSpeed, Random.Range(0.1f, 1), 0));    
       
       if(despawnTimer > bulletTimer)
       {
           Destroy(gameObject);
       }
    }
}
