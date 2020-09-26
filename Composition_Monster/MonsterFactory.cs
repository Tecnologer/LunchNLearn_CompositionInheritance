using System;

namespace CompositionVsInheritance.Composition_Monster
{
    public class MonsterFactory
    {
        public static Monster CreateMonster(MonsterType monsterType)
        {
            Monster monster;

            switch (monsterType)
            {
                case MonsterType.Horse:
                    monster = new Monster(monsterType, 16);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    monster.AddAttackType(Monster.AttackType.Kicking, 15);
                    break;
                case MonsterType.Orc:
                    monster = new Monster(monsterType, 14);
                    monster.AddAttackType(Monster.AttackType.Biting, 3);
                    monster.AddAttackType(Monster.AttackType.Kicking, 10);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                case MonsterType.Crocodile:
                    monster = new Monster(monsterType, 11);
                    monster.AddAttackType(Monster.AttackType.Biting, 15);
                    break;
                case MonsterType.MikeTyson:
                    monster = new Monster(monsterType, 20);
                    monster.AddAttackType(Monster.AttackType.Biting, 1);
                    monster.AddAttackType(Monster.AttackType.Punching, 15);
                    break;
                case MonsterType.Camel:
                    monster = new Monster(monsterType, 13);
                    monster.AddAttackType(Monster.AttackType.Kicking, 14);
                    break;
                case MonsterType.Kangaroo:
                    monster = new Monster(monsterType, 15);
                    monster.AddAttackType(Monster.AttackType.Kicking, 35);
                    monster.AddAttackType(Monster.AttackType.Punching, 15);
                    break;
                case MonsterType.MantisShrimp:
                    monster = new Monster(monsterType, 16);
                    monster.AddAttackType(Monster.AttackType.Punching, 8);
                    break;
                default:
                    throw new ArgumentException();
            }

            return monster;
        }
    }
}