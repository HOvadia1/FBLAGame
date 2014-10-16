using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

    public GameObject bullet;


    public void SendBullet()
    {
        Debug.Log("Sent Disc!");
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

}
