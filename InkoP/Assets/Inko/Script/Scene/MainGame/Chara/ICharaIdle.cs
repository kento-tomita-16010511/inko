
using System.Collections;
/// <summary>
/// キャラクタ－のアイドルインターフェース
/// </summary>
namespace Assets.Inko.Script.Scene.MainGame.Chara
{
	public interface ICharaIdle
	{
        IEnumerator Idle();
	}
}