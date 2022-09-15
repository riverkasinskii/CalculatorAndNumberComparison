using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField _firstInputField;
    [SerializeField] private InputField _secondInputField;
    [SerializeField] private Text _resultText;

    public void DoComparison()
    {
        _ = double.TryParse(_firstInputField.text, out double firstValue);
        _ = double.TryParse(_secondInputField.text, out double secondValue);

        if (firstValue > secondValue)
        {
            _resultText.text = $"{firstValue} больше чем {secondValue}";
        }
        else if (firstValue < secondValue)
        {
            _resultText.text = $"{firstValue} меньше чем {secondValue}";
        }
        else
        {
            _resultText.text = $"{firstValue} равно {secondValue}";
        }
    }

    
    
}
