using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : SingletonMonoBehaviour<QuizManager> {

    private QuizGenerator quizGenerator;
    private Quiz quiz;

    protected void Start()
    {
        quizGenerator = new QuizGenerator();
        // 問題ファイル読み込み
        quizGenerator.Initialize();

        QuizSelect();
    }

    // 問題をランダムに取得表示
    private void QuizSelect()
    {
        quiz = quizGenerator.QuizStore();
        quizGenerator.QuizShow(quiz);
        Timer.Instance.TimerStart();
    }

    // ボタンが押されたとき呼び出される
    public void OnButton(string tag)
    {
        Debug.Log("Press : " + tag );
        QuizSelect();
    }

}
