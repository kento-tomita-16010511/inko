/// <summary>
/// キャラクタ－のベース
/// </summary>

using Assets.Inko.Script.Scene.MainGame.Chara;
using UnityEngine;
using UnityEngine.UI;

public class CharaBase : MonoBehaviour, ICharaIdle
{
    [SerializeField] private Image _charaImage;

	public virtual void Idle()
	{

	}
}
