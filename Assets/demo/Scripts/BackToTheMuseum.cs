using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackToTheMuseum : MonoBehaviour
{

    public Camera m_MainCamera;
    public GameObject backPanel;
    float cameraRotationXAngle;
    float cameraRotationYStartAngle;
    Quaternion cameraRotationStart;
    Vector3 cameraPosition;
    Vector3 infoPanelPosition;
    Vector3 offsetBackPanel;
    Quaternion cameraRotationActual;

    public void Start()
    {
        //hide backPanel
        backPanel.SetActive(false);

        cameraRotationStart = m_MainCamera.transform.rotation;
        cameraRotationYStartAngle = cameraRotationStart.y;
    }
    void Update()
    {
        cameraRotationActual = m_MainCamera.transform.rotation;
        Vector3 cameraRotationAngleActual = cameraRotationActual.eulerAngles;
        cameraRotationXAngle = cameraRotationAngleActual.x;

        if (!backPanel.activeSelf && cameraRotationXAngle >= 56 && cameraRotationXAngle <= 90)
        {
            float cameraRotationActualYAngle = cameraRotationAngleActual.y;
            float rotationDiffAngel = cameraRotationYStartAngle - cameraRotationActualYAngle;
            cameraPosition = m_MainCamera.transform.position;
           //Debug.Log("cameraposition"+cameraPosition);
            backPanel.SetActive(true);
           
            offsetBackPanel = new Vector3(Mathf.Cos((rotationDiffAngel * Mathf.PI) / 180) * 0.2f, -1.5f, Mathf.Sin((rotationDiffAngel * Mathf.PI) / 180) * 1f); 
            
            infoPanelPosition = cameraPosition + offsetBackPanel;
            backPanel.transform.position = infoPanelPosition;
            Debug.Log("InfoPanel" + infoPanelPosition);            
        }
        if (!(cameraRotationXAngle >= 56 && cameraRotationXAngle <= 90))
        {
            backPanel.SetActive(false);
        }
    }
   

    
}
