using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Video Previews
/// YouTube: https://youtube.com/shorts/0C1CqHJZ-G8
/// TikTok: inc.  
/// Instagram: inc.
/// </summary>

/// <summary>
/// Saves a screenshot in the resolution of the game window in the root directory of the project.
/// Works only in the runtime.
/// </summary>
public class ScreenshotManager : MonoBehaviour
{
    public KeyCode screenShotButton; // Button for taking a screenshot

    void Update()
    {
        if (Input.GetKeyDown(screenShotButton))
        {
            StartCoroutine(TakeScreenShot());
        }
    }

    IEnumerator TakeScreenShot()
    {
        yield return new WaitForEndOfFrame();
        string currentTime = System.DateTime.Now.ToString("MM-dd-yy (HH-mm-ss)");
        ScreenCapture.CaptureScreenshot(currentTime + ".png");
        Debug.Log($"<color=green>Screenshot created!</color>");
    }
}
