using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pistol : AmmoBasedWeapon
{

    [Header("Pistol")]
    [SerializeField] private Bullet bulletPrefab;

    protected override void ShootProjectiles()
    {
       Bullet newBullet = Instantiate(bulletPrefab, owner.GetPosition(), Quaternion.identity) as Bullet;
        newBullet.LaunchInDirection(owner, owner.GetLookDirection());
    }

}
