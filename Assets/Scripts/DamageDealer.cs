using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int damege = 100;
    
    public int GetDamage()
    {
        return damege;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }

}
