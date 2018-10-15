using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.Advertisements;


public class SplashScreenFade : MonoBehaviour {

    public Image blackImage;


	IEnumerator Start () {

        if (blackImage != null)
        {

	    blackImage.canvasRenderer.SetAlpha (0.0f);

        FadeIn ();
//        yield return new WaitForSeconds (2.3f);
            yield return new WaitForSeconds (3.0f);

        //    ShowAd();


//        FadeOut ();
//        yield return new WaitForSeconds (2.5f);
        }
	}

    void FadeIn()
    {
//        blackImage.CrossFadeAlpha (1.0f, 3.5f, false);
        blackImage.CrossFadeAlpha (1.0f, 3.0f, false);

    }

//    void FadeOut()
//    {
//        blackImage.CrossFadeAlpha (0.0f, 2.5f, false);
//    }


   //   public void ShowAd()
  //    {
 //       if (Advertisement.IsReady())
 //       {
     //       Advertisement.Show();
 //       }
  //    }

}
