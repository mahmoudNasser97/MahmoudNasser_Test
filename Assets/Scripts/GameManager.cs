using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text coinsText;
    public TMP_Text bankBalanceText;
    public GameObject shopkeeper1;
    public GameObject shopkeeper2;
    public GameObject atmPanel;
    public GameObject bedPanel;
    public GameObject sleepButton;
    public GameObject WakeUpButton;
    public List<ShoppingItem> item = new List<ShoppingItem>();
    public List<GameObject> playerInventory;

    private int coins = 1000;
    private int bankBalance = 3000;

    private void Start()
    {
        UpdateUI();
    }

    public void OpenShopkeeper1()
    {
        shopkeeper1.SetActive(true);
        shopkeeper2.SetActive(false);
    }
    public void OpenShopkeeper2()
    {
        shopkeeper2.SetActive(true);
        shopkeeper1.SetActive(false);
    }
    public void CloseAllPanels()
    {
        shopkeeper1.SetActive(false);
        shopkeeper2.SetActive(false);
        atmPanel.SetActive(false);
        bedPanel.SetActive(false);
    }
    public void PurchaseItem(int item)
    {
        if (coins >= item)
        {
            coins -= item;
            UpdateUI();
        }
    }
    public void SellItem(int itemCost)
    {
        coins += itemCost;
        UpdateUI();
    }
    public void OpenATMPanel()
    {
        atmPanel.SetActive(true);
    }
    public void OpenBEDPanel()
    {
        bedPanel.SetActive(true);
        sleepButton.GetComponent<Button>().interactable = true;
        WakeUpButton.GetComponent<Button>().interactable = false;
    }
    public void UpdateWithdrawBalance(int amount)
    {
        if (bankBalance >= amount)
        {
            bankBalance -= amount;
            coins += amount;
            UpdateUI();
        }
    }
    public void UpdateDepositBalance(int amount)
    {
        if (coins >= amount)
        {
            bankBalance += amount;
            coins -= amount;
            UpdateUI();
        }
    }
    public void Sleep()
    {
        sleepButton.GetComponent<Button>().interactable = false;
        WakeUpButton.GetComponent<Button>().interactable = true;
    }
    public void WakeUp()
    {
        float sleepBonus = 0.1f;
        bankBalance += Mathf.CeilToInt(bankBalance * sleepBonus);
        sleepButton.GetComponent<Button>().interactable = true;
        WakeUpButton.GetComponent<Button>().interactable = false;
        UpdateUI();
    }
    private void UpdateUI()
    {
        coinsText.text = coins.ToString();
        bankBalanceText.text = bankBalance.ToString();
    }
}
