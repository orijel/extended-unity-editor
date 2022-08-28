using Assets.ExtendedUnityEditor.Runtime;
using UnityEditor;
using UnityEngine;

namespace Assets.ExtendedUnityEditor.Editor
{
    [CustomPropertyDrawer(typeof(TagAttribute))]
    public class TagDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var tagAttribute = (TagAttribute)base.attribute;

            var value = EditorGUI.TagField(position, property.displayName, property.stringValue);
            property.stringValue = value;
        }
    }
}
