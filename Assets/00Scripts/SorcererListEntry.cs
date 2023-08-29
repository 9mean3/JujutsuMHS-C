using UnityEditor.U2D.Animation;
using UnityEngine.UIElements;

public class SorcererListEntry
{
    Label m_NameLabel;

    public void SetVisualElement(VisualElement visualElement)
    {
        m_NameLabel = visualElement.Q<Label>("CharacterName");
    }

    public void SetCharacterData(SorcererDataSO characterData)
    {
        m_NameLabel.text = characterData.Name;
    }
}