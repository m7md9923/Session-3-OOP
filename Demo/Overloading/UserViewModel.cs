using System.Reflection.Metadata;

namespace Demo.Overloading;

public class UserViewModel
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }

    public override string ToString()
    {
        return $"Id = {Id} , FirstName = {FirstName} , LastName = {LastName} , Email = {Email}";
    }

    public static explicit operator UserViewModel(User user)
    {
        UserViewModel userViewModel = new UserViewModel()
        {
            Id = user.Id,
            Email = user.Email
        };
        string[]? names = user?.FullName?.Split(" ");
        if (names is not null && names.Length > 1)
        {
            userViewModel.FirstName = names[0];
            userViewModel.LastName = names[1];
        }
        return userViewModel;
    }
}