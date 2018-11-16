using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{

    InputField inputField;
    private string inputNum;
    private int n;


    /// <summary>
    /// Startメソッド
    /// InputFieldコンポーネントの取得および初期化メソッドの実行
    /// </summary>
    void Start()
    {

        inputField = GetComponent<InputField>();

        InitInputField();
    }



    /// <summary>
    /// Log出力用メソッド
    /// 入力値を取得してLogに出力し、初期化
    /// </summary>


    public void InputLogger()
    {

        string inputValue = inputField.text;

        Debug.Log(inputValue);

        InitInputField();
    }



    /// <summary>
    /// InputFieldの初期化用メソッド
    /// 入力値をリセットして、フィールドにフォーカスする
    /// </summary>


    void InitInputField()
    {

        // 値をリセット
        inputField.text = "";

        // フォーカス
        inputField.ActivateInputField();
    }


    void Update()
    {
        // キーボードからの入力情報を取得する。
        if (Input.GetKeyDown(KeyCode.Return))
        {

            // （ポイント）スクリプトは「InputField」につける。
            // InputFieldのtextプロパティから入力値を取得する。
            inputNum = this.gameObject.GetComponent<InputField>().text;

            // 入力値は「string型」なのでこれを「int型」に変換する。
            n = int.Parse(inputNum);

            transform.position = new Vector3(n , 0 ,0);
        }
    }
}