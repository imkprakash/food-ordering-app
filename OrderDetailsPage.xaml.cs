using System.Collections.Generic;

using Microsoft.Maui.Controls;

namespace Order;


public partial class OrderDetailsPage : ContentPage
{
	public OrderDetailsPage(List<OrderItem> order_items)
	{
		InitializeComponent();
        Populate_Grid(order_items);
	}

	private void Populate_Grid(List<OrderItem> order_items)
	{
        UInt64 total_items = 0, total_cost = 0;
        OrderGrid.AddRowDefinition(new RowDefinition());
        for (int i = 0; i < order_items.Count; i++)
        {
            total_items += order_items[i].Units;
            total_cost += order_items[i].Total;
            OrderGrid.AddRowDefinition(new RowDefinition());
            OrderGrid.Add(new Label { Padding = new Thickness(10,0,0,0), Text = order_items[i].Name, HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Center  }, 0, i+2);
            OrderGrid.Add(new Label {  Text = order_items[i].Price.ToString() + " USD", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center }, 1, i + 2);
            OrderGrid.Add(new Label { Text = order_items[i].Units.ToString(), HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center }, 2, i + 2);
            OrderGrid.Add(new Label { Padding = new Thickness(0, 0, 10, 0), Text = order_items[i].Total.ToString() + " USD", HorizontalOptions = LayoutOptions.End, VerticalOptions = LayoutOptions.Center }, 3, i + 2);
        }
        OrderGrid.AddRowDefinition(new RowDefinition());
        OrderGrid.AddRowDefinition(new RowDefinition());
        OrderGrid.Add(new Label { Padding = new Thickness(10, 0, 0, 10), Text = "Total", HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Center, FontAttributes = FontAttributes.Bold }, 0, order_items.Count + 3);
        OrderGrid.Add(new Label { Padding = new Thickness(0, 0, 0, 10), Text = total_items.ToString(), HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, FontAttributes = FontAttributes.Bold }, 2, order_items.Count+3);
        OrderGrid.Add(new Label { Padding = new Thickness(0, 0, 10, 10), Text = total_cost.ToString() + " USD", HorizontalOptions = LayoutOptions.End, VerticalOptions = LayoutOptions.Center, FontAttributes = FontAttributes.Bold }, 3, order_items.Count+3);

        var bg = new BoxView
        {
            Opacity = 0.2,
            CornerRadius = 10
        };
        Grid.SetColumnSpan(bg, 4); // Span across all columns
        Grid.SetRowSpan(bg, order_items.Count+4);
        Grid.SetRow(bg, 0); // Set the partition to the second row
        OrderGrid.Children.Add(bg);

        var partition1 = new BoxView
        {
            HeightRequest = 1,
            BackgroundColor = Colors.White,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.Center,
            
        };
        Grid.SetColumnSpan(partition1, 4); // Span across all columns
        Grid.SetRow(partition1, 1); // Set the partition to the second row
        OrderGrid.Children.Add(partition1);

        var partition2 = new BoxView
        {
            HeightRequest = 1,
            BackgroundColor = Colors.White,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            VerticalOptions = LayoutOptions.Center,
            
        };
        Grid.SetColumnSpan(partition2, 4); // Span across all columns
        Grid.SetRow(partition2, order_items.Count+2); // Set the partition to the second row
        OrderGrid.Children.Add(partition2);
    }
    
}