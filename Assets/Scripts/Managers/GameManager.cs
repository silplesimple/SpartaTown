using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum CharacterType
{
    Penguin,
    Fox
}
[System.Serializable]
public class Character
{
    public CharacterType characterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Character> CharacterList = new List<Character>();
    public Animator PlayerAnimator;
    public Text PlayerName;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void SetCharacter(CharacterType characterType,string name)
    {
        var character = GameManager.Instance.CharacterList.Find(item => item.characterType == characterType);

        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        PlayerName.text = name;
    }
}
