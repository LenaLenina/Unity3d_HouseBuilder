using UnityEngine;

// 0/7 = 0 stable
namespace ActionsOnEnableDisableObject.Abstract
{
    /// <summary>
    /// It is not interface because need to use variable that inherit this class in inspector [Serializefield]
    /// You should to use abstract class if assume to use inheritance classes in inspector
    /// </summary>
    public abstract class ActionsServiceOnEnableDisableObjectAbstract : MonoBehaviour
    {
        private void Start()
        {
            
        }

        public abstract void OnEnableObject();

        public abstract void OnDisableObject();
    }
}
