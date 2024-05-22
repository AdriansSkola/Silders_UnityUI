using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject CharHolder;
    public Sprite[] SpriteArray;
    public void changeImage(int index)
    {
        CharHolder.GetComponent<Image>().sprite = SpriteArray[index];
    }
}
