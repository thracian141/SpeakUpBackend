﻿using System.ComponentModel.DataAnnotations;

namespace SpeakUp.Models.InputModels {
    public class RegisterInputModel {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
