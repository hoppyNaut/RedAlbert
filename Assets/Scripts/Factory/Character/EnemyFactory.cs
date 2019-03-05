﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class EnemyFactory : ICharacterFactory
{
 

    public ICharacter CreateCharacter<T>(WeaponType weaponType, Vector3 spawnPosition, int level = 1)where T:ICharacter, new()
    {
        ICharacter character = new T();

        ICharacterBuilder builder = new EnemyBuilder(character, typeof(T), weaponType, spawnPosition, level);
        character = CharacterBuildDirector.Construct(builder);

        return character;
    }
}

