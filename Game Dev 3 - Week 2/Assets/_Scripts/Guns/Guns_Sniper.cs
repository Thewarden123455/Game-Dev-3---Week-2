using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Guns
{
    public class Guns_Sniper : Guns_Parent
    {
        public override void GunSound()
        {
            //To randomise the pitch between two values
            gunAudioSource.pitch = Random.Range(0.6f, 1.4f);
            //To play the sound once
            gunAudioSource.PlayOneShot(gunSound);
        }
    }
}
