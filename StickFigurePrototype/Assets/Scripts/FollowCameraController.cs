using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraController : MonoBehaviour
{
    public GameObject followTarget;
    public float targetZ = -10;
    public float speedModifier = 1;
    public Vector2 TargetPositionOffset;

    // Use this for initialization
    void Start()
    {
	}
	
	// Update is called once per frame
	void Update()
    {
		if (this.followTarget == null)
        {
            return;
        }

        var targetX = this.followTarget.transform.position.x;
        var targetY = this.followTarget.transform.position.y;

        var targetPosition = new Vector3(
            targetX + this.TargetPositionOffset.x,
            targetY + this.TargetPositionOffset.y,
            this.targetZ);

        var newPosition = Vector3.Lerp(this.transform.position, targetPosition, speedModifier * Time.deltaTime);

        this.transform.position = newPosition;
	}
}
