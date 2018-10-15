using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public float timeToRespawn;
    public PlayerController thePlayer;
    public GameObject deathExplosion;

    public AudioSource gameMusic;
    public AudioSource endPointAlarm;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Respawn()
    {
      StartCoroutine ("RespawnCo");
//      gameMusic.Stop();
//      endPointAlarm.Play();
    
    }

    public IEnumerator RespawnCo()
    {
        thePlayer.gameObject.SetActive(false);
        Instantiate (deathExplosion, thePlayer.transform.position, thePlayer.transform.rotation);

      yield return new WaitForSeconds(timeToRespawn);

        thePlayer.transform.position = thePlayer.respawnPosition;
        thePlayer.gameObject.SetActive(true);
    }

}
