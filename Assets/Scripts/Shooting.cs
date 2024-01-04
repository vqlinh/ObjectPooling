using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePos;
    public Transform firePos1;
    public Transform firePos2;
    public float bulletForce = 20f;

    private void Start()
    {
        InvokeRepeating("Shoot", 0f, 0.2f);
    }

    void Shoot()
    {
        GameObject bulletTmp = ObjectPooling.instance.GetPoolOjbect();
        if (bulletTmp != null)
        {
            bulletTmp.transform.position = firePos.position;
            bulletTmp.transform.rotation = firePos.rotation;
            bulletTmp.SetActive(true);
            Rigidbody2D rb = bulletTmp.GetComponent<Rigidbody2D>();
            rb.AddForce(firePos.up * bulletForce, ForceMode2D.Impulse);
        }
        GameObject bulletTmp1 = ObjectPooling.instance.GetPoolOjbect();
        if (bulletTmp1 != null)
        {
            bulletTmp1.transform.position = firePos1.position;
            bulletTmp1.transform.rotation = firePos1.rotation;
            bulletTmp1.SetActive(true);
            Rigidbody2D rb1 = bulletTmp1.GetComponent<Rigidbody2D>();
            rb1.AddForce(firePos1.up * bulletForce, ForceMode2D.Impulse);
        }
        GameObject bulletTmp2 = ObjectPooling.instance.GetPoolOjbect();
        if (bulletTmp2 != null)
        {
            bulletTmp2.transform.position = firePos2.position;
            bulletTmp2.transform.rotation = firePos2.rotation;
            bulletTmp2.SetActive(true);
            Rigidbody2D rb2 = bulletTmp2.GetComponent<Rigidbody2D>();
            rb2.AddForce(firePos2.up * bulletForce, ForceMode2D.Impulse);
        }
    }

}
