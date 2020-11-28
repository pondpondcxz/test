# test
using sistem;


public class Charecter
    {
        public int HealthPoint { get; private set; }
        public int ManaPoint { get; private set; }
        public int ArmorPoint { get; private set; }
        public int DamagePoint { get; private set; }
        protected string Item { get; private set; }
        public bool IsDead { get; private set; }
        public int Inventery { get; private set; }

        public Charecter(int healthPoint, int manaPoint, int armorPoint, int damagePoint, string item, bool isDead,
            int inventery)
        {
            HealthPoint = healthPoint;
            ManaPoint = manaPoint;
            ArmorPoint = armorPoint;
            DamagePoint = damagePoint;
            Item = item;
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
             
            Console.WriteLine($"You have a status hp ==> {HealthPoint} mp ==> {ManaPoint} armor ==> {ArmorPoint} damage ==> {DamagePoint}");
        }

        public void ShowOverAllCheracter()
        {
        _ShowCelculatePoint();
        _ShowStatusCharacter();
        
        }

        public class Knight : Charecter
        {
            public Knight(int healthPoint, int manaPoint, int armorPoint, int damagePoint, string item, bool isDead,
                int inventery)
                : base(healthPoint, manaPoint, armorPoint, damagePoint, item, isDead, inventery)
            {

            }
        }

    }
