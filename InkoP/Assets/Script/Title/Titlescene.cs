using Const;
using UniRx;
using UnityEngine;

namespace Title
{
    public class Titlescene : Scene.SceneBase
    {
        [SerializeField] private TitleSceneView _view;

        private void Awake()
        {
           
        }

        protected override void OnAwake()
        {
            SetEvent();
        }

        private void SetEvent()
        {
            //画面全体を押したとき
            _view.AnyButtonEvent.AsObservable().Subscribe(_ =>
            {
                //これでシーン移動
                SceneLoad(SceneConst.MainSceneName);
            }).AddTo(this);
        }
    }
}
