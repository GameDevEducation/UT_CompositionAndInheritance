using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEffect : BaseEffect
{
    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        transform.Rotate(CurrentProgress * 30f, 0f, 0f);
    }
}
