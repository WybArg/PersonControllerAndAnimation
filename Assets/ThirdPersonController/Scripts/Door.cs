using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,IProps
{
    public Animation animationOpen;
    public string nameClip;
    public AudioSource AudioOpen;
    public AudioSource AudioClose;

    public float speedClipStart;
    public float speedClipEnd;
    public float timeClosePreps;
    private bool open = true;


    public void OpenProps()
    {
        if (open)
        {
            open = false;
            animationOpen.Play();
            AudioOpen.Play();
            animationOpen[nameClip].speed = speedClipStart;
            Invoke(nameof(CloseProps), timeClosePreps);
        }
    }

    public void CloseProps()
    {
        animationOpen.Play();
        AudioClose.Play();
        animationOpen[nameClip].speed = speedClipEnd;
        open = true;
    }

}
