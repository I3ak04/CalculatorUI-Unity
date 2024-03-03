using System;
using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private Text InputNumber1;
    [SerializeField] private Text InputNumber2;
    [SerializeField] private Text AnswerText;

    private float num1, num2;
    
    public void Compare()
    {
        num1 = Convert.ToInt32(InputNumber1.text);
        num2 = Convert.ToInt32(InputNumber2.text);

        if (num1 > num2)
        {
            AnswerText.text = num1.ToString() + " ������";
        }
        else if (num1 < num2) 
        {
            AnswerText.text = num2.ToString() + " ������";
        }
        else if (num1 == num2)
        {
            AnswerText.text = "�����";
        }
        
    }

    
}
