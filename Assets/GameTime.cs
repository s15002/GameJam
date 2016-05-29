﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameTime : MonoBehaviour {
	public float time = 60;
	public
	// Use this for initialization
	void Start () {
		GetComponent <Text> ().text = ((int)time).ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;

		if (time < 0)
			time = 0;
		GetComponent<TextMesh>().text = ("Time:") + ((int)time).ToString();
	}
}
