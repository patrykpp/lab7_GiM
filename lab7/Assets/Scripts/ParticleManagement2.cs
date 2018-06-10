using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManagement2 : MonoBehaviour
{

    ParticleSystem particles;
    // Use this for initialization
    void Start()
    {
        particles = gameObject.GetComponent<ParticleSystem>();
        particles.enableEmission = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            particles.enableEmission = !particles.enableEmission;
        }
    }
}
