﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class GameEventManager
    {
        public delegate void GameEvent();

        public static event GameEvent OnGameStart, OnGameOver;

        public static void TriggerGameStart()
        {
            if(OnGameStart != null)
            {
                Console.WriteLine("the game has started...");
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("the game is over...");
                OnGameOver();
            }
        }
    }
}
