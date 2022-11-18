using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxObject;
    public bool playingVFX;

    // Start is called before the first frame update
    void Start()
    {
        playingVFX = false;
        if (vfxObject.activeSelf)
        {
            vfxObject.SetActive(false);
        }
    }

    public void PlayVFX()
    {
        if (playingVFX || vfxObject.activeSelf)
        {
            return;
        }

        vfxObject.SetActive(true);
    }
    public void StopVFX()
    {
        vfxObject.SetActive(false);
    }

}
