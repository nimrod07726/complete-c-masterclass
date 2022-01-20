﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Car(float speed, string color) : base(speed, color)
        {
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }

        public List<IDestroyable> DestroyablesNearby;
    }
}
