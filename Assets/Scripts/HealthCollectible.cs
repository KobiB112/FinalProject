using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    public ParticleSystem HealthEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Instantiate(HealthEffect, new Vector2(0.0f, 0.0f), Quaternion.identity);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }

        }

    }
}