using System;

namespace GameInheritanceDemo
{
    public class ArchMage : Mage
    {
        public int ancientKnowledge;

        public ArchMage()
        {
            Console.WriteLine("----> Konstruktor default ArchMage <----");
        }

        public ArchMage(int ancientKnowledge, int spellPower, string id, string name, int basePower, string address)
            : base(spellPower, id, name, basePower, address)
        {
            Console.WriteLine("----> Konstruktor berparameter ArchMage <----");
            this.ancientKnowledge = ancientKnowledge;
        }

        public override void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("ANCIENT KNOWLEDGE = " + ancientKnowledge);
            Console.WriteLine("GRAND TOTAL POWER = " + (GetBasePower() + spellPower + ancientKnowledge));
            Console.WriteLine("=======================");
        }
    }
}