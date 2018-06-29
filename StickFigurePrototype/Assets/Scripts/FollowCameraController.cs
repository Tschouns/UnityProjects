using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraController : MonoBehaviour
{
    public GameObject followTarget;
    public float targetZ = -10;
    public float speedModifier = 1;
    public Vector2 positionOffset;

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

        var targetPosition = new Vector3(
            this.followTarget.transform.position.x + this.positionOffset.x,
            this.followTarget.transform.position.y + this.positionOffset.y,
            this.targetZ);

        var newPosition = Vector3.Lerp(this.transform.position, targetPosition, speedModifier * Time.deltaTime);

        this.transform.position = newPosition;
	}
}
