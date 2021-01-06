using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayListener : MonoBehaviour
{
    public GameObject playButton;
    const float X_MIN = 295.0f;
    const float X_MAX = 434.0f;
    const float Y_MIN = 203.0f;
    const float Y_MAX = 227.0f;

    // Start is called before the first frame update
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

            Debug.Log(Input.mousePosition);

            if(X_MAX >= x_mouse && x_mouse >= X_MIN && Y_MAX >= y_mouse && y_mouse >= Y_MIN)
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
}
