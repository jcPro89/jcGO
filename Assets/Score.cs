using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform runner;
	public Text scoreText;

	// Update is called once per frame
	void Update () {
		scoreText.text = runner.position.z.ToString("0");		
	}
}
