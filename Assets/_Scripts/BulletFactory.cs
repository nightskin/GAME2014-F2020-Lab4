using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("bullet types")]
    public GameObject regularBullet;
    public GameObject fatBullet;
    public GameObject pulsingBullet;


    public GameObject CreateBullet(BulletType type = BulletType.Random)
    {
        GameObject temp = null;
        
        if (type == BulletType.Random)
        {
            int r = Random.Range(0, 3);
            if(r==0)
            {
                type = BulletType.Normal;
            }
            else if(r==1)
            {
                type = BulletType.Fat;
            }
            else if(r==2)
            {
                type = BulletType.Pulsing;
            }
        }
        
        if (type==BulletType.Normal)
        {
           temp = Instantiate(regularBullet);
           temp.GetComponent<BulletController>().ApplyDamage();
        }
        else if(type==BulletType.Fat)
        {
            temp = Instantiate(fatBullet);
            temp.GetComponent<BulletController>().ApplyDamage();
        }
        else if(type==BulletType.Pulsing)
        {
            temp = Instantiate(pulsingBullet);
            temp.GetComponent<BulletController>().ApplyDamage();
        }
        
        temp.transform.parent = transform;
        temp.SetActive(false);
        return temp;
    }
}
