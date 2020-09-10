using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Title
{
    public class TitleSceneView : MonoBehaviour
    {
        /// <summary>
        /// 全体のタップ
        /// </summary>
        [SerializeField] private Button _anyButton;
        public Button.ButtonClickedEvent AnyButtonEvent => _anyButton.onClick;

        /// <summary>
        /// タイトル
        /// </summary>
        [SerializeField] private Text _titleText;

        /// <summary>
        /// Scene演出組み込む予定
        /// </summary>
        /// <returns></returns>
        public IEnumerator SceneNextAnimation()
        {
            yield return null;
        }
    }
}