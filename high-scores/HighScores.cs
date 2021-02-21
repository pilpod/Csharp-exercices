using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> scores = new List<int>();
    public int latestScore;
    public int highScore;
    public List<int> threePersonalBestScore;

    public HighScores(List<int> list)
    {
        this.scores = list;
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {   
        int elementNumb = this.scores.Count(); // Se puede utilizar el metodo Last() para obtener el último elemento directamente
        return this.scores[elementNumb - 1];
    }

    public int PersonalBest()
    {
        foreach(int score in this.scores)
        {
            if(score > this.highScore)
            {
                this.highScore = score;
            }
        }
        return this.highScore; // Se puede utilizar el metodo Max() para devolver el elemento mayor
    }

    public List<int> PersonalTopThree()
    {
        List<int> newList = new List<int>(this.scores);
        // Para ordenar de mayor a menor se puede utilizar el método OrderByDescending()
        // Opción utilizada por un usuario en exercism ... .OrderByDescending(x => x).Take(3).ToList();
        newList.Sort();
        newList.Reverse();
        if(newList.Count() > 3)
        {
            newList.RemoveRange(3, newList.Count() - 3);
        }

        this.threePersonalBestScore = newList;
        return this.threePersonalBestScore;
    }
}