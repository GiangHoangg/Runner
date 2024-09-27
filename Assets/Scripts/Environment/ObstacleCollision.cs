using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject playerModel;

    public AudioSource CrashThud;

    void OnTriggerEnter(Collider col) {
        if (col.gameObject == thePlayer) {
          this.gameObject.GetComponent<BoxCollider>().enabled = false;
          thePlayer.GetComponent<PlayerMove>().enabled = false;
          Debug.Log("Collided with player");

          playerModel.GetComponent<Animator>().Play("Stumble Backwards");
          // yield return new WaitForSeconds(1.5f);
          CrashThud.Play();

        }
    }
}
