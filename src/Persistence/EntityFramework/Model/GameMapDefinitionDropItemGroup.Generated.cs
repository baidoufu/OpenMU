// <copyright file="GameMapDefinitionDropItemGroup.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

        //------------------------------------------------------------------------------
        // <auto-generated>
        //     This source code was auto-generated by a roslyn code generator.
        // </auto-generated>
        //------------------------------------------------------------------------------

        // ReSharper disable All

namespace MUnique.OpenMU.Persistence.EntityFramework.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using MUnique.OpenMU.Persistence;

    [Table(nameof(GameMapDefinitionDropItemGroup), Schema = "config")]
    internal partial class GameMapDefinitionDropItemGroup
    {
        public Guid GameMapDefinitionId { get; set; }
        public GameMapDefinition GameMapDefinition { get; set; }

        public Guid DropItemGroupId { get; set; }
        public DropItemGroup DropItemGroup { get; set; }
    }

    internal partial class GameMapDefinition
    {
        public ICollection<GameMapDefinitionDropItemGroup> JoinedDropItemGroups { get; } = new List<GameMapDefinitionDropItemGroup>();
    }
}