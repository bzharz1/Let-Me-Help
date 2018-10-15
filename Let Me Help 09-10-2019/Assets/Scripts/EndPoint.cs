using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//using UnityEngine.Advertisements;

public class EndPoint : MonoBehaviour
{

    public string levelToLoad;

    private PlayerController thePlayer;
    private CameraController theCamera;
    private LevelManager theLevelManager;

    public float waitTime;
    public float waitToLoad;

    public string levelToUnlock;

    public ButtonSetting theButtonSetting;

    //    public PauseScreen thePauseScreen;


    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        theCamera = FindObjectOfType<CameraController>();
        theLevelManager = FindObjectOfType<LevelManager>();
        theButtonSetting = FindObjectOfType<ButtonSetting>();
        //        thePauseScreen = FindObjectOfType <PauseScreen>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //            SceneManager.LoadScene(levelToLoad); 

            StartCoroutine("LevelEndCo");
        }

    }

    public IEnumerator LevelEndCo()
    {
        thePlayer.canMove = false;
        theCamera.followTarget = false;

        theLevelManager.gameMusic.Stop();
        theLevelManager.endPointAlarm.Play();

        // To stop the player in (0,0,0) axis
        thePlayer.myRigidbody.velocity = Vector3.zero;

        PlayerPrefs.SetInt(levelToUnlock, 1);

        yield return new WaitForSeconds(waitTime);

        thePlayer.myRigidbody.velocity = new Vector3(thePlayer.moveSpeed, thePlayer.myRigidbody.velocity.y, 0f);

        yield return new WaitForSeconds(waitToLoad);
        SceneManager.LoadScene(levelToLoad);

        theButtonSetting.ButtonNextLevel();

     //   ShowAd();

        //        thePauseScreen.paused = false;

    }
}

  //  public void ShowAd()
 //   {
   //     if (Advertisement.IsReady())
     //   {
       //     Advertisement.Show();
  //      }
    //}

//}
