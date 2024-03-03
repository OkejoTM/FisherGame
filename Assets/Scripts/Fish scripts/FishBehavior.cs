using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FishBehavior : MonoBehaviour
{

    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    public Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // movement.x = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var wall = collision.GetComponent<Wall>();   
        if (wall != null)
        {
            Destroy(gameObject);
        }
        HookColliderController hook = collision.GetComponent<HookColliderController>();
        if (hook != null)
        {
             hook.catchFish(gameObject);
        }
    }
}
