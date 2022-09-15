using System;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorGame : MonoBehaviour
{
    [SerializeField] private Text _resultText;
    [SerializeField] private InputField _firstInputField;
    [SerializeField] private InputField _secondInputField;    

    public void DoOperation(int value)
    {        
        _ = double.TryParse(_firstInputField.text, out double firstValue);
        _ = double.TryParse(_secondInputField.text, out double secondValue);

        _resultText.text = value switch
        {
            0 => (firstValue + secondValue).ToString(),
            1 => (firstValue * secondValue).ToString(),
            2 => (firstValue - secondValue).ToString(),
            3 => (firstValue / secondValue).ToString(),
            _ => throw new ArithmeticException(),
        };
    }
        

}
