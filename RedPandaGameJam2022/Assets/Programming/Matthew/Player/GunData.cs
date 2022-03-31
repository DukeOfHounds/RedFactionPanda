using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/Generic")]
public class GunData : ScriptableObject
{
    private void Awake()
    {
    }

    [Header("Gun Variables")]
    
    //[Range(0, 10)]
    
    [SerializeField] public int maxAmmo;
    [SerializeField] public int currentAmmo;
    [SerializeField] public int currentReserveAmmo;
    [SerializeField] public int maxReserveAmmo;
    
    
    
    [SerializeField] public bool isReloading;
    [Range(0, 4)]
    [SerializeField] public float reloadTime;

}
