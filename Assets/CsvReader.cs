using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CsvReader
{
    // 問題ファイルを読み込み Quiz型のリストを返す
    public List<Quiz> ReadFile(string questions)
    {
        // Quiz型のリストを用意
		List<Quiz> QuizList = new List<Quiz>();
		string data;

        // Resourcesフォルダから問題リストを読み込む
        TextAsset textAsset = Resources.Load(questions, typeof(TextAsset)) as TextAsset;
		StringReader rs = new StringReader(textAsset.text);

        // 1行ごとに問題ファイルを読み込み
        while ((data = rs.ReadLine()) != null)
		{
            // Quiz型オブジェクトに問題情報を格納
			string[] q = data.Split(',');
            string[] ans = new string[4];
            Array.Copy(q, 1, ans, 0, 4);
			Quiz quiz = new Quiz(q[0], ans, Int32.Parse(q[5]));
            // Quiz型オブジェクトをQuizリストに追加
            QuizList.Add(quiz);
		}
        // Quizリストを返す
		return QuizList;
	}
}