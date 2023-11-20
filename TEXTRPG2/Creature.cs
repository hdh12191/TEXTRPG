using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG2
{
    public enum CreatureType
    {
        None = 0,
        Player = 1,
        Monster = 2
    }
    class Creature
    {
        CreatureType _type = CreatureType.None;

        protected int _hp = 0;
        protected int _attack = 0;

        protected Creature(CreatureType type)
        {
            _type = type;
        }
        public void SetInfo(int hp, int attack)
        {
            _hp = hp;
            _attack = attack;
        }

        public int GetHp() { return _hp; }
        public int GetAttack() { return _attack; }

        public bool IsDead() { return _hp <= 0; }

        public void OnDamaged(int damage)
        {
            _hp -= damage;
            if (_hp < 0)
                _hp = 0;
        }
    }
}
