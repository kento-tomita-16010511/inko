namespace Assets.Inko.Script.Scene.MainGame.Chara.Player
{
    public class PlayerModel : CharaBaseModel
    {
        /// <summary>
        /// キャラスピード
        /// </summary>
        private float _moveSpeed = 10f;
        public float MoveSpeed => _moveSpeed;
    }
}