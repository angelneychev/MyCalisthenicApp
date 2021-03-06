﻿namespace MyCalisthenicApp.Models.ShopEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MyCalisthenicApp.Data.Common.Models;

    public class Supplier : BaseDeletableEntity<string>
    {
        public Supplier()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreatedOn = DateTime.UtcNow;
            this.IsDeleted = false;
            this.IsDefault = false;
        }

        [Required]
        [MaxLength(DataValidations.SupplierNameMaxLength)]
        public string Name { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(DataValidations.SupplierPriceMinValue, double.MaxValue)]
        public decimal PriceToHome { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(DataValidations.SupplierPriceMinValue, double.MaxValue)]
        public decimal PriceToOffice { get; set; }

        public bool IsDefault { get; set; }

        public string LogoUrl { get; set; }
    }
}
