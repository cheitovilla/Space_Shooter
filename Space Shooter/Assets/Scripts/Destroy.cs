using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public GameObject explosion, destruction;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Hit")
        {
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
        if (other.gameObject.tag == "Asteroids")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Audios.instancia.ReproAsteorid();
        }
        else if (other.gameObject.tag == "Player")
        {
            Instantiate(destruction, transform.position, transform.rotation);
            Audios.instancia.ReproNave();
        }
        
      
    }
    public void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }



}
