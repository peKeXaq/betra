using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    //private Collider2D[] result;
    //private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        float verticalKey = Input.GetAxis("Vertical");
        /*
        result = new Collider2D[10];
        int count = rb.OverlapCollider(new ContactFilter2D(), result);
        
        Debug.Log("Overlap=" + count);
        foreach (var r in result)
        {
            if (r != null) Debug.Log(r.name);
        }
        */

        Vector2 direction = new Vector2(horizontalKey, verticalKey).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
