using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject Sword1;
    public bool CanAttack = true;
    public float AttackCooldown = 1.0f;

    void Update()
    {
        if  (Input.GetMouseButton(0))
        {
            if (CanAttack) 
            {
                SwordSwing();
            }
        }
    }

    public void SwordSwing()
    {
        CanAttack = false;
        Animator anim = Sword1.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(ResetAttackCooldown());
    }

    IEnumerator ResetAttackCooldown() 
    {
        yield return new WaitForSeconds(AttackCooldown);
        CanAttack = true;
    }
}
