/// <summary>
/// キャラクタ－のBaseのModelクラス
/// </summary>


using Assets.Inko.Script.Base;
using Assets.Inko.Script.UI.Character;

using UniRx;

using static Assets.Inko.Script.Enum.CharaEnum;

namespace Assets.Inko.Script.Scene.MainGame.Chara
{
    public class CharaBaseModel : BaseModel
    {
        /// <summary>
        /// 立ち絵のデータ
        /// </summary>
        protected CharacterStandingImageDataModel _standingImageData;
        public CharacterStandingImageDataModel StandingImageDataModel => _standingImageData;


        /// <summary>
        /// playerの状態
        /// </summary>
        private ReactiveProperty<CharaState> _state = new ReactiveProperty<CharaState>(CharaState.Idle);

        public IReactiveProperty<CharaState> State => _state;

        /// <summary>
        /// 状態を設定する
        /// </summary>
        public void SetCharaState(CharaState state)
        {
            _state.SetValueAndForceNotify(state);
        }

        protected override void initialized()
        {

        }
    }
}