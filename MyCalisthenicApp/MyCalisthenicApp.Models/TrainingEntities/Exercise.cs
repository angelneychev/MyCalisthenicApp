﻿namespace MyCalisthenicApp.Models.TrainingEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyCalisthenicApp.Data.Common.Models;
    using MyCalisthenicApp.Models.ShopEntities;

    public class Exercise : BaseDeletableEntity<string>
    {
        public Exercise()
        {
            this.Id = Guid.NewGuid().ToString();
            this.IsDeleted = false;
            this.CreatedOn = DateTime.UtcNow;
            this.Images = new HashSet<Image>();
        }

        [Required]
        [MaxLength(DataValidations.ExerciseNameMaxLength)]
        public string Name { get; set; }

        [MaxLength(DataValidations.ExerciseDescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string VideoUrl { get; set; }

        [Required]
        public string ProgramCategoryId { get; set; }

        public virtual ProgramCategory ProgramCategory { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
