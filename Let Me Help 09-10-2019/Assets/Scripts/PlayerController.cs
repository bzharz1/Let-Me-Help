using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;

    public Rigidbody2D myRigidbody;
    public float jumpSpeed;

    public Transform groundCheck;
    public float groundCheckRadius;

    public LayerMask whatIsGround;

    public bool isGrounded;

    public Vector3 respawnPosition;

    public LevelManager theLevelManager;

    public AudioSource jumpSound;

    public bool canMove;

//    public PauseButton thePauseButton;


	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        respawnPosition = transform.position;
        theLevelManager = FindObjectOfType<LevelManager>();
        canMove = true;
//        thePauseButton = FindObjectOfType <PauseButton>();
       
	}

	// Update is called once per frame
	void Update () {

        if (canMove)
            {
           isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);



     #if UNITY_STANDALONE || UNITY_WEBPLAYER

                 
            if (Input.GetAxisRaw ("Horizontal") > 0f)
            {
                myRigidbody.velocity = new Vector3 (moveSpeed, myRigidbody.velocity.y, 0f);
//                Right ();

            } 
             
            else if (Input.GetAxisRaw ("Horizontal") < 0f)
            {
                myRigidbody.velocity = new Vector3 (-moveSpeed, myRigidbody.velocity.y, 0f);
//                Left ();

            } else 
            {
            myRigidbody.velocity = new Vector3 (0f, myRigidbody.velocity.y, 0f);
                
//                Unpressed ();
            }



            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                myRigidbody.velocity = new Vector3 (myRigidbody.velocity.x, jumpSpeed, 0f);

                jumpSound.Play(0);
//                Jump ();

            }

        #endif

            }

	}
    

    #if UNITY_IOS || UNITY_ANDROID

    public void Right ()
    {
        if (canMove)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
            myRigidbody.velocity = new Vector3 (moveSpeed, myRigidbody.velocity.y, 0f);

        }
    }

    public void Left ()
    {
        if (canMove)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
            myRigidbody.velocity = new Vector3 (-moveSpeed, myRigidbody.velocity.y, 0f);

        }    
    }

//    public void PauseScreen ()
//    {
//        thePauseButton.PauseGame ();
//    }

    public void Jump ()
    {
        if (isGrounded && canMove)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
            myRigidbody.velocity = new Vector3 (myRigidbody.velocity.x, jumpSpeed, 0f);

            jumpSound.Play(0);
       }     
  
    }

    public void Unpressed ()
    {
        if (canMove)
        {
            isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
            myRigidbody.velocity = new Vector3 (0f, myRigidbody.velocity.y, 0f);
        }
    }

    #endif


    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "killPlane")
     {
//            gameObject.SetActive(false);
//            transform.position = respawnPosition;
            theLevelManager.Respawn();
    }

        if (other.tag == "Checkpoint")
    {
            respawnPosition = other.transform.position;
        }
     }

     void OnCollisionEnter2D(Collision2D other)
     {
        if (other.gameObject.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }
     }

     void OnCollisionExit2D(Collision2D other)
     {
        if(other.gameObject.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
     }
       
}
