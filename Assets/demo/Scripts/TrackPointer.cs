using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrackPointer : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    Quaternion rotationEnter;
    Quaternion rotationExit;
   public GameObject infoPanel;
    float Enterx;
    float Exitx;
    public Camera m_MainCamera;
    public void OnPointerEnter(PointerEventData eventData)
    {

        rotationEnter = m_MainCamera.transform.rotation;
        Vector3 anglesEnter = rotationEnter.eulerAngles;
        Enterx = anglesEnter.x;
        Debug.Log("enter"+ anglesEnter+ Enterx);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rotationExit = m_MainCamera.transform.rotation;
        Vector3 anglesExit = rotationExit.eulerAngles;
        Exitx = anglesExit.x;
        Debug.Log("exit" + anglesExit+ Exitx);
        if (Enterx > Exitx) {
            infoPanel.SetActive(false);
        }

    }
}
