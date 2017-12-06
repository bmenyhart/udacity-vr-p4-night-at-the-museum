using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowDemoSceneInfo : MonoBehaviour
{
   public  GameObject demoPanel;


    // Use this for initialization
    public void Start ()
    {
        HideInfoPanel();
    }
    
        public void HideInfoPanel()
        {
            demoPanel.SetActive(false);
        }
        public void ShowPanel()
        {
            demoPanel.SetActive(true);

        }
       /* public void OnPointerEnter(PointerEventData eventData)
        {
        }
        public void OnPointerExit(PointerEventData eventData)
        {
        HideInfoPanel();
        }*/
}

