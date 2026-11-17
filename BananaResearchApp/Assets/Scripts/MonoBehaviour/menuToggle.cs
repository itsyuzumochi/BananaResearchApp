using UnityEngine;
using UnityEngine.UI;

public class menuToggle : MonoBehaviour
{
    [SerializeField] private Button menuButton;
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject screen;
    [SerializeField] private Button right, top, bottom;

    private bool justOpen;
    
    void Start()
    {
        menuButton.onClick.AddListener(openMenu);
        menuButton.onClick.AddListener(closeMenu);
        
        right.onClick.AddListener(closeMenu);
        top.onClick.AddListener(closeMenu);
        bottom.onClick.AddListener(closeMenu);

        menuPanel.SetActive(false);
        screen.SetActive(false);
    }

    void openMenu()
    {
        if (!menuPanel.activeSelf)
        {
            menuPanel.SetActive(true);
            screen.SetActive(true);

            justOpen = true;
        }
    }

    void closeMenu()
    {
        if (menuPanel.activeSelf && !justOpen)
        {
            menuPanel.SetActive(false);
            screen.SetActive(false);
        }

        justOpen = false;
    }
}
