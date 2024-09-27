using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGO;
    public GameObject fadeIn;
    public AudioSource readyFx;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence(){
        yield return new WaitForSeconds(0.1f);
        countDown3.SetActive(true);
        readyFx.Play();
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDownGO.SetActive(true);
        PlayerMove.canMove = true;

    }


}
