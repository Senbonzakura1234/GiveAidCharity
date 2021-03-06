﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GiveAidProject.Models
{
    public class ProjectImage
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Project")]
        public string ProjectId { get; set; }
        public virtual Project Project { get; set; }

        [Required]
        [Url]
        public string Url { get; set; }
        public string Description { get; set; }

        public ProjectImageStatusEnum Status { get; set; }
        public enum ProjectImageStatusEnum
        {
            Show = 1,
            Deleted = 0
        }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime UpdatedAt { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DeletedAt { get; set; }

        public ProjectImage()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Status = ProjectImageStatusEnum.Show;
        }
    }
}