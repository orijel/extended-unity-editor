using UnityEngine;

namespace Assets.ExtendedUnityEditor.Runtime
{
    public class ScriptWithTagExample : MonoBehaviour
    {
        public Tag MyCoolTag;
        [SerializeField, Tag] private string _tagAsAttribute;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
