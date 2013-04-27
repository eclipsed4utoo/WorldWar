using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;

namespace WorldWar
{
    class Program
    {
        public static decimal totalCash = 1010697038;

        public static decimal supplyDepotInitialCost = 3502000;
        public const decimal supplyDepotIncrease = 2500;
        public const decimal supplyDepotAmountAddedPer = 1000;

        public static decimal refineryInitialCost = 39468000;
        public const decimal refineryIncrease = 22000;
        public const decimal refineryAmountAddedPer = 6500;

        public static decimal weaponsFactoryInitialCost = 107840000;
        public const decimal weaponsFactoryIncrease = 80000;
        public const decimal weaponsFactoryAmountAddedPer = 16500;

        public static decimal powerPlantInitialCost = 408800000;
        public const decimal powerPlantIncrease = 400000;
        public const decimal powerPlantAmountAddedPer = 56000;

        public static decimal oilRigInitialCost = 1953000000;
        public const decimal oilRigIncrease = 3000000;
        public const decimal oilRigAmountAddedPer = 270000;

        public static decimal researchLabInitialCost = 3960000000;
        public const decimal researchLabIncrease = 9000000;
        public const decimal researchLabAmountAddedPer = 500000;

        public static decimal nuclearFacilityInitialCost = 4680000000;
        public const decimal nuclearFacilityIncrease = 15000000;
        public const decimal nuclearFacilityAmountAddedPer = 700000;
        
        public static decimal satelliteNetworkInitialCost = 7950000000;
        public const decimal satelliteNetworkIncrease = 50000000;
        public const decimal satelliteNetworkAmountAddedPer = 1200000;

        public static decimal fusionReactorInitialCost = 10000000000;
        public const decimal fusionReactorIncrease = 120000000;
        public const decimal fusionReactorAmountAddedPer = 1400000;

        static void Main(string[] args)
        {
            CalculateSupplyDepot();
            CalculateRefinery();
            CalculateWeaponsFactory();
            CalculatePowerPlant();
            CalculateOilRig();
            CalculateResearchLab();
            CalculateNuclearFacility();
            CalculateSatelliteNetwork();
            CalculateFusionReactor();

            Console.Read();
        }

        private static void CalculateSupplyDepot()
        {
            decimal supplyDepotTotalCost = supplyDepotInitialCost;
            decimal supplyDepotTotalAdded = 0;

            for (int totalTimes = 1; supplyDepotTotalCost < totalCash; totalTimes++)
            {
                supplyDepotTotalCost += (supplyDepotInitialCost + (supplyDepotIncrease * totalTimes));
                supplyDepotTotalAdded += supplyDepotAmountAddedPer;
            }

            Console.WriteLine("Supply Depot will add \t\t{0:C}.", supplyDepotTotalAdded);
        }

        private static void CalculateRefinery()
        {
            decimal refineryTotalCost = refineryInitialCost;
            decimal refineryTotalAdded = 0;

            for (int totalTimes = 1; refineryTotalCost < totalCash; totalTimes++)
            {
                refineryTotalCost += (refineryInitialCost + (refineryIncrease * totalTimes));
                refineryTotalAdded += refineryAmountAddedPer;
            }

            Console.WriteLine("Refinery will add \t\t{0:C}.", refineryTotalAdded);
        }

        private static void CalculateWeaponsFactory()
        {
            decimal weaponsFactoryTotalCost = weaponsFactoryInitialCost;
            decimal weaponsFactoryTotalAdded = 0;

            for (int totalTimes = 1; weaponsFactoryTotalCost < totalCash; totalTimes++)
            {
                weaponsFactoryTotalCost += (weaponsFactoryInitialCost + (weaponsFactoryIncrease * totalTimes));
                weaponsFactoryTotalAdded += weaponsFactoryAmountAddedPer;
            }

            Console.WriteLine("Weapons Factory will add \t{0:C}.", weaponsFactoryTotalAdded);
        }

        private static void CalculatePowerPlant()
        {
            decimal powerPlantTotalCost = powerPlantInitialCost;
            decimal powerPlantTotalAdded = 0;

            for (int totalTimes = 1; powerPlantTotalCost < totalCash; totalTimes++)
            {
                powerPlantTotalCost += (powerPlantInitialCost + (powerPlantIncrease * totalTimes));
                powerPlantTotalAdded += powerPlantAmountAddedPer;
            }

            Console.WriteLine("Power Plant will add \t\t{0:C}.", powerPlantTotalAdded);
        }

        private static void CalculateOilRig()
        {
            decimal oilRigTotalCost = oilRigInitialCost;
            decimal oilRigTotalAdded = 0;

            for (int totalTimes = 1; oilRigTotalCost < totalCash; totalTimes++)
            {
                oilRigTotalCost += (oilRigInitialCost + (oilRigIncrease * totalTimes));
                oilRigTotalAdded += oilRigAmountAddedPer;
            }

            Console.WriteLine("Oil Rig will add \t\t{0:C}.", oilRigTotalAdded);
        }

        private static void CalculateResearchLab()
        {
            decimal researchLabTotalCost = researchLabInitialCost;
            decimal researchLabTotalAdded = 0;

            for (int totalTimes = 1; researchLabTotalCost < totalCash; totalTimes++)
            {
                researchLabTotalCost += (researchLabInitialCost + (researchLabIncrease * totalTimes));
                researchLabTotalAdded += researchLabAmountAddedPer;
            }

            Console.WriteLine("Research Lab will add \t\t{0:C}.", researchLabTotalAdded);
        }

        private static void CalculateNuclearFacility()
        {
            decimal nuclearFacilityTotalCost = nuclearFacilityInitialCost;
            decimal nuclearFacilityTotalAdded = 0;

            for (int totalTimes = 1; nuclearFacilityTotalCost < totalCash; totalTimes++)
            {
                nuclearFacilityTotalCost += (nuclearFacilityInitialCost + (nuclearFacilityIncrease * totalTimes));
                nuclearFacilityTotalAdded += nuclearFacilityAmountAddedPer;
            }

            Console.WriteLine("Nuclear Facility will add \t{0:C}.", nuclearFacilityTotalAdded);
        }

        private static void CalculateSatelliteNetwork()
        {
            decimal satelliteNetworkTotalCost = satelliteNetworkInitialCost;
            decimal satelliteNetworkTotalAdded = 0;
            
            for (int totalTimes = 1; satelliteNetworkTotalCost < totalCash; totalTimes++)
            {
                satelliteNetworkTotalCost += (satelliteNetworkInitialCost + (satelliteNetworkIncrease * totalTimes));
                satelliteNetworkTotalAdded += satelliteNetworkAmountAddedPer;
            }

            Console.WriteLine("Satellite Network will add \t{0:C}.", satelliteNetworkTotalAdded);
        }

        private static void CalculateFusionReactor()
        {
            decimal fusionReactorTotalCost = fusionReactorInitialCost;
            decimal fusionReactorTotalAdded = 0;

            for (int totalTimes = 1; fusionReactorTotalCost < totalCash; totalTimes++)
            {
                fusionReactorTotalCost += (fusionReactorInitialCost + (fusionReactorIncrease * totalTimes));
                fusionReactorTotalAdded += fusionReactorAmountAddedPer;
            }

            Console.WriteLine("Fusion Reactor will add \t{0:C}.", fusionReactorTotalAdded);
        }
    }
}
