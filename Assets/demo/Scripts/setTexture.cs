using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class setTexture : MonoBehaviour, IPointerClickHandler
{
    public Vector2 textureTiling;
    public Texture texture;

    GameObject floor;
    string imageName;
   void Start()
    {
    floor = GameObject.Find("geo_152");
        imageName= gameObject.GetComponent<Image>().sprite.name;
       // Debug.Log(imageName);
        
       // Debug.Log(texture);
    }

   

    public void OnPointerClick(PointerEventData eventData)
    {
        changeTexture(texture);
    }
    public void changeTexture(Texture texture)
    {
        if (floor!= null && texture != null) {
            floor.GetComponent<Renderer>().material.mainTexture = texture;
            floor.GetComponent<Renderer>().material.mainTextureScale = textureTiling;
        }
        
    }
}
