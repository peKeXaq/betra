using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AvatarController : MonoBehaviourPunCallbacks
{
    public float speed;
    private Rigidbody2D rb;

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

        // 自身が生成したオブジェクトだけに移動処理を行う
        if (photonView.IsMine)
        {
            Vector2 direction = new Vector2(horizontalKey, verticalKey).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
    }
}
