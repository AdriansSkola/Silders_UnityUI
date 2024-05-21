using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHover : MonoBehaviour
{
    public AudioSource aSource;
    public AudioClip aClip;

    public void onButton()
    {
        aSource.PlayOneShot(aClip);
    }

    public void notOnButton()
    {
        aSource.Stop();
    }
}
