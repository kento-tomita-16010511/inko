using Assets.Inko.Script.UI.Character;


/// <summary>
/// playerのモデルクラス
/// </summary>
namespace Assets.Inko.Script.Scene.MainGame.Chara.Player
{
    public class PlayerModel : CharaBaseModel
    {
        /// <summary>
        /// キャラスピード
        /// </summary>
        private float _moveSpeed = 10f;
        public float MoveSpeed => _moveSpeed;

        protected override void initialized()
        {
            base.initialized();

            //立ち絵データ作成
            _standingImageData = new CharacterStandingImageDataModel(Const.ResourcesPathConst.PlayerStandingPicturePath);
        }
    }
}