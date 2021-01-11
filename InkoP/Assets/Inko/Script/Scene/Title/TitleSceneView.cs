using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

/// <summary>
/// タイトルシーンのView
/// </summary>
namespace Title
{
    public class TitleSceneView : MonoBehaviour
    {
        /// <summary>
        /// タイトルのキャンパスグループ
        /// </summary>
        [SerializeField] private CanvasGroup _titleCanvasGroup;

        public CanvasGroup TitleCanvasGroup => _titleCanvasGroup;

        /// <summary>
        /// 全体のタップ
        /// </summary>
        [SerializeField] private Button _anyButton;

        public Button AnyButton => _anyButton;

        /// <summary>
        /// タイトル
        /// </summary>
        [SerializeField] private Text _titleText;

        /// <summary>
        /// ビデオ
        /// </summary>
        [SerializeField] private VideoPlayer _video;

        public VideoPlayer VideoPlayer => _video;

        /// <summary>
        /// ローディングのアニメーション
        /// </summary>
        [SerializeField] private Animator _loadingAnimator;

        public Animator LoadingAnimator => _loadingAnimator;

        /// <summary>
        /// 注意書きのキャンパスグループ
        /// </summary>
        [SerializeField] private CanvasGroup _precautionaryStatementGroup;

        public CanvasGroup PrecautionaryStatementGroup => _precautionaryStatementGroup;
    }
}