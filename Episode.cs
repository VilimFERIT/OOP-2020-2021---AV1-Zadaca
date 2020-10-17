using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ZadacaAV1
{
    class Episode
    {
        public int viewers=10;
        public double scoresum;
        public double highestscore;
        private double currentscore;


        //constructors for inputting a new episode
        public Episode()
        { }

        public Episode(int viewersconstr, double scoresumconstr, double highestscoreconstr)
        {
            viewers = viewersconstr;
            scoresum = scoresumconstr;
            highestscore = highestscoreconstr;
        }

        //adding the current's viewer score to the sum of all scores
        public void AddView(double rand)
        {
            currentscore = rand;
            this.scoresum = rand + this.scoresum;
        }

        //method for generating a random number of the double type
        public double GenerateRandomScore()
        {
            Random r = new Random();
            int range = 10;
            double rDouble = r.NextDouble() * range;
            return rDouble;

        }

        //retrieving the average score of an episode based on the scores of the number of viewers
        public double GetAverageScore()
        {
            return this.scoresum / viewers;
        }

        public double GetMaxScore()
        {
            double currentmax;
            currentmax = currentscore;
            if(currentscore>currentmax)
            {
                currentmax = currentscore;
            }

            return currentmax;

        }

        public double GetViewerCount()
        {
            return viewers;
        }




    }
}

