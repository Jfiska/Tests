using UnityEngine;
using UnityEngine.UI;

public class MyMenuHandler : MonoBehaviour
{
    [SerializeField] private Button _play;
    [SerializeField] private Button _optitions;
    [SerializeField] private Button _close;
    [SerializeField] private GameObject _playMenu;
    [SerializeField] private GameObject _optitionsMenu;
    [SerializeField] private GameObject _topPanel;
    [SerializeField] private GameObject _bottomPanel;

    
    private void OnEnable()
    {
        _play.onClick.AddListener(PlayButtonDisplay);
        _optitions.onClick.AddListener(OptitionsButtonDisplay);
        _close.onClick.AddListener(Close);
    }

    private void OnDisable()
    {
        _play.onClick.RemoveAllListeners();
        _optitions.onClick.RemoveAllListeners();
        _close.onClick.RemoveAllListeners();
    }

    private void PlayButtonDisplay()
    {
        _topPanel.SetActive(false);
        _bottomPanel.SetActive(false);
        _play.gameObject.SetActive(false);
        _optitions.gameObject.SetActive(false);
        _close.gameObject.SetActive(true);
        _playMenu.SetActive(true);
    }

    private void OptitionsButtonDisplay()
    {
        _topPanel.SetActive(false);
        _bottomPanel.SetActive(false);
        _play.gameObject.SetActive(false);
        _optitions.gameObject.SetActive(false);
        _close.gameObject.SetActive(true);
        _optitionsMenu.SetActive(true);
    }
    
    private void Close()
    {
        _close.gameObject.SetActive(false);
        _playMenu.SetActive(false);
        _optitionsMenu.SetActive(false);
        _play.gameObject.SetActive(true);
        _optitions.gameObject.SetActive(true);
        _topPanel.SetActive(true);
        _bottomPanel.SetActive(true);
    }
}
