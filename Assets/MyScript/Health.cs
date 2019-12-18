using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float hitpoints = (float)3.0;
    [SerializeField] GameObject explosivePrefab;

    void Update()
    {
        if (hitpoints <= 0) {
            if (explosivePrefab) {
                Instantiate(explosivePrefab, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }

    public void ApplyDamage(float amount) {
        hitpoints -= amount;
    }
}
