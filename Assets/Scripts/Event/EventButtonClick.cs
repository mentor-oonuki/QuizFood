using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventButtonClick : MonoBehaviour {

    public void OnClickButton()
    {
        QuizManager.Instance.OnButton(tag);
    }

}
