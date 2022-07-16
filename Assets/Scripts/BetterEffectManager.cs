using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterEffectManager : MonoBehaviour
{
    [SerializeField] bool EnableEffects = false;
    bool PreviousEnableEffects;

    List<BaseEffect> Effects;

    // Start is called before the first frame update
    void Start()
    {
        Effects = new List<BaseEffect>(GetComponents<BaseEffect>());

        foreach (var effect in Effects)
            effect.enabled = EnableEffects;

        PreviousEnableEffects = EnableEffects;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnableEffects != PreviousEnableEffects)
        {
            foreach (var effect in Effects)
                effect.enabled = EnableEffects;

            PreviousEnableEffects = EnableEffects;
        }
    }
}
