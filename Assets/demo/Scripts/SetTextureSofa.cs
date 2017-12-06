using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SetTextureSofa : MonoBehaviour, IPointerClickHandler
{
    public Texture texture;
    public String furnitureName;
    GameObject furniture;
    string imageName;
    void Start()
    {
       
    }



    public void OnPointerClick(PointerEventData eventData)
    {
        furniture = GameObject.Find(furnitureName);
        changeTexture(texture);
    }
    public void changeTexture(Texture texture)
    {
        if (furniture != null && texture != null)
        {
           Debug.Log(furniture.GetComponent<Renderer>().materials[1].mainTexture);
            if (furniture.GetComponent<Renderer>().materials[1] != null)
            {
                furniture.GetComponent<Renderer>().materials[1].mainTexture = texture;
            }
            else
            { furniture.GetComponent<Renderer>().material.mainTexture = texture;
            }
        }

    }
}