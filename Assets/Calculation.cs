using System;
using UnityEngine;
using UnityEngine.UI;

public class Calculation : MonoBehaviour
{
    [SerializeField] private Text InputNumber1;
    [SerializeField] private Text InputNumber2;
    [SerializeField] private Text AnswerText;

    private float num1, num2;
    
    public void Plus()
    {
        num1 = Convert.ToInt32(InputNumber1.text);
        num2 = Convert.ToInt32(InputNumber2.text);
        AnswerText.text = Convert.ToString(num1 + num2);
    }
    public void Minus()
    {
        num1 = Convert.ToInt32(InputNumber1.text);
        num2 = Convert.ToInt32(InputNumber2.text);
        AnswerText.text = Convert.ToString(num1 - num2);
        
    }
    public void Multiply()
    {
        num1 = Convert.ToInt32(InputNumber1.text);
        num2 = Convert.ToInt32(InputNumber2.text);
        AnswerText.text = Convert.ToString(num1 * num2);
    }
    public void Divide()
    {
        num1 = Convert.ToInt32(InputNumber1.text);
        num2 = Convert.ToInt32(InputNumber2.text);
        AnswerText.text = Convert.ToString(num1 / num2);
    }

}