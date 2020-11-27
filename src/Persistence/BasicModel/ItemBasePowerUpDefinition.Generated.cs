// <copyright file="ItemBasePowerUpDefinition.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

        //------------------------------------------------------------------------------
        // <auto-generated>
        //     This source code was auto-generated by a roslyn code generator.
        // </auto-generated>
        //------------------------------------------------------------------------------

        // ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel
{
    using System;
    using System.Collections.Generic;
    using MUnique.OpenMU.Persistence.Json;
    
    /// <summary>
    /// A plain implementation of <see cref="ItemBasePowerUpDefinition"/>.
    /// </summary>
    public partial class ItemBasePowerUpDefinition : MUnique.OpenMU.DataModel.Configuration.Items.ItemBasePowerUpDefinition, IIdentifiable, IConvertibleTo<ItemBasePowerUpDefinition>
    {
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="BonusPerLevel" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bonusPerLevel")]
        [System.Text.Json.Serialization.JsonPropertyName("bonusPerLevel")]
        public ICollection<LevelBonus> RawBonusPerLevel { get; } = new List<LevelBonus>();
        
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.Items.LevelBonus> BonusPerLevel
        {
            get => base.BonusPerLevel ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.LevelBonus, LevelBonus>(this.RawBonusPerLevel);
            protected set
            {
                this.BonusPerLevel.Clear();
                foreach (var item in value)
                {
                    this.BonusPerLevel.Add(item);
                }
            }
        }

        /// <summary>
        /// Gets the raw object of <see cref="TargetAttribute" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("targetAttribute")]
        [System.Text.Json.Serialization.JsonPropertyName("targetAttribute")]
        public AttributeDefinition RawTargetAttribute
        {
            get => base.TargetAttribute as AttributeDefinition;
            set => base.TargetAttribute = value;
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.AttributeSystem.AttributeDefinition TargetAttribute
        {
            get => base.TargetAttribute;
            set => base.TargetAttribute = value;
        }


        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            var baseObject = obj as IIdentifiable;
            if (baseObject != null)
            {
                return baseObject.Id == this.Id;
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        /// <inheritdoc/>
        public ItemBasePowerUpDefinition Convert() => this;
    }
}