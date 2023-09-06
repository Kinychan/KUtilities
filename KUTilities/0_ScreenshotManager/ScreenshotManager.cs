using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Speichert einen Screenshot in der Game Window Resolution im Rootfolder des Projektes.
/// Funktioniert nur in der Runtime.
/// </summary>
public class ScreenshotManager : MonoBehaviour
{
    public KeyCode screenShotButton; // Taste die gedrueckt werden muss fuer einen Screenshot

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
        Debug.Log($"<color=green>Screenshot erstellt!</color>");
    }
}
