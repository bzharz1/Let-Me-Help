using UnityEngine;
using System.Collections;

public class CheckpointController : MonoBehaviour {

    public Sprite buleSymbol;
    public Sprite pinkSymbol;

    private SpriteRenderer theSpriteRendrer;

    public bool checkPointActive;

	// Use this for initialization
	void Start () {
        theSpriteRendrer = GetComponent <SpriteRenderer>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

     void OnTriggerEnter2D (Collider2D other)
    {
      if(other.tag == "Player")
      {
        theSpriteRendrer.sprite = buleSymbol;
        checkPointActive = true;
        }
        }
}
