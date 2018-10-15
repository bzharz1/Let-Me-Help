using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {

    #if UNITY_IOS || UNITY_ANDROID

    private PlayerController thePlayer;

//    private PauseScreen thePauseScreen;
 

	// Use this for initialization
	void Start () {
	    thePlayer = FindObjectOfType<PlayerController>();
//        thePauseScreen = FindObjectOfType<PauseScreen>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   

    public void RightTouch ()
    {
        thePlayer.Right ();
    }

    public void LeftTouch ()
    {
        thePlayer.Left ();
    }

//    public void PauseTouch ()
//    {
//        thePlayer.PauseScreen ();
//    }

    public void UnTouched ()
    {
        thePlayer.Unpressed ();
    }

    public void Jump ()
    {
        thePlayer.Jump ();
    }
    #endif

}
