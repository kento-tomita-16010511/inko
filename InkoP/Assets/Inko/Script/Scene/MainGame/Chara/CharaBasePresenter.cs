/// <summary>
/// キャラクタ－のベース
/// </summary>
using Assets.Inko.Script.Base;
using UniRx;
using System.Collections;
using UnityEngine;

namespace Assets.Inko.Script.Scene.MainGame.Chara
{
    public abstract class CharaBasePresenter<M, V> : BasePresenter<M, V>, 
        ICharaIdle, ICharaAttack, ICharaJump, ICharaMove
        where M : CharaBaseModel,new()
        where V : CharaBaseView
    {
        /// <summary>
        /// 状態イテレータ
        /// </summary>
        private IEnumerator _charaEnumerator = null;

        protected override void Bind()
        {
            //状態繊維監視
            Model.State.Subscribe(it => {
                if (_charaEnumerator != null) { 
                    StopCoroutine(_charaEnumerator);
                }
                IEnumerator enumerator = null;
                switch (it) {
                    case Enum.CharaEnum.CharaState.None:
                        break;
                    case Enum.CharaEnum.CharaState.Idle:
                        var iCharaIdle = gameObject.GetComponent<ICharaIdle>();
                        enumerator = iCharaIdle.Idle();
                        break;
                    case Enum.CharaEnum.CharaState.Attack:
                        var iCharaAttack = gameObject.GetComponent(typeof(ICharaAttack)) as ICharaAttack;
                        enumerator = iCharaAttack.Attack();
                        break;
                    case Enum.CharaEnum.CharaState.Jump:
                        var iCharaJump = gameObject.GetComponent(typeof(ICharaJump)) as ICharaJump;
                        enumerator = iCharaJump.Jump();
                        break;
                    case Enum.CharaEnum.CharaState.Move:
                        var iCharaMove = gameObject.GetComponent(typeof(ICharaMove)) as ICharaMove;
                        enumerator = iCharaMove.Move();
                        break;
                }
                _charaEnumerator = StateEnumerator(enumerator);
                StartCoroutine(_charaEnumerator);
            }).AddTo(this);
        }

        /// <summary>
        /// 状態遷移ループ関数
        /// </summary>
        private IEnumerator StateEnumerator(IEnumerator enumerator)
        {
            while (enumerator.MoveNext()) {
                yield return null;
            }
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

        public virtual IEnumerator Idle() {
            yield return null;
        }

        public virtual IEnumerator Attack()
        {
            throw new System.NotImplementedException();
        }

        public virtual IEnumerator Jump()
        {
            throw new System.NotImplementedException();
        }

        public virtual IEnumerator Move()
        {
            throw new System.NotImplementedException();
        }
    }
}