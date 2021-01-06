using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Multiplicator : MonoBehaviour
{
    const int VEIN_LENGTH = 43;
    public GameObject[] veinList;
    int counter = 0;

    // 200x300 px window will apear in the center of the screen.
    private Rect windowRect = new Rect((Screen.width - 200) / 2, (Screen.height - 300) / 2, 200, 300);
    // Only show it if needed.
    private bool show = false;

    void Start()
    {
        StartCoroutine(sceneLoader());
    }

    IEnumerator sceneLoader()
    {
        Debug.Log("Wait for Escape to be pressed");
        yield return new WaitWhile(() => !Input.GetKeyDown(KeyCode.Escape));
        Debug.Log("Escape pressed");

        //Increment and Load next scene
        SceneManager.LoadScene("Quiz");
    }

    void OnGUI()
    {
        if (show)
            windowRect = GUI.Window(0, windowRect, DialogWindow, "Press Escape to start quiz");
    }

    // Update is called once per frame
    void Update()
    {
        var activeCameraRig = GameObject.FindGameObjectWithTag("CameraRig");

        if (activeCameraRig.transform.position.x > 50 || activeCameraRig.transform.position.x < -50) {
            show = true;
        }

        float xStartMid = veinList[1].transform.position.x;
        float xStopMid = veinList[1].transform.position.x - VEIN_LENGTH;

        if (activeCameraRig.transform.position.x < xStartMid)
        {
            Vector3 newPosition = veinList[2].transform.position;
            Quaternion quaternion = veinList[2].transform.rotation;
            newPosition[0] -= 3 * VEIN_LENGTH;
            veinList[2].transform.SetPositionAndRotation(newPosition, quaternion);
            GameObject[] newList = { veinList[2], veinList[0], veinList[1] };

            veinList = newList;
        }
        if (activeCameraRig.transform.position.x > xStopMid)
        {
            Vector3 newPosition = veinList[0].transform.position;
            Quaternion quaternion = veinList[0].transform.rotation;
            newPosition[0] += 3 * VEIN_LENGTH;
            veinList[0].transform.SetPositionAndRotation(newPosition, quaternion);
            GameObject[] newList = { veinList[1], veinList[2], veinList[0] };

            veinList = newList;
        }
    }


    // This is the actual window.
    void DialogWindow(int windowID)
    {

    }

    // To open the dialogue from outside of the script.
    public void Open()
    {
        Debug.Log("Am intrat baa");
        show = true;
    }
}
