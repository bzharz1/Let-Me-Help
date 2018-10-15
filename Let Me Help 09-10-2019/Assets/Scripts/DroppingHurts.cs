using UnityEngine;
using System.Collections;

public class DroppingHurts : MonoBehaviour {

    public GameObject hurt;
    public Rigidbody2D myRigidBody;

    public LevelManager theLevelManager;

//    public float moveSpeed;
//
//    private Vector3 currentTarget;


	// Use this for initialization
	void Start () {

        hurt = FindObjectOfType<GameObject>();
        myRigidBody = GetComponent<Rigidbody2D>();
        theLevelManager = FindObjectOfType<LevelManager>();

//        currentTarget = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

//        hurt.transform.position = Vector3.MoveTowards(hurt.transform.position, currentTarget, moveSpeed * Time.deltaTime);

	}



    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "killPlane")
     {
//        Destroy (gameObject);
//            gameObject.SetActive(false);
//            transform.position = respawnPosition;
            theLevelManager.Respawn();
    }

}

    void OnCollisionEnter2D(Collision2D other)
     {
        if (other.gameObject.tag == "Player")
        {
            Destroy (other.gameObject);
        } 
     }

}