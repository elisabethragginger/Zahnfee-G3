using UnityEngine;

public class TestMono : MonoBehaviour
{
    string myName = "elisabeth";

    // Use this for initialization
    public void PrintDebug ()
    { 
    Debug.Log("Start");
    }

    public void PrintmyName(string myNameis)
    {
        Debug.Log("Mein Name ist:" +myNameis);
    }

    // Use this for initialization
   public void AddNumbers(int first, int second)
    {
        Debug.Log("Add Numbers: first + second" + (first + second));
    }

    public void MultiplyNumbers(int first, int second, int third)
    {
        Debug.Log("Multiply Numbers: first * second * third" + (first * second * third));
    }

    public void DivideNumbers(float first, float second, float third)
    {
        Debug.Log("Divide Numbers: first / second / third" + (first / second / third));
    }

    void Start()
    {
        PrintDebug();
        AddNumbers(1, 2);
        MultiplyNumbers(1, 2, 3);
        DivideNumbers(1.0f, 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
