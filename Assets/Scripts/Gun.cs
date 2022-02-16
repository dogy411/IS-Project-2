using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
public Rigidbody bulletPrefab;

public Transform bulletSpawn;

    public bool debug = false;
[Range(10,100)]
    public float bulletSpeed = 50;

    public int totalAmmo = 30;
    public int clipSize = 10;
    public int clip = 0;

    public void Reload(){
        if(clip == clipSize)
        {
            if(debug) Debug.Log("Full");
            return;
        }
        int partialClip = 0;
        if(clip > 0) partialClip = clip;

        if(totalAmmo + clip >= clipSize)
        {
            totalAmmo -= (clipSize - clip);
            clip = clipSize;
        }
        else{
            clip = totalAmmo + clip;
            totalAmmo = 0;
        }
       
    }
   
   public void Fire() 
   {
       if(clip > 0){
           clip -=1;
      if(debug) Debug.Log("Pew Pew");
      Rigidbody bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
      bullet.transform.Translate(0,0,3);
      bullet.AddRelativeForce(Vector3.forward * bulletSpeed, ForceMode.Impulse);
       }
      else {
                    if(debug) Debug.Log("Empty");
   }
   }
   }
            
    
        