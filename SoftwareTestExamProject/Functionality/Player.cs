﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareTestExamProject.Functionality
{
    public class Player : Character
    {
        private bool isDefending = false;

        public int[] coordinates = { 1, 1 };

        public bool IsDefending { get => isDefending; set => isDefending = value; }

        public Player(string name, float health, float damage)
        {
            this.Name = name;
            this.MaxHp = health;
            this.Damage = damage;
            this.CurrentHp = health;
        }

        public override float Attack()
        {
            return Damage;
        }

        public override void Heal()
        {
            if (CurrentHp < MaxHp)
            {
                if (CurrentHp < MaxHp * 0.8f)
                {
                    CurrentHp += MaxHp * 0.2f;
                }
                else
                {
                    CurrentHp = MaxHp;
                }
            }
        }

        public override void Defend()
        {
            IsDefending = true;
        }
    }

}