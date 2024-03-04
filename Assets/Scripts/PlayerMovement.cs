using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Field
    
    [SerializeField]
    float moveUnitPerSecond = 5f;
    [SerializeField]
    float jumpForce = 10f;
    [SerializeField]
    public Animator animator;
    #endregion

    private bool _facingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float jumpInput = Input.GetAxis("JumpKey");
        if(horizontalInput != 0){
            if(horizontalInput > 0 && !_facingRight)
                Flip();
            if(horizontalInput < 0 && _facingRight)
                Flip();
            position.x += horizontalInput * moveUnitPerSecond 
                * Time.deltaTime;
        }
        animator.SetFloat("Speed", Mathf.Abs(horizontalInput));
        if(jumpInput != 0){
            position.y += jumpInput * jumpForce
                * Time.deltaTime;
        }

        transform.position = position;
    }

    private void Flip()
	{
		// Switch the way the player is labelled as facing.
		_facingRight = !_facingRight;
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
        //Keep the transform of text
        Vector3 textScale = transform.Find("Text (TMP)").localScale;
        textScale.x *= -1;
        transform.Find("Text (TMP)").localScale = textScale;
		transform.localScale = theScale;
	}
}
