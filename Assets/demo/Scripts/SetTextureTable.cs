using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SetTextureTable: MonoBehaviour, IPointerClickHandler
{
    public Vector2 textureTiling;
    public Texture texture;
    public String furnitureName;
    GameObject furniture;
    string imageName;



    public void OnPointerClick(PointerEventData eventData)
    {
        furniture = GameObject.Find(furnitureName);
        Debug.Log(furniture);
        changeTexture(texture);
    }
    public void changeTexture(Texture texture)
    {
        if (furniture != null && texture != null)
        { 
           
                furniture.GetComponent<Renderer>().material.mainTexture = texture;
            furniture.GetComponent<Renderer>().material.mainTextureScale = textureTiling;

        }

    }
}