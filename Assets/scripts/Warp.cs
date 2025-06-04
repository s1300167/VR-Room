
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CubeWarp : MonoBehaviour
{
    private float speed = 3.0f;
 
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.position = new Vector3
        (
            transform.position.x + moveX, transform.position.y, transform.position.z + moveZ
        );
    }
 
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "TeleportTarget" )
        {
            this.transform.position = new Vector3(4.0f, 0.5f, 4.0f);
        }
    }
}