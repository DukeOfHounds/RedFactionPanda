using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    
    
    public virtual void Awake()
    {
        gameObject.layer = 3;      
    }

    public virtual void Start()
    {
    
    }
    public abstract void OnInteract(PlayerInteraction pI);
    public abstract void OnFocus();
    public abstract void OnLoseFocus();
}
