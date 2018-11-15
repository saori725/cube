using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ButtonScript : MonoBehaviour
{

    private void Awake()
    {
        //イベント作成
        EventTrigger.Entry pressDown = new EventTrigger.Entry();
        pressDown.eventID = EventTriggerType.PointerDown;       //イベントのタイプ設定
        pressDown.callback.AddListener((data) => { ShowLog(); });   //メソッド登録

        //イベントトリガーにイベント追加
        GetComponent<EventTrigger>().triggers.Add(pressDown);
    }

    //ログを出すだけのメソッド
    public void ShowLog()
    {
        Debug.Log("ログ！");
    }

}