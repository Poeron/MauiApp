using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Models;

namespace MauiApp1.Pages;
public partial class ClientsPage : ContentPage
{
    private readonly ApiService _apiService;

    public ClientsPage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;

        // Fetch and display the clients when the page loads
        LoadClientsAsync();
    }

    private async void LoadClientsAsync()
    {
        try
        {
            string url = "https://localhost:7232/api/Clients/all";
            List<Client> clients = await _apiService.GetClientsAsync(url);

            // Bind the clients to the CollectionView
            ClientsCollectionView.ItemsSource = clients;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
