using System;
using c = CompositionVsInheritance.Composition_Monster;

namespace CompositionVsInheritance.Bitwise
{
    public static class MonsterFactory
    {
        public static Monster NewMonster(c.MonsterType monsterType)
        {
            Monster monster;

            switch (monsterType)
            {
                case c.MonsterType.Horse:
                    monster = new Monster(monsterType, Monster.AttackType.Biting | Monster.AttackType.Kicking, 16);
                    break;
                case c.MonsterType.Orc:
                    monster = new Monster(monsterType, Monster.AttackType.Biting | Monster.AttackType.Kicking | Monster.AttackType.Punching, 14);
                    break;
                case c.MonsterType.Crocodile:
                    monster = new Monster(monsterType, Monster.AttackType.Biting, 11);
                    break;
                case c.MonsterType.MikeTyson:
                    monster = new Monster(monsterType, Monster.AttackType.Biting | Monster.AttackType.Punching, 20);
                    break;
                case c.MonsterType.Camel:
                    monster = new Monster(monsterType, Monster.AttackType.Kicking, 13);
                    break;
                case c.MonsterType.Kangaroo:
                    monster = new Monster(monsterType, Monster.AttackType.Kicking | Monster.AttackType.Punching, 15);
                    break;
                case c.MonsterType.MantisShrimp:
                    monster = new Monster(monsterType, Monster.AttackType.Punching, 16);
                    break;
                default:
                    throw new ArgumentException();
            }

            return monster;
        }
    }
}