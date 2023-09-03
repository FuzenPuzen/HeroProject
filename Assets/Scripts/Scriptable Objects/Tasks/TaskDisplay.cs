using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskDisplay : MonoBehaviour
{
    public TaskSC taskSC;

    public Image backgrownd;

    public Text taskText;
    public Text rewardCount;
    public Text progressText;

    public void Start()
    {
        backgrownd.sprite = taskSC.backgrownd;
        taskText.text = taskSC.taskText;
        rewardCount.text = taskSC.rewardCount;
        progressText.text = taskSC.progressText;
    }
}
