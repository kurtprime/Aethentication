using System;

namespace AethenticationPrototype.Authentication;

public class FormValidation
{
    public bool ValidateUsername(string username) => (username != String.Empty) && (username.Length >= 4);
    
    public bool ValidatePassword(string password) => (password != String.Empty) && (password.Length >= 4);
}