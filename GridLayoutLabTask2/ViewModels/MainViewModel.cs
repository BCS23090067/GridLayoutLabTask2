using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GridLayoutLabTask2.Models;

namespace GridLayoutLabTask2.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private PuppyModel puppy;

        public MainViewModel()
        {
            // Initialize with Robin Hood data
            Puppy = new PuppyModel
            {
                Name = "Robin Hood ♥",
                Breed = "Pug",
                Age = "1 year old",
                Location = "3B, Lorong 88, Taman Rantau Panjang, 96000 Sibu, Sarawak",
                OwnerName = "Jeon Jungkook",
                OwnerTitle = "Owner",
                DatePosted = "1.11.2024",
                Description = "Hi! Robin the Pug is simply a tiny tornado of fur, wrinkles, and endless charm!",
                ImageSource = "puppy.jpg",
                OwnerImageSource = "owner.jpg",
                LocationIconSource = "location.png"
            };
        }

        [RelayCommand]
        private async Task AdoptPuppy()
        {
            await Application.Current.MainPage.DisplayAlert(
                "Adoption Request", 
                $"Thank you for your interest in adopting {Puppy.Name.Replace(" ♥", "")}!", 
                "OK");
        }
    }
}