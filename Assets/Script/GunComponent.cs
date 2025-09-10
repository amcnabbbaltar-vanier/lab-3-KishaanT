using System;
using UnityEngine;

public class GunComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletMaxImpulse = 100.0f;
    public float maxChargeTime = 5.0f;
    private float chargeTime = 0.0f;
    private bool isCharging = false;

    public void Start()
    {
        chargeTime = Mathf.Clamp(chargeTime, 0.0f, maxChargeTime);
    }
    public void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            
            ShootBullet();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            chargeTime = 0.0f;
        }
        if (Input.GetButton("Fire1"))
        {
            chargeTime += Time.deltaTime;
        }
    }

    void ShootBullet()
    {

        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position,
        bulletSpawnPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        //Change that equation so that it adds an impulse that follwos charge time
        float bulletImpulse = chargeTime/maxChargeTime *  bulletMaxImpulse;

        //An Impulse is a force you apply on a object in a single instant
        rb.AddForce(bulletSpawnPoint.forward * bulletImpulse, ForceMode.Impulse);
    }

   
}
