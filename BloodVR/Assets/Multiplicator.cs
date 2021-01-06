using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Multiplicator : MonoBehaviour
{
    const int VEIN_LENGTH = 43;
    public GameObject[] veinList;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var activeCameraRig = GameObject.FindGameObjectWithTag("CameraRig");

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
}
