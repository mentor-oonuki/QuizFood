using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Shuffle : MonoBehaviour {

	private GameObject test;
	// Use this for initialization
	void Start () {
		this.test = GameObject.Find ("test");
		string[] q1 = new string[] { "1", "・・・", "A", "B", "C", "D", "B", "日本" };
		string[] q2 = new string [4];
		Array.Copy (q1, 2, q2, 0, 4);

		Debug.Log (q2[0]+q2[1]+q2[2]+q2[3]);
		string[] q3 = new string [4];
		q3 = q2.OrderBy(i=> Guid.NewGuid()).ToArray();
		this.test.GetComponent <Text> ().text = q3[0]+q3[1]+q3[2]+q3[3];
	}

	// Update is called once per frame
	void Update () {
		
	}
	void Shuffle_judge(){
		
	}

}
