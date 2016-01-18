﻿using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score { 
        get {
            return this.score;
        }
        private set {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Score can not be negavite or greater then 100!");
            }

            score = value;
        }
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
