using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject talkPanel;
    public TextMeshProUGUI talkText;
    public GameObject scanObject;
    public bool isAction;


    public void Action(GameObject scabObj)
    {
        if(isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;
            scanObject = scabObj;
            talkText.text = "�̰��� �̸��� " + scanObject.name + "�̶�� �Ѵ�.";
        }
        talkPanel.SetActive(isAction);
    }
}
