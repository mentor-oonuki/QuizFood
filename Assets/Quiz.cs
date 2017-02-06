using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz {
	public string quiz = "";
	public string[] ans = new string[4];
	public int num; //正解の番号

	//コンストラクタ
	public Quiz (string quiz, string[] ans, int num) {
		this.quiz = quiz;
		this.ans = ans;
		this.num = num;
	}
}

