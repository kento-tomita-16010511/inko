using Assets.Inko.Script.Base;

using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Characterの立ち絵View
/// </summary>
namespace Assets.Inko.Script.UI.Character
{
    public class CharacterStandingImageView : BaseView
    {
        /// <summary>
        /// 立ち絵
        /// </summary>
        [SerializeField]
        private Image _standingImage;

        /// <summary>
        /// 立ち絵更新
        /// </summary>
        public void UpdateView(string path)
        {

            Sprite sp = Resources.Load<Sprite>(path);
            _standingImage.sprite = sp;
        }

    }
}