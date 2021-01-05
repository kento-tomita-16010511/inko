using Assets.Inko.Script.UI.Character;

/// <summary>
/// NPCのモデルクラス
/// </summary>
namespace Assets.Inko.Script.Scene.MainGame.Chara.NPC
{
    public class NPCModel : CharaBaseModel
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
            _standingImageData = new CharacterStandingImageDataModel(Const.ResourcesPathConst.MainMobStandingPicturePath);
        }
    }
}