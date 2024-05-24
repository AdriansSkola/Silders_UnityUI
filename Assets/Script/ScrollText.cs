using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollText : MonoBehaviour
{
    public Dropdown Dropdown;
    public Text charInfo;

    public string maleInfo = "Male was no ordinary player. He bore the coveted Legendary Title, a badge of honor earned through trials and valor. To obtain it, he had completed the Quest of Honor, unraveling cryptic riddles, battling fearsome monsters, and collecting rare artifacts.";
    public string femaleInfo = "The Legendary Title was more than a mere accolade; it was a promise of destiny. Seraphina’s heart burned with the desire to prove herself, to transcend the constraints of her birthright.";

    void Start()
    {
        Dropdown.onValueChanged.AddListener(delegate
        {
            DropChanged(Dropdown);
        });
        charInfo.text = maleInfo;
    }

    void DropChanged(Dropdown change)
    {
        if (change.value == 0)
        {
            charInfo.text = maleInfo;
        } else if (change.value == 1)
        {
            charInfo.text = femaleInfo;
        }
    }
}
