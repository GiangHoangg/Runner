using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
   void OnTriggerEnter(Collider col) {
        coinFX.Play();
        PointCoin.coinCount += 1;
        this.gameObject.SetActive(false);
   }
}
