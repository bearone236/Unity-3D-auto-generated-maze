using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    public float speed = 1.0f;
 
    void Update()
    {
        // Wキー（前方移動）
        if (Input.GetKey("up"))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
            // transform.position += speed * transform.forward * Time.deltaTime;
        }
 
        // Sキー（後方移動）
        if (Input.GetKey("down"))
        {

            transform.position += speed * transform.right * Time.deltaTime;
            // transform.position -= speed * transform.forward * Time.deltaTime;
        }
 
        // Dキー（右移動）
        if (Input.GetKey("right"))
        {

            // transform.position += speed * transform.forward * Time.deltaTime;
            transform.Rotate(0,2,0);


            // transform.position += speed * transform.right * Time.deltaTime;
        }
 
        // Aキー（左移動）
        if (Input.GetKey("left"))
        {

            // transform.position -= speed * transform.forward * Time.deltaTime;
            transform.Rotate(0, -2, 0);

            // transform.position -= speed * transform.right * Time.deltaTime;
        }
    }
}