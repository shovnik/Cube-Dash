using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;

	void Update ()
    {
        score.text = (player.position.z * 0.3).ToString("0");
	}
}
