using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Judge : MonoBehaviour {

	//選択したボタンのテキストラベルと正解のテキストを比較して正誤を判定
	public void JudgeAnswer(){
		//正解のデータをテキストでセットする
		//string answerText = "15cc";
		//選択したボタンのテキストラベルを取得する
		Text selectedBtn = this.GetComponentInChildren<Text> ();
		Debug.Log ("click!");
		if (selectedBtn.text == "15cc") {
			Debug.Log("正解");
		} else {
			Debug.Log("不正解");
		}
	}
}