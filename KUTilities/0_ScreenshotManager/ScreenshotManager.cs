using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Video Previews
/// YouTube: https://youtube.com/shorts/Jz4YhYW8sLI
/// TikTok: https://vm.tiktok.com/ZGJn1TF2Q/
/// Instagram: https://www.instagram.com/reel/Cw27LW-y_UY/?utm_source=ig_web_button_share_sheet&igshid=MzRlODBiNWFlZA==
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
