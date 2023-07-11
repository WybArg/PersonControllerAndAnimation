using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IProps
{
    public Animation animationOpen;
    public string nameClip;

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
            animationOpen[nameClip].speed = speedClipStart;
            Invoke(nameof(CloseProps), timeClosePreps);
        }
    }

    public void CloseProps()
    {
        animationOpen.Play();
        animationOpen[nameClip].speed = speedClipEnd;
        open = true;
    }

}
