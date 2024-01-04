using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePos;
    public float bulletForce = 20f;
 
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) Shoot();
    }
    void Shoot()
    {
        //GameObject bulletTmp = Instantiate(bullet,firePos.position, firePos.rotation);
 
        GameObject bulletTmp = ObjectPooling.instance.GetPoolOjbect();

        if (bulletTmp!=null)
        {
            bulletTmp.transform.position=firePos.position;
            bulletTmp.transform.rotation=firePos.rotation;
            bulletTmp.SetActive(true);
        }
        Rigidbody2D rb = bulletTmp.GetComponent<Rigidbody2D>();
        rb.AddForce(firePos.up * bulletForce, ForceMode2D.Impulse);
    }
}
    