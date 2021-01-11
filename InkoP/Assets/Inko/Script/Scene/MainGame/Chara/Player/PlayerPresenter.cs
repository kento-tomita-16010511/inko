using System.Collections;

using Assets.Inko.Script.Enum;
using Assets.Inko.Script.JoystickEvent;

using UniRx;

using UnityEngine;

/// <summary>
/// playerのpresenterクラス
/// </summary>
namespace Assets.Inko.Script.Scene.MainGame.Chara.Player
{
    public class PlayerPresenter : CharaBasePresenter<PlayerModel, PlayerView>
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
            var joy = JoysitickManager.Instance;
            var forward = new Vector3(joy.Horizontal, 0, joy.Vertical);
            transform.position += forward * Model.MoveSpeed * Time.deltaTime;

            yield return null;
        }

        protected override void Bind()
        {
            base.Bind();
            //ジョイスティック監視
            JoysitickManager.Instance.Forward.Subscribe(it => {
                if (it.x == 0 && it.y == 0) {
                    Model.SetCharaState(CharaEnum.CharaState.Idle);
                }
                else {
                    Model.SetCharaState(CharaEnum.CharaState.Move);
                }
            }).AddTo(this);

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