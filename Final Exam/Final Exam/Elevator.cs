
namespace Final_Exam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        double TotalWeight = 0;

        public double GetCurrentWeight()
        {
            for (int i = 0; i < Occupants.Length; i++)
            {
                TotalWeight += Occupants[i].GetWeight();

            }
            return TotalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }
        
        

    }
}
