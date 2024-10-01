using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject liveDis;
    public GameObject endScreem;
    public GameObject fadeOut;

    void Update()
    {
        
    }

    public IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(2);
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        endScreem.SetActive(true);
        // yield return new WaitForSeconds(5);
        // fadeOut.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
