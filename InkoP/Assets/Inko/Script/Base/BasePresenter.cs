/// <summary>
/// 「MVP」アーキテクチャクラス
///　基礎解説
///  https://www.digitalhearts.com/dh-blog/software_architecture_mvp/
/// </summary>

using UnityEngine;

namespace Assets.Inko.Script.Base
{
    public abstract class BasePresenter<M,V> : MonoBehaviour
        where M : BaseModel , new()
        where V : BaseView  
    {
        /// <summary>
        /// データ処理(内部ロジック)
        /// </summary>
        public  M Model = null;

        /// <summary>
        /// 表示・入出力処理(UI)
        /// </summary>
        [SerializeField] private V _view;
        public V View => _view;

        /// <summary>
        /// 購読前初期化
        /// </summary>
        protected virtual void InitializingBeforeSubsc() {}

        /// <summary>
        /// 購読後
        /// </summary>
        protected virtual void InitializingAfterSubsc() { }

        /// <summary>
        /// Awake
        /// </summary>
        private void Awake()
        {
            Model = new M();
            InitializingBeforeSubsc();
            Bind();
            SetEvent();
            InitializingAfterSubsc();
        }

        /// <summary>
        /// View購読
        /// </summary>
        protected virtual void SetEvent() { }

        /// <summary>
        /// Model購読
        /// </summary>
        protected virtual void Bind() { }

    }
}