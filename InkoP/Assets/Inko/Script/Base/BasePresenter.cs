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
        public V View;

        /// <summary>
        /// 購読前初期化
        /// </summary>
        abstract protected void InitializingBeforeSubsc();

        /// <summary>
        /// 購読後
        /// </summary>
        abstract protected void InitializingAfterSubsc();

        /// <summary>
        /// Awake
        /// </summary>
        private void Awake()
        {
            InitializingBeforeSubsc();
            Bind();
            SetEvent();
            InitializingAfterSubsc();
        }

        /// <summary>
        /// View購読
        /// </summary>
        abstract protected void SetEvent();

        /// <summary>
        /// Model購読
        /// </summary>
        abstract protected void Bind();

    }
}