using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMotion : MonoBehaviour
{
    void Update()
    {

        transform.Translate(Vector2.right * Time.deltaTime * 3);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(string.Format("{0} collided with {1}", collision.otherCollider.name, gameObject.name));
    }
}
