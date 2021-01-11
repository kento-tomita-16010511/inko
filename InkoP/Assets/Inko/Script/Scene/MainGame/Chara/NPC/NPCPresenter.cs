
using System.Collections;

/// <summary>
/// NPCのPresenter
/// </summary>

namespace Assets.Inko.Script.Scene.MainGame.Chara.NPC
{
    public class NPCPresenter : CharaBasePresenter<NPCModel, NPCView>
    {
        /// <summary>
        /// アイドル
        /// </summary>
        public override IEnumerator Idle()
        {
            yield return null;
        }

        /// <summary>
        /// アタック
        /// </summary>
        public override IEnumerator Attack()
        {
            yield return null;
        }

        /// <summary>
        /// ジャンプ
        /// </summary>
        public override IEnumerator Jump()
        {
            yield return null;
        }


        /// <summary>
        /// 移動
        /// </summary>
        public override IEnumerator Move()
        {
            yield return null;
        }

        protected override void Bind()
        {
            base.Bind();
        }

        protected override void InitializingAfterSubsc()
        {
        }

        protected override void InitializingBeforeSubsc()
        {
        }

        protected override void SetEvent()
        {
        }




    }
}