﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathParticles : MonoBehaviour {
    private ParticleSystem deathParticles;
    private bool didStart = false;

    private void Start () {
        deathParticles = GetComponent<ParticleSystem>();
    }

    private void Update () {
        if (didStart && deathParticles.isStopped)
            Destroy(gameObject);
    }

    public void Activate () {
        didStart = true;
        deathParticles.Play();
    }

    public void SetDeathFloor(GameObject deathFloor) {
        if (deathParticles == null) {
            deathParticles = GetComponent<ParticleSystem>();
        }
        deathParticles.collision.SetPlane(0, deathFloor.transform);
    }

}
