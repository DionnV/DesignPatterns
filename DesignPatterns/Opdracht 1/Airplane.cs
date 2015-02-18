using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Opdracht_1.CustomException;

namespace DesignPatterns.Opdracht_1
{
    public class Airplane
    {
        public Flap[] Flaps { get; set; }
        public Engine[] Engines { get; set; }
        public Pilot[] Pilots { get; set; }

        public Airplane()
        {
            Flaps = new Flap[2] { new Flap(), new Flap() };
            Engines = new Engine[4] { new Engine(), new Engine(), new Engine(), new Engine() };
            Pilots = new Pilot[3] { new Pilot(), new Pilot(), new Pilot() };        
        }

        public void Flight()
        {   
            for(int i = 0; i < Engines.Length; i++)
            {
                try { Engines[i].Calculate(); } catch (EngineException ee) { /*Process exception*/ }
            }
            foreach(Flap flap in Flaps)
            {
                try { flap.Calculate(); } catch (FlapException fe) { /*Process exception*/ }
            }
            foreach(Pilot pilot in Pilots)
            {
                try { pilot.Calculate(); } catch (PilotException pe) { /*Process exception*/ }
            }
        }
    }
}
