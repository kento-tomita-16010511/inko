using System.Collections;
using Const;
using DG.Tweening;
using Scene;
using UniRx;
using UnityEngine;

/// <summary>
/// タイトルシーン
/// </summary>
namespace Title
{
    public class Titlescene : SceneBase
    {
        [SerializeField] private TitleSceneView _view;

        protected override void Awake()
        {
            Bind();
            SetEvent();
            _view.AnyButton.gameObject.SetActive(false);
            _view.VideoPlayer.gameObject.SetActive(true);
        }

        private void Bind()
        {
        }

        private void SetEvent()
        {
            //画面全体を押したとき
            _view.AnyButton.onClick.AsObservable().Subscribe(_ => {
                //これでシーン移動
                SceneLoad(SceneConst.MainSceneName);
            }).AddTo(this);

            //シーンスタートの演出開始
            //動画終了までまつ
            _view.VideoPlayer.loopPointReached += it => StartCoroutine(SceneFlowProduction());
        }

        /// <summary>
        /// タイトルの流れ演出
        /// </summary>
        private IEnumerator SceneFlowProduction()
        {
            _view.VideoPlayer.gameObject.SetActive(false);
            //ロード開始
            yield return LoadingAnimatorProduction();

            // 注意書きアニメーション開始
            yield return PrecautionaryStatementProduction();

            //タイトルオブジェクトフィードイン
            yield return TitleCanvasFadeInProduction();
            _view.AnyButton.gameObject.SetActive(true);
        }

        /// <summary>
        /// ローディングアニメーション演出
        /// </summary>
        /// <returns></returns>
        private IEnumerator LoadingAnimatorProduction()
        {
            //ローディング表示
            _view.LoadingAnimator.gameObject.SetActive(true);
            //TODO : 冨田　読みこみ部分入れる仮で2秒待つ
            yield return new WaitForSeconds(2f);
            _view.LoadingAnimator.gameObject.SetActive(false);
        }

        /// <summary>
        /// 注意書き
        /// </summary>
        /// <returns></returns>
        private IEnumerator PrecautionaryStatementProduction()
        {
            _view.PrecautionaryStatementGroup.gameObject.SetActive(true);
            yield return _view.PrecautionaryStatementGroup.DOFade(1f, 1f).WaitForCompletion();
            //TODO : 冨田　見せるように2秒待つ
            yield return new WaitForSeconds(1f);
            yield return _view.PrecautionaryStatementGroup.DOFade(1f, 0f).WaitForCompletion();
            _view.PrecautionaryStatementGroup.gameObject.SetActive(false);
        }

        /// <summary>
        /// タイトルオブジェクトフェードイン
        /// </summary>
        /// <returns></returns>
        private IEnumerator TitleCanvasFadeInProduction()
        {
            yield return _view.TitleCanvasGroup.DOFade(1f, 1f).WaitForCompletion();
        }
    }
}