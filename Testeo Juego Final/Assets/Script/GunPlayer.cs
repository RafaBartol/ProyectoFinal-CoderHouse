using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GunPlayer : MonoBehaviour
{
    public float range = 10f;
    public Camera fpsCam;
    public GameObject effect_Blood;
    public GameObject effect_Impact;
    public ParticleSystem flashEffect;
    //AUDIO
    public AudioSource _audSource;
    public AudioClip clip_Shoot2;
    public AudioClip clip_hit;
    public AudioClip clip_glass;
    public AudioClip clip_rooster;
    public AudioClip clip_scream;
    public AudioClip clip_ShootWall;

    //Variables agregadas
   // public GameObject enemy;

   // public GameObject enemyHit;



    public static float playerLife = 100f;//PARTE DE 20
  //la vida del jugador va de 0 a 100


    // Update is called once per frame
    void Update()
    {
        RaycastEnemigo();

        if (Input.GetMouseButtonDown(0))
        {
            Disparar(); 
        }
      
    }

    void RaycastEnemigo()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hit, range))
        {
            if (Input.GetMouseButtonDown(0) && hit.transform.CompareTag("Enemy"))
            {
                playerLife -= 5f;

                InsertPlaySound(clip_hit);

                hit.transform.gameObject.GetComponent<Enemix>().enemixLife -= 45f;

                GameObject go = Instantiate(effect_Blood, hit.point, Quaternion.LookRotation(hit.normal));
                // punto de detección de la colision, el efecto va a rotar mirando hacia adelante(Jugador)
                Destroy (go, 3f);   
                GameObject goImpact = Instantiate(effect_Impact, hit.point, Quaternion.LookRotation(hit.normal)); 
                Destroy (goImpact, 3f);              
            }
        }

    }

    void Disparar()
    {
        // enemy.GetComponent<Enemix>().enemixLife -= 40f;// 
        flashEffect.Play();
        InsertPlaySound(clip_Shoot2);// siempre que disparo llamo al método
    } 
        
    void InsertPlaySound(AudioClip clip)// maneja la variable clip  
    {
        _audSource.clip = clip;
        _audSource.Play();
    }
    
}