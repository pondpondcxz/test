using System;
using static TestFainal_01.SelectcCheracter;

namespace TestFainal_01
{
    public class Charecter
    {
        public int HealthPoint { get; private set; }
        public int ManaPoint { get; private set; }
        public int ArmorPoint { get; private set; }
        public int DamagePoint { get; private set; }
        public string TheWeapon { get; private set; }
        public bool IsDead { get; private set; }
        public int Inventery { get; private set; }
        
        protected string Item {
            get
            {
                return null;
            }
        }
        
        public Charecter(int healthPoint, int manaPoint, int armorPoint, int damagePoint, string theWeapon, bool isDead,
            int inventery)
        {
            HealthPoint = healthPoint;
            ManaPoint = manaPoint;
            ArmorPoint = armorPoint;
            DamagePoint = damagePoint;
            TheWeapon = theWeapon;
            IsDead = isDead;
            Inventery = inventery;
        }
        

        private void _ShowCelculatePoint()
        {
            HealthPoint = HealthPoint - DamagePoint + ArmorPoint ;
            
            Console.WriteLine($"You take damage : {DamagePoint}");
        }

        private void _ShowStatusCharacter()
        {
            if (HealthPoint <= 0)
            {
                IsDead = true;
                return;
            }
             
            Console.WriteLine($"You have a status hp ==> {HealthPoint} mp ==> {ManaPoint} armor ==> {ArmorPoint} damage ==> {DamagePoint} weapon ==> {TheWeapon} ");
        }

        public void ShowOverAllCheracter()
        {

            Console.WriteLine("");
            _ShowCelculatePoint();
            _ShowStatusCharacter();
            
            
        
        }

        public class Knight : Charecter
        {
            public Knight(int healthPoint, int manaPoint, int armorPoint, int damagePoint, string theWeapon, bool isDead,
                int inventery)
                : base(healthPoint, manaPoint, armorPoint, damagePoint, theWeapon, isDead, inventery)
            {

            }
            
            public void ShowOverAllArcher()
            {
            
            }

            
        }
        
        public class Mage : Charecter
        {
            public Mage(int healthPoint, int manaPoint, int armorPoint, int damagePoint, string theWeapon, bool isDead,
                int inventery) : base(healthPoint, manaPoint, armorPoint, damagePoint, theWeapon, isDead, inventery)
            {
                
            }
            
            public void ShowOverAllArcher()
            {
            
            }
            
        }
        
        public class Archer : Charecter
        {
            public Archer(int healthPoint, int manaPoint, int armorPoint, int damagePoint, string theWeapon, bool isDead,
                int inventery) : base(healthPoint, manaPoint, armorPoint, damagePoint, theWeapon, isDead, inventery)
            {
                
            }
            
        }
        public void ShowOverAllArcher()
        {
            
        }
    }

}
