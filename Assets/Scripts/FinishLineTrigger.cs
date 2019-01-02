using UnityEngine;

public class FinishLineTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
