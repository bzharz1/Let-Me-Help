using UnityEngine;
using System.Collections;

public class FallingSpinSawDown : MonoBehaviour {

//    public bool sawActive;
    public GameObject theSaw;
    public Transform sawPosition;
//    public float timeBetweenDrops;
//    private float dropCount;
    public Vector3 respawnPosition;
//    public LevelManager theLevelManager;
//    public Rigidbody2D myRigidbody;
//    public int theSpinSaw;
    public RespawnSpinSaw theRespawnSpinSaw;




	// Use this for initialization
	void Start () {

//        dropCount = timeBetweenDrops;
//        theLevelManager = FindObjectOfType<LevelManager>();
        respawnPosition = transform.position;
//        myRigidbody = GetComponent<Rigidbody2D>();
        theRespawnSpinSaw = FindObjectOfType <RespawnSpinSaw>();

	}
	
	// Update is called once per frame
	void Update () {

//        if (dropCount > 0)
//        {
//            dropCount -= Time.deltaTime;
//
//        } else {

//        sawPosition.position = new Vector3(sawPosition.position.x, sawPosition.position.y, sawPosition.position.z);

//        Instantiate(theSaw, sawPosition.position, sawPosition.rotation);

//          dropCount = timeBetweenDrops;


//          Destroy (gameObject, 3f);

//          theRespawnSpinSaw.Respawn ();

//          }
//          if (theSpinSaw == 0)
//          {
//            Destroy(this.gameObject);
//          }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SawCollector")
        {
//            timeBetweenDrops = theRespawnSpinSaw.timeToRespawn;
//            Destroy(gameObject);
            theRespawnSpinSaw.Respawn ();
        }
    }
   
}
