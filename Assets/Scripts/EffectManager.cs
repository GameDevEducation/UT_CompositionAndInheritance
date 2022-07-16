using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] RotateEffect Rotate;
    [SerializeField] BounceEffect Bounce;

    [SerializeField] bool EnableEffects = false;
    bool PreviousEnableEffects;

    // Start is called before the first frame update
    void Start()
    {
        Bounce.enabled = Rotate.enabled = EnableEffects;
        PreviousEnableEffects = EnableEffects;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnableEffects != PreviousEnableEffects)
        {
            Bounce.enabled = Rotate.enabled = EnableEffects;
            PreviousEnableEffects = EnableEffects;
        }
    }
}
