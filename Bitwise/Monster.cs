using System;
using c = CompositionVsInheritance.Composition_Monster;

namespace CompositionVsInheritance.Bitwise
{
    public class Monster
    {
        public Monster(c.MonsterType type, AttackType attacks, int damage)
        {
            Attacks = attacks;
            Damage = damage;
            Type = type;
        }

        [Flags]
        public enum AttackType
        {
            Biting = 0x01, // 0000 0001
            Kicking = 0x02, // 0000 0010
            Punching = 0x04 // 0000 0100
        }

        public int Damage { get; }
        public c.MonsterType Type { get; }
        public AttackType Attacks { get; private set; }
        public void SetAttack(AttackType attack)
        {
            Attacks |= attack;
        }

        public void RemoveAttack(AttackType attack)
        {
            Attacks &= ~attack;
        }

        public bool CanBite
        {
            get
            {
                //(Attacks & (byte)AttackType.Biting) == (byte)AttackType.Biting
                return Attacks.HasFlag(AttackType.Biting);
            }
        }

        public bool CanKick
        {
            get
            {
                return Attacks.HasFlag(AttackType.Kicking);
            }
        }

        public bool CanPunch
        {
            get
            {
                return Attacks.HasFlag(AttackType.Punching);
            }
        }
    }
}