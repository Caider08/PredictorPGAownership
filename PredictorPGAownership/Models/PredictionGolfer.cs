using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredictorPGAownership.Models
{
    public class PredictionGolfer
    {
        public int DKtourneyID { get; set; }

        public int PrevOwnedGolferID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public int Tags { get; set; }

        public int Start { get; set; }

        public int SalaryChange { get; set; }

        private double _prediction;

        public double Prediction
        {
            get
            {
                return _prediction;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    _prediction = 0;
                }
                else
                {
                    _prediction = value;
                }
            }
        }


        public DateTime DateTime { get; set; }

        public PredictionGolfer()
        {
            DateTime = DateTime.Today;
        }
    }
}
