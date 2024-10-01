using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject playerModel;

    public AudioSource CrashThud;
    public GameObject mainCam;

    public GameObject levelControl;

    void OnTriggerEnter(Collider col) {
        if (col.gameObject == thePlayer) {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = false;
            Debug.Log("Collided with player");

            playerModel.GetComponent<Animator>().Play("Stumble Backwards");
            levelControl.GetComponent<LevelDistance>().enabled = false;
            CrashThud.Play();
            mainCam.GetComponent<Animator>().enabled = true;

            // Trigger the EndRunSequence after the collision
            StartCoroutine(levelControl.GetComponent<EndRunSequence>().EndSequence());
        }
    }
}
