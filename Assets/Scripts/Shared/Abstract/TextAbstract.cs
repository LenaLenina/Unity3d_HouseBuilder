using UnityEngine;


namespace Shared.Abstract
{
    // 0/4 = 0 stable
    public abstract class TextAbstract : MonoBehaviour
    {
        public abstract void Write(string message);

        public abstract void Clear();
    }
}
