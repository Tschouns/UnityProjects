using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed = 5;

    private float deadThreshold = 0.2f;
    private Rigidbody2D playerBody;

	// Use this for initialization
	void Start()
    {
        this.playerBody = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update()
    {
        var moveAxis = Input.GetAxisRaw("Horizontal");
        if (Math.Abs(moveAxis) > this.deadThreshold)
        {
            var velocityX = moveAxis * this.playerSpeed;

            this.playerBody.velocity = new Vector2(
                velocityX,
                this.playerBody.velocity.y);
        }
	}
}
