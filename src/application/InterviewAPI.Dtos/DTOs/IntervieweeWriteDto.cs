using System;

namespace InterviewAPI.Dtos.DTOs
{
    public class IntervieweeWriteDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
    }
}