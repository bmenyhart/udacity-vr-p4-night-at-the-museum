using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FurnitureHandler : MonoBehaviour, IPointerClickHandler
{

    public string parentName;
    public string furnitureName;
    GameObject furniture;
    GameObject parent;


    // Use this for initialization
    void Start()
    {
        parent = GameObject.Find(parentName);
        Debug.Log(parent);


    }
    public void OnPointerClick(PointerEventData eventData)
    {

        Debug.Log(furnitureName);
        furniture = parent.transform.Find(furnitureName).gameObject;
        Debug.Log(furniture);
        furniture.SetActive(true);


    }

}
