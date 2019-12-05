using UnityEngine;
using UnityEngine.UI;

public class ComputerNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;
    float varA;
    float varB; 

    public void SetResult()
    {
       float a = float.Parse(ipVarA.text);
       float b = float.Parse(ipVarB.text);
       Debug.Log("in SetResult" + (a - b));
    }

    public float SubstractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        return result; 
    }
}
