﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodobadgesTests
{
    [TestClass]
    public class Tests
    {
        private Repository _repo;
        private Badges _badges;

        [TestInitialize]
        public void Initialize()
        {
            List<string> list = new List<string>();
            list.Add("door_1");

            _repo = new Repository();
            _badges = new Badges(700, list);
        }
    }
}