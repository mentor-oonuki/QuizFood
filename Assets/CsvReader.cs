using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CsvReader
{
	private List<Quiz> QuizList;

	public List<Quiz> ReadFile(string questions)//List型のQuizListが帰ってくる
	{
		List<Quiz> QuizList = new List<Quiz>();
		string data;
		string[] ans = new string[4];

		TextAsset textAsset = Resources.Load(questions, typeof(TextAsset)) as TextAsset;
		StringReader rs = new StringReader(textAsset.text);
		while ((data = rs.ReadLine()) != null)
		{
			string[] q = data.Split(',');
			Array.Copy(q, 1, ans, 0, 4);
			Quiz quiz = new Quiz(q[0], ans, Int32.Parse(q[5]));
			QuizList.Add(quiz);
		}
		return QuizList;
	}
}