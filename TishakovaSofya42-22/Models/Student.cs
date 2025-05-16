﻿namespace TishakovaSofya42_22.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public int GroupId { get; set; }
        public bool IsDeleted { get; set; }
        public Group Group { get; set; }
    }
}
