using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header(" ~~~~~~~~~~~~~~ Panel ~~~~~~~~~~~~~~ ")]
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject gamePanel;
    [SerializeField] GameObject settingsPanel;

    [Header(" ~~~~~~~~~~~~~~ Anim ~~~~~~~~~~~~~~ ")]
    [SerializeField] Animator timeUpAnim;
    [SerializeField] Image timeUp;

    [Header(" ~~~~~~~~~~~~~~ TapTheColor ~~~~~~~~~~~~~~ ")]
    [SerializeField] GameObject tapTheColorMemorizedButton;
    [SerializeField] GameObject tapTheColorEndGame;
    [SerializeField] GameObject tapTheColorHowToPlayPanel;
    [SerializeField] Text TTHEndPanelscoreText;
    [SerializeField] Slider TTHEndPanelSlider1;
    [SerializeField] Slider TTHEndPanelSlider2;
    [SerializeField] Text TTHEndPanelSliderValue1;
    [SerializeField] Text TTHEndPanelSliderValue2;
    

    [Header(" ~~~~~~~~~~~~~~ Spinning Block ~~~~~~~~~~~~~~ ")]
    [SerializeField] GameObject spinnigBlockMemorizedButton;
    [SerializeField] GameObject spinnigBlockEndGame;
    [SerializeField] GameObject spinnigBlockHowToPlayPanel;
    [SerializeField] Text SPEndPanelscoreText;
    [SerializeField] Slider SPEndPanelSlider1;
    [SerializeField] Slider SPEndPanelSlider2;
    [SerializeField] Text SPEndPanelSliderValue1;
    [SerializeField] Text SPEndPanelSliderValue2;

    [Header(" ~~~~~~~~~~~~~~ Follow The Leader ~~~~~~~~~~~~~~ ")]
    [SerializeField] GameObject followTheLeaderMemorizedButton;
    [SerializeField] GameObject followTheLeaderEndGame;
    [SerializeField] GameObject followTheLeaderHowToPlayPanel;
    [SerializeField] Text FTLEndPanelscoreText;
    [SerializeField] Slider FTLEndPanelSlider1;
    [SerializeField] Slider FTLEndPanelSlider2;
    [SerializeField] Text FTLEndPanelSliderValue1;
    [SerializeField] Text FTLEndPanelSliderValue2;

    [Header(" ~~~~~~~~~~~~~~ Simpli City ~~~~~~~~~~~~~~ ")]
    [SerializeField] GameObject simpliCityEndGame;
    [SerializeField] GameObject simpliCityHowToPlayPanel;
    [SerializeField] Text SCEndPanelscoreText;
    [SerializeField] Slider SCEndPanelSlider1;
    [SerializeField] Slider SCEndPanelSlider2;
    [SerializeField] Text SCEndPanelSliderValue1;
    [SerializeField] Text SCEndPanelSliderValue2;
    [Header("----------------------------------------------")]
    [SerializeField] TextMeshProUGUI SCCalculationText;

    [Header(" ~~~~~~~~~~~~~~ Concentration ~~~~~~~~~~~~~~ ")]
    [SerializeField] GameObject concentrationMemorizedButton;
    [SerializeField] GameObject concentrationEndGame;
    [SerializeField] GameObject concentrationHowToPlayPanel;
    [SerializeField] Text CEndPanelscoreText;
    [SerializeField] Slider CEndPanelSlider1;
    [SerializeField] Slider CEndPanelSlider2;
    [SerializeField] Text CEndPanelSliderValue1;
    [SerializeField] Text CEndPanelSliderValue2;

    [Header(" ~~~~~~~~~~~~~~ Game Panel ~~~~~~~~~~~~~~ ")]
    [SerializeField] GameObject tapTheColorPanel;
    [SerializeField] GameObject spinnigBlockPanel;
    [SerializeField] GameObject followThePanelPanel;
    [SerializeField] GameObject simpliCityPanel;
    [SerializeField] GameObject ConcentrationPanel;

    private void OnEnable()
    {
        EventManager.GameMemorizedButton += SetMemorizedButton;
        EventManager.GameUIRoot += SetPanel;
        EventManager.GameSelectGame += SetSelectGame;
        EventManager.GameStartButton += StartButton;
        EventManager.GameHomeButton += HomeButton;
        EventManager.GameEndGame += SetEndGamePanel;
        EventManager.GameEndGameValue += EndGamePanelValue;
        EventManager.GameSimpliCityCalculationText += SimpliCityCalculationText;
        EventManager.GameTimeUp += TimeUpImageControl;
    }

    private void OnDisable()
    {
        EventManager.GameMemorizedButton -= SetMemorizedButton;
        EventManager.GameUIRoot -= SetPanel;
        EventManager.GameSelectGame -= SetSelectGame;
        EventManager.GameStartButton -= StartButton;
        EventManager.GameHomeButton -= HomeButton;
        EventManager.GameEndGame -= SetEndGamePanel;
        EventManager.GameEndGameValue -= EndGamePanelValue;
        EventManager.GameSimpliCityCalculationText -= SimpliCityCalculationText;
        EventManager.GameTimeUp -= TimeUpImageControl;
    }

    public void SetPanel(UIRoot value, bool val)
    {
        if (value == UIRoot.MainPanel)
        {
            MainPanel(val);
        }
        if (value == UIRoot.GamePanel)
        {
            GamePanel(val);
        }
    }

    public void StartButton() // main Menudeki Start Butonu
    {
        EndGamePanelClosed(false);
        MainMenuPanel(false);
        MainPanel(true);
        SCCalculationText.gameObject.SetActive(false);
        ClosedHowToPlayPanel();
        timeUpAnim.enabled = false;
    }

    public void HomeButton() // Tap Bannerdaki Home Butonu
    {
        MainMenuPanel(true);
        MainPanel(false);
        SetExitGamePanel();
        ClosedHowToPlayPanel();
        SettingsPanel(false);
    }

    public void SettingsPanel(bool value)
    {
        settingsPanel.SetActive(value);
    }

    public void TimeUpImageControl()
    {
        timeUpAnim.enabled = true;
       // timeUp.DOFade(100, 1f).OnComplete(() => timeUp.DOFade(1,1f)).SetLoops(5,LoopType.Incremental).SetEase(Ease.Linear);
    }

    void MainMenuPanel(bool value)
    {
        mainMenu.SetActive(value);
    }

    void MainPanel(bool value)
    {
        mainPanel.SetActive(value);
    }

    void GamePanel(bool value)
    {
        gamePanel.SetActive(value);

    }
    void ClosedHowToPlayPanel()
    {
        followTheLeaderHowToPlayPanel.SetActive(false);
        tapTheColorHowToPlayPanel.SetActive(false);
        spinnigBlockHowToPlayPanel.SetActive(false);
        simpliCityHowToPlayPanel.SetActive(false);
        concentrationHowToPlayPanel.SetActive(false);
    }

    public void OpenFollowTheLeaderHTPPanel()
    {
        followTheLeaderHowToPlayPanel.SetActive(true);
    }

    public void OpenTapToColorHTPPanel()
    {
        tapTheColorHowToPlayPanel.SetActive(true);
    }

    public void OpenSpinnigBlockHTPPanel()
    {
        spinnigBlockHowToPlayPanel.SetActive(true);
    }

    public void OpenSimliCityHTPPanel()
    {
        simpliCityHowToPlayPanel.SetActive(true);
    }

    public void OpenConcentrationHTPPanel()
    {
        concentrationHowToPlayPanel.SetActive(true);
    }

    public void SetMemorizedButton(MemorizedRoot value,bool val) // Oyunlar?n memorized butonlar?n?n setactive durumlar?n? d?zenliyor
    {
        if (value == MemorizedRoot.MemorizedTapTheColor)
        {
            MemorizedTapTheColor(val);
        }
        if (value == MemorizedRoot.MemorizedSpinningBlcok)
        {
            MemorizedSpinnigBlock(val);
        }
        if (value == MemorizedRoot.MemorizedFollowTheLeader)
        {
            MemorizedFollowTheLeader(val);
        }
        if (value == MemorizedRoot.MemorizedConcentration)
        {
            MemorizedConcentration(val);
        }
    }

    void MemorizedTapTheColor(bool val)
    {
        tapTheColorMemorizedButton.SetActive(val);
    }

    void MemorizedSpinnigBlock(bool val)
    {
        spinnigBlockMemorizedButton.SetActive(val);
    }

    void MemorizedFollowTheLeader(bool val)
    {
        followTheLeaderMemorizedButton.SetActive(val);
    }

    void MemorizedConcentration(bool val)
    {
        concentrationMemorizedButton.SetActive(val);
    }

    public void SetSelectGame(GameRoot value , bool val) // oyun panallerini ac?yor
    {
        if (value == GameRoot.TapTheColor)
        {
            SelectTapTheColor(val);
        }
        else if (value == GameRoot.SpinningBlcok)
        {
            SelectSpinningBlock(val);
        }
        else if (value == GameRoot.FollowTheLeader)
        {
            SelectFollowTheLeader(val);
        }
        else if (value == GameRoot.SimpliCity)
        {
            SelectSimpliCity(val);
            SCCalculationText.gameObject.SetActive(true);
        }
        else if (value == GameRoot.Concentration)
        {
            SelectConcentration(val);
        }
    }

    public void SetExitGamePanel() // Oyunlar?n panelini kapat?yor daha sonradan eventlere ba?lanabilir
    {
        SelectTapTheColor(false);
        SelectSpinningBlock(false);
        SelectFollowTheLeader(false);
        SelectSimpliCity(false);
        SelectConcentration(false);
    }

    void SelectTapTheColor(bool val)
    {
        tapTheColorPanel.SetActive(val);
        MemorizedTapTheColor(true);
    }

    void SelectSpinningBlock(bool val)
    {
        spinnigBlockPanel.SetActive(val);
        MemorizedSpinnigBlock(true);
    }

    void SelectFollowTheLeader(bool val)
    {
        followThePanelPanel.SetActive(val);
    }
    void SelectSimpliCity(bool val)
    {
        simpliCityPanel.SetActive(val);
    }
    void SelectConcentration(bool val)
    {
        ConcentrationPanel.SetActive(val);
        MemorizedConcentration(true);
    }


    public void SetEndGamePanel(EndGameRoot value ,bool val) // Oyunlar?n sonundaki panelleri d?zenliyor
    {
        if (value == EndGameRoot.EndGameTapTheColor)
        {
            EndGameTapTheColor(val);
        }
        else if (value == EndGameRoot.EndGameRootSpinningBlcok)
        {
            EndGameSpinningBlock(val);
        }
        else if (value == EndGameRoot.EndGameRootFollowTheLeader)
        {
            EndGameFollowTheLeader(val);
        }
        else if (value == EndGameRoot.EndGameRootSimpliCity)
        {
            EndGameSimpliCity(val);
        }

        else if (value == EndGameRoot.EndGameRootConcentration)
        {
            EndGameConcentration(val);
        }

    }
    void EndGamePanelClosed(bool value)
    {
        EndGameTapTheColor(value);
        EndGameSpinningBlock(value);
        EndGameFollowTheLeader(value);
        EndGameSimpliCity(value);
        EndGameConcentration(value);
    }

    void EndGameTapTheColor(bool val)
    {
        tapTheColorEndGame.SetActive(val);
      
    }
    void EndGameSpinningBlock(bool val)
    {
        spinnigBlockEndGame.SetActive(val);
    }

    void EndGameFollowTheLeader(bool val)
    {
        followTheLeaderEndGame.SetActive(val);
    }

    void EndGameSimpliCity(bool val)
    {
        simpliCityEndGame.SetActive(val);
    }

    void EndGameConcentration(bool val)
    {
        concentrationEndGame.SetActive(val);
    }

    public void EndGamePanelValue(EndGameValue endGameValue,float scoreValue, float sliderValue1, float sliderValue2)
    {
        if (endGameValue == EndGameValue.EndGameValueTapTheColor)
        {
            EndGameValueTapTheColor(scoreValue, sliderValue1, sliderValue2);
        }
        else if (endGameValue == EndGameValue.EndGameValueSpinningBlcok)
        {
            EndGameValueSpinningBlock(scoreValue, sliderValue1, sliderValue2);
        }
        else if (endGameValue == EndGameValue.EndGameValueFollowTheLeader)
        {
            EndGameValueFollowTheLeader(scoreValue, sliderValue1, sliderValue2);
        }
        else if (endGameValue == EndGameValue.EndGameValueSimpliCity)
        {
            EndGameValueSimpliCity(scoreValue, sliderValue1, sliderValue2);
        }
        else if (endGameValue == EndGameValue.EndGameValueConcentration)
        {
            EndGameValueConcentration(scoreValue, sliderValue1, sliderValue2);
        }
    }

    void EndGameValueTapTheColor(float scoreValue, float sliderValue1, float sliderValue2)
    {
        TTHEndPanelscoreText.text = scoreValue + " / 100";
        TTHEndPanelSlider1.DOValue(sliderValue1,2f);
        TTHEndPanelSlider2.DOValue(sliderValue2,2f);
        TTHEndPanelSliderValue1.text = "%" + sliderValue1;
        TTHEndPanelSliderValue2.text = "%" + sliderValue2;
    }

    void EndGameValueSpinningBlock(float scoreValue, float sliderValue1, float sliderValue2)
    {
        SPEndPanelscoreText.text = scoreValue + " / 100";
        SPEndPanelSlider1.DOValue(sliderValue1,2f);
        SPEndPanelSlider2.DOValue(sliderValue2,2f);
        SPEndPanelSliderValue1.text = "%" + sliderValue1;
        SPEndPanelSliderValue2.text = "%" + sliderValue2;
    }

    void EndGameValueFollowTheLeader(float scoreValue, float sliderValue1, float sliderValue2)
    {
        FTLEndPanelscoreText.text = scoreValue + " / 100";
        FTLEndPanelSlider1.DOValue(sliderValue1,2f);
        FTLEndPanelSlider2.DOValue(sliderValue2,2f);
        FTLEndPanelSliderValue1.text = "%" + sliderValue1;
        FTLEndPanelSliderValue2.text = "%" + sliderValue1;
    }

    void EndGameValueSimpliCity(float scoreValue, float sliderValue1, float sliderValue2)
    {
        SCEndPanelscoreText.text = scoreValue + " / 100";
        SCEndPanelSlider1.DOValue(sliderValue1, 2f);
        SCEndPanelSlider2.DOValue(sliderValue2, 2f);
        SCEndPanelSliderValue1.text = "%" + sliderValue1;
        SCEndPanelSliderValue2.text = "%" + sliderValue1;
    }

    void EndGameValueConcentration(float scoreValue, float sliderValue1, float sliderValue2)
    {
        CEndPanelscoreText.text = scoreValue + " / 100";
        CEndPanelSlider1.DOValue(sliderValue1, 2f);
        CEndPanelSlider2.DOValue(sliderValue2, 2f);
        CEndPanelSliderValue1.text = "%" + sliderValue1;
        CEndPanelSliderValue2.text = "%" + sliderValue1;
    }


    // Simpli City

    public void SimpliCityCalculationText( string value)
    {
        SCCalculationText.text = value;
    }

}
