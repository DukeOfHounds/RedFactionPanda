using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private GunData gD;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryFire()
    {
        if (gD.currentAmmo > 0)
        {
            FireGun();
        }
        else
        {
            TryReload();
        }
    }

    private void TryReload()
    {
        if (gD.currentReserveAmmo > 0 && !gD.isReloading)
        {
            Reload();
        }
    }

    private void Reload()
    {
        if (gD.maxAmmo > gD.currentAmmo)
        {
            gD.isReloading = true;
            StartCoroutine(ReloadTime());
        }
    }

    private IEnumerator ReloadTime()
    {
        yield return new WaitForSeconds(gD.reloadTime);
        int ammoToAdd = gD.maxAmmo - gD.currentAmmo;
        if (gD.currentReserveAmmo >= ammoToAdd)
        {
            gD.currentReserveAmmo = gD.currentReserveAmmo - ammoToAdd;
            gD.currentAmmo = gD.currentAmmo + ammoToAdd;
        }
        else
        {
            gD.currentAmmo = gD.currentAmmo + gD.currentReserveAmmo;
            gD.currentReserveAmmo = 0;
        }
        gD.isReloading = false;
    }

    private void FireGun()
    {
        gD.currentAmmo = gD.currentAmmo-1;
    }
}
