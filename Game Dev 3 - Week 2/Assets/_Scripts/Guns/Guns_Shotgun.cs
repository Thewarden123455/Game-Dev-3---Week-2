using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Guns
{
    public class Guns_Shotgun : Guns_Parent
    {
        public override void GunSound()
        {
            //Randomises the pitch of the sound between two values
            gunAudioSource.pitch = Random.Range(0.6f, 1.4f);
            //Plays the sound once
            gunAudioSource.PlayOneShot(gunSound);
        }

        public override void MuzzleFlash()
        {
            //Will execute whateber the
            base.MuzzleFlash();
            //Stores the muzzle flash particle system
            ParticleSystem.MainModule muzzleFlashParticles = muzzleFlash.GetComponent<ParticleSystem>().main;
            //Changes its colour to white
            muzzleFlashParticles.startColor = Color.white;
        }
    }
}
