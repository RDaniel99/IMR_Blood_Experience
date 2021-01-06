using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitListener : MonoBehaviour
{
    // Start is called before the first frame update

    const float X_MIN = 295.0f;
    const float X_MAX = 434.0f;
    const float Y_MIN = 112.0f;
    const float Y_MAX = 135.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float x_mouse = Input.mousePosition.x;
            float y_mouse = Input.mousePosition.y;

            if (X_MAX >= x_mouse && x_mouse >= X_MIN && Y_MAX >= y_mouse && y_mouse >= Y_MIN)
            {
                Quit();
            }
        }
    }

    public static void Quit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}
