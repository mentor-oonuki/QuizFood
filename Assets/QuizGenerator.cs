using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizGenerator : MonoBehaviour {

	private GameObject quizText;
	private GameObject answerText1;
	private GameObject answerText2;
	private GameObject answerText3;
	private GameObject answerText4;

	// Use this for initialization
	void Start () {
		CsvReader List= 
		//Quiz quiz = QuizStore();
		QuizShow (quiz);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			this.quizText = GameObject.Find ("QuizText");
			this.answerText1 = GameObject.Find ("AnswerText1");
			this.answerText2 = GameObject.Find ("AnswerText2");
			this.answerText3 = GameObject.Find ("AnswerText3");
			this.answerText4 = GameObject.Find ("AnswerText4");
		}
	}
	public Quiz QuizStore () {
		string[] ans = { "5cc", "10cc", "15cc", "20cc" }; //Quizのクラスを別に作る。
		Quiz quiz = new Quiz("大さじ１杯は何cc?", ans, 2); 
		return quiz;//quiz.ans[0]=5ccなどとなる。
	}
	void QuizShow (Quiz quiz) {
		this.quizText = GameObject.Find ("QuizText");
		this.answerText1 = GameObject.Find ("AnswerText1");
		this.answerText2 = GameObject.Find ("AnswerText2");
		this.answerText3 = GameObject.Find ("AnswerText3");
		this.answerText4 = GameObject.Find ("AnswerText4");
		this.quizText.GetComponent <Text> ().text = quiz.quiz; //quiz変数(インスタンス)が持つメンバ変数quiz
		this.answerText1.GetComponentInChildren <Text> ().text = quiz.ans[0];
		this.answerText2.GetComponentInChildren <Text> ().text = quiz.ans[1];
		this.answerText3.GetComponentInChildren <Text> ().text = quiz.ans[2];
		this.answerText4.GetComponentInChildren <Text> ().text = quiz.ans[3];
	} 
}
