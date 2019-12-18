using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damageAmount = 10;

    private void OnCollisionEnter(Collision collision) {
        Health health = collision.gameObject.GetComponent<Health>();
        if (health) {
            health.ApplyDamage(damageAmount);
        }
    }
}
