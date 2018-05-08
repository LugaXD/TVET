﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Shooting : MonoBehaviour
    {
        public GameObject bulletPrefab; // Prefab of bullet to spawn
        public float bulletSpeed = 20f; // Speed that the bullet travels
        public float shootRate = 0.2f; // Rate of fire (in seconds)

        private float shootTimer = 0f; // Timer to count up to shoot rate


        void Shoot()
        {
            // Create a new bullet clone
            GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);
            // Grab rigidbody from clone
            Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
            // Add force to the bullet (using bulletSpeed)
            rigid.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
        }
        void Update()
        {
            // SET shootTimer = shootTimer + deltaTime
            shootTimer += Time.deltaTime;
            // IF shootTimer >= shootRate
            if (shootTimer >= shootRate)
            {
                // IF spacebar is down
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    // CALL Shoot()
                    Shoot();
                    // SET shootTimer = 0
                    shootTimer = 0f;
                }
            }
        }
    }
}
