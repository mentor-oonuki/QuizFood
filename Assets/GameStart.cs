using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	public void NextScene(){
		//今いるシーンがTitleという名前であれば、Quizという名前のシーンに移動する
		if (SceneManager.GetActiveScene ().name == "Title") {
			SceneManager.LoadScene ("GameScene");
		}
	}
}
