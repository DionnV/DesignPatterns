using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

namespace DesignPatterns.Opdracht_2_3_4
{
    public class MotorBase
    {
        private BackgroundWorker worker;

        public virtual float CalculateFuelUsageForCurrentTick()
        {
            //Simuleer standaard brandstofverbruik
            return (float)CurrentRotationsPerMinute / 10000;
        }

        public virtual float CalculateRPMForCurrentTick()
        {
            Random rng = new Random();
            //Simuleer fluctuatie
            if (!IsAccelerating)
                return (rng.NextDouble() < 0.5 ? -1 : 1) * 10 + (StationaryRotationsPerMinute - CurrentRotationsPerMinute)/2;
            //Simuleer versnelling
            else
                return CurrentRotationsPerMinute * .4f;
        }

        public float TotalFuelUsage { get; set; }
        public float CurrentRotationsPerMinute { get; set; }
        public bool IsAccelerating { get; set; }

        public virtual float StationaryRotationsPerMinute { get { return 1000; } }

        public MotorBase()
        {
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(Run);
        }

        public void Start()
        {
            CurrentRotationsPerMinute = StationaryRotationsPerMinute;
            worker.RunWorkerAsync();
        }

        public void Stop()
        {
            worker.CancelAsync();
        }

        public void Run(object sender, DoWorkEventArgs e)
        {
            while(!worker.CancellationPending)
            {
                TotalFuelUsage += CalculateFuelUsageForCurrentTick();
                CurrentRotationsPerMinute += CalculateRPMForCurrentTick();
                Thread.Sleep(500);
            }
        }
    }
}
