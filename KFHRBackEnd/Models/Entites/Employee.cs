﻿using KFHRBackEnd.Models.Entites.Request.Department;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace KFHRBackEnd.Models.Entites
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [Url]
        public string ProfilePicURL { get; set; }

        [AllowNull]
        public int? NFCIdNumber { get; set; }


        [AllowNull]
        public Position? PositionId { get; set; }

        [AllowNull]
        public Department? DepartmentId { get; set; }


        [AllowNull]
        public int? PointEarned { get; set; }

        [Required]
        public bool IsAdmin { get; set; }


        public bool VerifyPassword(string pwd) => BCrypt.Net.BCrypt.EnhancedVerify(pwd, Password);

    }


    public enum Gender
    {
        Male, Female
    }


}
