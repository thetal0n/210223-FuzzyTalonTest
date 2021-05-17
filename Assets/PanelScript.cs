using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{

    public InputField fieldA;
    public InputField fieldB;
    public InputField fieldC;

    // Update is called once per frame
    public void OnClickRun()
    {
        SceneManager.LoadScene(1);
        FuncInput.funcA = int.Parse(fieldA.text);
        FuncInput.funcB = int.Parse(fieldB.text);
        FuncInput.funcC = int.Parse(fieldC.text);
    }
}

public static class FuncInput
{
    public static int funcA;
    public static int funcB;
    public static int funcC;
}
