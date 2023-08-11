using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class vsAI : MonoBehaviour
{
    Boolean checker;
    int plusone;
    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;

    public Text btnReset = null;
    public Text btnNewGame = null;

    public Text msgfeedback = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    private enum GameState
    {
        Playing,      
        PlayerXWins, 
        PlayerOWins,  
        Draw          
    }

    private GameState currentState;

    private void Start()
    {
        currentState = GameState.Playing;
    }

    public void score()
    {
        if (CheckWin("X"))
        {
            HandleEndGame(GameState.PlayerXWins);
        }
        else if (CheckWin("O"))
        {
            HandleEndGame(GameState.PlayerOWins);
        }
        else if (CheckDraw())
        {
            HandleEndGame(GameState.Draw);
        }
    }

    private bool CheckWin(string player)
    {
        if ((btnText1.text == player && btnText2.text == player && btnText3.text == player) ||
            (btnText4.text == player && btnText5.text == player && btnText6.text == player) ||
            (btnText7.text == player && btnText8.text == player && btnText9.text == player))
        {
            return true;
        }

        if ((btnText1.text == player && btnText4.text == player && btnText7.text == player) ||
            (btnText2.text == player && btnText5.text == player && btnText8.text == player) ||
            (btnText3.text == player && btnText6.text == player && btnText9.text == player))
        {
            return true;
        }

        if ((btnText1.text == player && btnText5.text == player && btnText9.text == player) ||
            (btnText3.text == player && btnText5.text == player && btnText7.text == player))
        {
            return true;
        }

        return false;
    }

    private bool CheckDraw()
    {
        return (!string.IsNullOrEmpty(btnText1.text) &&
                !string.IsNullOrEmpty(btnText2.text) &&
                !string.IsNullOrEmpty(btnText3.text) &&
                !string.IsNullOrEmpty(btnText4.text) &&
                !string.IsNullOrEmpty(btnText5.text) &&
                !string.IsNullOrEmpty(btnText6.text) &&
                !string.IsNullOrEmpty(btnText7.text) &&
                !string.IsNullOrEmpty(btnText8.text) &&
                !string.IsNullOrEmpty(btnText9.text));
    }

    

    public void btnText1_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText1.text))
        {
            if (checker == false)
            {
                btnText1.text = "X";
                
            }
        
            score();
            CheckDraw();
            AITurn();
        }
    }
}
public void btnText2_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText2.text))
        {
            if (checker == false)
            {
                btnText2.text = "X";
                
            }
            
            score();
            CheckDraw();
            AITurn();
        }
    }
}
public void btnText3_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText3.text))
        {
            if (checker == false)
            {
                btnText3.text = "X";
                
            }
            
            score();
            CheckDraw();
            AITurn();
        }
    }
}
public void btnText4_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText4.text))
        {
            if (checker == false)
            {
                btnText4.text = "X";
                
            }
            
            score();
            CheckDraw();
            AITurn();
        }
    }
}
public void btnText5_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText5.text))
        {
            if (checker == false)
            {
                btnText5.text = "X";
                
            }
            
            score();
            CheckDraw();
            AITurn();
        }
    }
}
public void btnText6_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText6.text))
        {
            if (checker == false)
            {
                btnText6.text = "X";
                
            }
            
            score();
            CheckDraw();
            AITurn();
        }
    }
}
public void btnText7_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText7.text))
        {
            if (checker == false)
            {
                btnText7.text = "X";
                
            }
            
            score();
            CheckDraw();
            AITurn();
        }
    }
}
public void btnText8_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText8.text))
        {
            if (checker == false)
            {
                btnText8.text = "X";
                
            }
            
            score();
            CheckDraw();
            AITurn();
        }
    }
}
public void btnText9_click()
{
    if (currentState == GameState.Playing)
    {
        if (string.IsNullOrEmpty(btnText9.text))
        {
            if (checker == false)
            {
                btnText9.text = "X";
                
            }
            
            score();
            CheckDraw();
            AITurn();
        }
    }
}

