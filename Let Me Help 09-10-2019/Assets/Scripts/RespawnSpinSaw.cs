using UnityEngine;
using System.Collections;

public class RespawnSpinSaw : MonoBehaviour {

    public float timeToRespawn;
    public FallingSpinSawDown theFallingSpinSawDown;
//    public GameObject deathExplosion;

	// Use this for initialization
	void Start () {

        theFallingSpinSawDown = FindObjectOfType<FallingSpinSawDown>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Respawn ()
    {
        StartCoroutine ("RespawnCo");
    }

    public IEnumerator RespawnCo()
    {
        theFallingSpinSawDown.theSaw.SetActive(false);

        yield return new WaitForSeconds (timeToRespawn);
        theFallingSpinSawDown.transform.position = theFallingSpinSawDown.respawnPosition;

        theFallingSpinSawDown.theSaw.SetActive(true);
//        Destroy (theFallingSpinSawDown.theSaw);
    } 
}

