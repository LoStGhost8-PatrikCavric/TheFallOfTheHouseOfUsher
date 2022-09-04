using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jumpscare : MonoBehaviour
{
    public Image image;
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(JumpScare_CR());
    }

    IEnumerator JumpScare_CR()
    {
        image.enabled = true;
        audioSource.Play();
        yield return new WaitForSeconds(0.5f);
        image.enabled = false;
    }
}
