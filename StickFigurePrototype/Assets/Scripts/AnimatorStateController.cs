using UnityEngine;

public class AnimatorStateController : MonoBehaviour
{
    public GameObject rigidbodyObject;
    public GameObject animatorObject;

    private Rigidbody2D characterBody;
    private Animator animator;

    private bool isFacingLeft;

	// Use this for initialization
	void Start ()
    {
        this.characterBody = this.rigidbodyObject.GetComponent<Rigidbody2D>();
        this.animator = this.animatorObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        var velocityX = this.characterBody.velocity.x;
        if (Mathf.Abs(velocityX) > 0.1)
        {
            this.isFacingLeft = velocityX < 0;
        }

        this.animator.SetFloat("velocityX", velocityX);
        this.animator.SetBool("isFacingLeft", this.isFacingLeft);
	}
}
