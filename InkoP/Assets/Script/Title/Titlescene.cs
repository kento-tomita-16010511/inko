using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titlescene : MonoBehaviour
{
    [SerializeField] private Button _anyButton;

    private void Awake()
    {
        //画面全体を押したとき
        _anyButton.onClick.AsObservable().Subscribe(_ 
            => 
        　　{
              SceneManager.LoadScene ("green");
            }).AddTo(this);
    }

    private void SetEvent()
    {
    }

    private void SetBind()
    {
    }
}
