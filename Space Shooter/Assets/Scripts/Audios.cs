using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audios : MonoBehaviour {

    public static Audios instancia;

    public AudioSource audiosour;
    public AudioClip soundAsteroid;
    public AudioClip soundNave;
    private void Awake()
    {
        instancia = this;
    }
    public void ReproAsteorid()
    {
        audiosour.PlayOneShot(soundAsteroid);
    }

    public void ReproNave()
    {
        audiosour.PlayOneShot(soundNave);
    }


}
