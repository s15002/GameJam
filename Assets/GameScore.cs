using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScore : MonoBehaviour {
	
	public GameObject Player;


	private int scoreUpPos = -3;

/*	void Start () {
		Player = GameObject.FindWithTag ("Player");
		playerTrans = Player.GetComponent<Transform> ();
		scoreText.text = "Score: 0";
	}

	void Update ()
	{
		float playerHeight = playerTrans.position.y;
		float currentCameraHeight = transform.position.y;
		float newHeight = Mathf.Lerp (currentCameraHeight, playerHeight, 0.5f);
		if (playerHeight > currentCameraHeigsht) {
			transform.position = new Vector3 (transform.position.x, newHeight, transform.position.z);
		}
		////********** 開始 *******
		//scoreUpPosを超えた時
		if (playerTrans.position.y >= scoreUpPos) {
			scoreUpPos += 3; //scoreUpPosを高くする
			score += 10; //scoreに加算

		}
	}*/
	// ********** 終了 *********

	private int score = 0;
	public
	// Use this for initialization
	void Start () {
		GetComponent <Text> ().text = (score).ToString ();
	}

	// Update is called once per frame
	void Update () {
	if ( Player.transform.position.y <= scoreUpPos) {
		scoreUpPos -= 3; //scoreUpPosを高くする
		score += 10; //scoreに加算
		GetComponent<TextMesh>().text = "Score: " + score.ToString();
	}
		
	}

}