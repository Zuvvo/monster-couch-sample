using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiMenuSettingsManager : MonoBehaviour
{
    [SerializeField] private Button _backButton;

    private MainMenuController _menuController;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            _backButton.onClick.Invoke();
        }
    }

    public void Init(MainMenuController menuController)
    {
        _menuController = menuController;
        _backButton.onClick.AddListener(_menuController.CloseSettings);
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
