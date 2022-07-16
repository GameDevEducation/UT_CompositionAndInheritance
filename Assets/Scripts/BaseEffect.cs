using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEffect : MonoBehaviour
{
    [SerializeField][Range(0.5f, 2f)] protected float Speed = 1;
    [SerializeField] protected float Period = 2f;

    protected float CurrentProgress { get; private set; } = 0f;
    protected Vector3 InitialPosition { get; private set; }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        InitialPosition = transform.position;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        CurrentProgress = (CurrentProgress + (Time.deltaTime * Speed) / Period) % 1f;
    }
}
