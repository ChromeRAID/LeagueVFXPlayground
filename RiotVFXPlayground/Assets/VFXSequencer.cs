using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VFXSequencer : MonoBehaviour
{
    public bool playOnStart = false;
    public List<VFXComponent> sequence = new List<VFXComponent>();

    // Start is called before the first frame update
    void Start()
    {

    }

    public void PlaySequence(float delay = 0f)
    {
        foreach (VFXComponent c in sequence)
        {
            DOVirtual.DelayedCall(c.startDelay + delay, () =>
            {
                c.manager.PlayVFX();
            });

            DOVirtual.DelayedCall(c.startDelay + c.duration + delay, () =>
            {
                c.manager.StopVFX();
            });
        }

    }
}

[System.Serializable]
public class VFXComponent
{
    public VFXManager manager;
    public float startDelay;
    public float duration;
}