private int MiniMax(bool isMaximizing)
{
    if (CheckWin("X")) return -1;
    if (CheckWin("O")) return 1;
    if (CheckDraw()) return 0;

    int bestScore;

    if (isMaximizing)
    {
        bestScore = int.MinValue;
        List<Text> emptyCells = GetEmptyCells();

        foreach (Text cell in emptyCells)
        {
            cell.text = "O";
            bestScore = Math.Max(bestScore, MiniMax(false));
            cell.text = "";
        }
    }
    else
    {
        bestScore = int.MaxValue;
        List<Text> emptyCells = GetEmptyCells();

        foreach (Text cell in emptyCells)
        {
            cell.text = "X";
            bestScore = Math.Min(bestScore, MiniMax(true));
            cell.text = "";
        }
    }

    return bestScore;
}

private List<Text> GetEmptyCells()
{
    List<Text> emptyCells = new List<Text>();

    if (string.IsNullOrEmpty(btnText1.text)) emptyCells.Add(btnText1);
    if (string.IsNullOrEmpty(btnText2.text)) emptyCells.Add(btnText2);
    if (string.IsNullOrEmpty(btnText3.text)) emptyCells.Add(btnText3);
    if (string.IsNullOrEmpty(btnText4.text)) emptyCells.Add(btnText4);
    if (string.IsNullOrEmpty(btnText5.text)) emptyCells.Add(btnText5);
    if (string.IsNullOrEmpty(btnText6.text)) emptyCells.Add(btnText6);
    if (string.IsNullOrEmpty(btnText7.text)) emptyCells.Add(btnText7);
    if (string.IsNullOrEmpty(btnText8.text)) emptyCells.Add(btnText8);
    if (string.IsNullOrEmpty(btnText9.text)) emptyCells.Add(btnText9);

    return emptyCells;
}

private void AITurn()
{
    if (currentState == GameState.Playing)
    {
        List<Text> emptyCells = GetEmptyCells();
        int bestScore = int.MinValue;
        int bestMove = -1;

        foreach (Text cell in emptyCells)
        {
            cell.text = "O";
            int score = MiniMax(false);
            cell.text = "";

            if (score > bestScore)
            {
                bestScore = score;
                bestMove = emptyCells.IndexOf(cell);
            }
        }

        if (bestMove != -1)
        {
            emptyCells[bestMove].text = "O";
            score();
            CheckDraw();
        }
    }
}

private void EnableButtons()
    {
        btnText1.GetComponent<Button>().interactable = true;
        btnText2.GetComponent<Button>().interactable = true;
        btnText3.GetComponent<Button>().interactable = true;
        btnText4.GetComponent<Button>().interactable = true;
        btnText5.GetComponent<Button>().interactable = true;
        btnText6.GetComponent<Button>().interactable = true;
        btnText7.GetComponent<Button>().interactable = true;
        btnText8.GetComponent<Button>().interactable = true;
        btnText9.GetComponent<Button>().interactable = true;
    }


    private void HandleEndGame(GameState state)
{
    if (state == GameState.PlayerXWins)
    {
        msgfeedback.text = "The winner is Player X.";
        UpdatePlayerScore("X");
    }
    else if (state == GameState.PlayerOWins)
    {
        msgfeedback.text = "The winner is Player O.";
        UpdatePlayerScore("O");
    }
    else if (state == GameState.Draw)
    {
        msgfeedback.text = "It's a draw!";
    }

    currentState = GameState.Playing;

    EnableButtons();
}


    private void DisableButtons()
    {
        btnText1.GetComponent<Button>().interactable = false;
        btnText2.GetComponent<Button>().interactable = false;
        btnText3.GetComponent<Button>().interactable = false;
        btnText4.GetComponent<Button>().interactable = false;
        btnText5.GetComponent<Button>().interactable = false;
        btnText6.GetComponent<Button>().interactable = false;
        btnText7.GetComponent<Button>().interactable = false;
        btnText8.GetComponent<Button>().interactable = false;
        btnText9.GetComponent<Button>().interactable = false;
    }


    private void UpdatePlayerScore(string player)
    {
        if (player == "X")
        {
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        else if (player == "O")
        {
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
    }

    


    public void btnNewGame_click()
    {
        btnReset_click();
        txtPlayerX.text = "0";
        txtPlayerO.text = "0";
    }

    public void btnReset_click()
    {
        currentState = GameState.Playing;
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";

        msgfeedback.text = "";

        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;

        EnableButtons();

        checker = false;

        AITurn();
    }


}
