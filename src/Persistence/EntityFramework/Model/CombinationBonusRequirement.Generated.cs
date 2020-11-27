// <copyright file="CombinationBonusRequirement.Generated.cs" company="MUnique">
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
    
    /// <summary>
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.Items.CombinationBonusRequirement"/>.
    /// </summary>
    [Table(nameof(CombinationBonusRequirement), Schema = "config")]
    internal partial class CombinationBonusRequirement : MUnique.OpenMU.DataModel.Configuration.Items.CombinationBonusRequirement, IIdentifiable
    {
        
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets or sets the identifier of <see cref="OptionType"/>.
        /// </summary>
        public Guid? OptionTypeId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="OptionType" />.
        /// </summary>
        [ForeignKey(nameof(OptionTypeId))]
        public ItemOptionType RawOptionType
        {
            get => base.OptionType as ItemOptionType;
            set => base.OptionType = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionType OptionType
        {
            get => base.OptionType;set
            {
                base.OptionType = value;
                this.OptionTypeId = this.RawOptionType?.Id;
            }
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

        
    }
}