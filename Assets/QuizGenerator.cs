using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizGenerator : MonoBehaviour {

    // 問題リスト格納先
    private List<Quiz> QuizList = new List<Quiz>();
    // 問題リストファイル名(拡張子不要)
    private string QuizFilename = "questions";

    // UIオブジェクト格納先
    private GameObject quizText;
	private GameObject answerText1;
	private GameObject answerText2;
	private GameObject answerText3;
	private GameObject answerText4;


    void Start () {
        // クイズリスト読み込み
        CsvReader csvReader = new CsvReader();
        QuizList = csvReader.ReadFile(this.QuizFilename);

        // UIオブジェクト格納
        this.quizText = GameObject.Find("QuizText");
        this.answerText1 = GameObject.Find("AnswerText1");
        this.answerText2 = GameObject.Find("AnswerText2");
        this.answerText3 = GameObject.Find("AnswerText3");
        this.answerText4 = GameObject.Find("AnswerText4");
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
            Quiz quiz = QuizStore();
            QuizShow(quiz);
        }
	}

    // 問題情報をランダムに取得
	public Quiz QuizStore () {
        // 問題番号をランダムに指定
        int number = Random.Range(0, QuizList.Count);
        return QuizList[number];
	}

    // 問題をUIに表示
    void QuizShow (Quiz quiz) {
        this.quizText.GetComponent<Text>().text = quiz.quiz;
		this.answerText1.GetComponentInChildren <Text> ().text = quiz.ans[0];
		this.answerText2.GetComponentInChildren <Text> ().text = quiz.ans[1];
		this.answerText3.GetComponentInChildren <Text> ().text = quiz.ans[2];
		this.answerText4.GetComponentInChildren <Text> ().text = quiz.ans[3];
	} 
}
