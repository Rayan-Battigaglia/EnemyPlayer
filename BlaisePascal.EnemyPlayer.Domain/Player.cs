namespace BlaisePascal.EnemyPlayer.Domain
{
    public class Player
    {

        private int _level;
        private int _experience;
        private int _health;
        private int _maxHealth;
        private bool _isAlive;
        private int _gold;

        public string Name { get; set; }

        public int Level
        {
            get
            {
                return _level;
            }
            private set
            {
                if (value < 1)
                {
                    _level = 1;
                }
                else
                {
                    _level = value;
                }
            }
        }

        public int Experience
        {
            get
            {
                return _experience;
            }
            private set
            {
                if (value < 0)
                {
                    _experience = 0;
                }
                else if (value >= 100)
                {
                    _experience = value % 100;
                }
                else
                {
                    _experience = value;
                }
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            private set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
                }
                else
                {
                    _health = value;
                }

                IsAlive = _health > 0;
            }
        }

        public int MaxHealth
        {
            get
            {
                return _maxHealth;
            }
            private set
            {
                if (value < 1)
                {
                    _maxHealth = 1;
                }
                else
                {
                    _maxHealth = value;
                }
            }
        }

        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            private set
            {
                _isAlive = value;
            }
        }

        public int Gold
        {
            get
            {
                return _gold;
            }
            private set
            {
                if (value < 0)
                {
                    _gold = 0;
                }
                else
                {
                    _gold = value;
                }
            }
        }

        public Player(string name)
        {
            Name = name;
            Level = 1;
            Experience = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }

        public int AddExperience(int amount)
        {
            if (amount <= 0)
            {
                return Experience;
            }

            int totalExperience = Experience + amount;

            Level += totalExperience / 100;
            Experience = totalExperience % 100;

            return Experience;
        }

        public void ResetExperience()
        {
            Experience = 0;
        }


        public void TakeDamage(int amount)
        {
            if (amount <= 0 || !IsAlive)
            {
                return;
            }

            Health -= amount;
        }

        public void Heal(int amount)
        {
            if (amount <= 0 || !IsAlive)
            {
                return;
            }

            Health += amount;
        }

        public void AddGold(int amount)
        {
            if (amount <= 0)
            {
                return;
            }

            Gold += amount;
        }

        public void ResetHealth()
        {
            Health = MaxHealth;
        }
    }
}

