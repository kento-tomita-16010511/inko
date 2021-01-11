using Assets.Inko.Script.Base;

/// <summary>
/// Characterの立ち絵Model
/// </summary>
namespace Assets.Inko.Script.UI.Character
{
    public class CharacterStandingImageDataModel : BaseModel
    {
        /// <summary>
        /// 立ち絵のパス
        /// </summary>
        private string _path;
        public string Path => _path;

        protected override void initialized()
        {
        }

        public CharacterStandingImageDataModel(string path)
        {
            _path = path;
        }
    }
}