using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class playerWarp : MonoBehaviour
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
        if (other.gameObject.name == "" )
        {
            this.transform.position = new Vector3(14.98f, 6.32f, -11.13f);
        }
    }
}