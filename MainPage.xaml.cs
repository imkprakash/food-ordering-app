using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Order

{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            Calculate_Total();
        }

        private void Add_Item(Object sender, EventArgs e)
        {
            if (sender == Item1Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item1Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item1Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item1Total.Text = total.ToString() + " USD";
                    Item1Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item2Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item2Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item2Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item2Total.Text = total.ToString() + " USD";
                    Item2Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item3Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item3Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item3Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item3Total.Text = total.ToString() + " USD";
                    Item3Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item4Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item4Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item4Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item4Total.Text = total.ToString() + " USD";
                    Item4Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item5Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item5Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item5Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item5Total.Text = total.ToString() + " USD";
                    Item5Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item6Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item6Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item6Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item6Total.Text = total.ToString() + " USD";
                    Item6Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item7Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item7Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item7Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item7Total.Text = total.ToString() + " USD";
                    Item7Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item8Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item8Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item8Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item8Total.Text = total.ToString() + " USD";
                    Item8Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item9Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item9Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item9Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item9Total.Text = total.ToString() + " USD";
                    Item9Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item10Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item10Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item10Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item10Total.Text = total.ToString() + " USD";
                    Item10Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item11Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item11Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item11Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item11Total.Text = total.ToString() + " USD";
                    Item11Quantity.Text = quantity.ToString();
                }


            }

            if (sender == Item12Inc)
            {
                UInt64 quantity = Convert.ToUInt64(Item12Quantity.Text);
                if (quantity < 10)
                {
                    UInt64 price = Convert.ToUInt64(Item12Price.Text.Split(" ")[0]);
                    quantity++;
                    UInt64 total = price * quantity;
                    Item12Total.Text = total.ToString() + " USD";
                    Item12Quantity.Text = quantity.ToString();
                }


            }

            Calculate_Total();
        }

        private void Subtract_Item(Object sender, EventArgs e)
        {
            if (sender == Item1Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item1Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item1Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item1Total.Text = total.ToString() + " USD";
                    Item1Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item2Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item2Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item2Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item2Total.Text = total.ToString() + " USD";
                    Item2Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item3Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item3Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item3Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item3Total.Text = total.ToString() + " USD";
                    Item3Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item4Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item4Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item4Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item4Total.Text = total.ToString() + " USD";
                    Item4Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item5Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item5Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item5Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item5Total.Text = total.ToString() + " USD";
                    Item5Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item6Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item6Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item6Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item6Total.Text = total.ToString() + " USD";
                    Item6Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item7Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item7Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item7Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item7Total.Text = total.ToString() + " USD";
                    Item7Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item8Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item8Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item8Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item8Total.Text = total.ToString() + " USD";
                    Item8Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item9Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item9Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item9Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item9Total.Text = total.ToString() + " USD";
                    Item9Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item10Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item10Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item10Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item10Total.Text = total.ToString() + " USD";
                    Item10Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item11Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item11Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item11Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item11Total.Text = total.ToString() + " USD";
                    Item11Quantity.Text = quantity.ToString();
                }

            }

            if (sender == Item12Dec)
            {
                UInt64 quantity = Convert.ToUInt64(Item12Quantity.Text);
                if (quantity > 0)
                {
                    quantity--;
                    UInt64 price = Convert.ToUInt64(Item12Price.Text.Split(" ")[0]);
                    UInt64 total = price * quantity;
                    Item12Total.Text = total.ToString() + " USD";
                    Item12Quantity.Text = quantity.ToString();
                }

            }

            Calculate_Total();
        }

        private void Calculate_Total()
        {
            UInt64 total = 0;
            total += Convert.ToUInt64(Item1Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item2Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item3Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item4Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item5Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item6Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item7Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item8Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item9Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item10Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item11Total.Text.Split(" ")[0]);
            total += Convert.ToUInt64(Item12Total.Text.Split(" ")[0]);

            if (total <= 0)
            {
                ContinueButton.IsEnabled = false;

            }
            else
            {
                ContinueButton.IsEnabled = true;
            }

            finalTotal.Text = total.ToString() + " USD";
        }

        private async void Prepare_Order_Details(Object sender, EventArgs e)
        {
            var items = new List<OrderItem>();

            if (Convert.ToUInt64(Item1Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item1Name.Text, Item1Price.Text.Split(" ")[0], Item1Quantity.Text));
            }
            if (Convert.ToUInt64(Item2Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item2Name.Text, Item2Price.Text.Split(" ")[0], Item2Quantity.Text));
            }
            if (Convert.ToUInt64(Item3Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item3Name.Text, Item3Price.Text.Split(" ")[0], Item3Quantity.Text));
            }
            if (Convert.ToUInt64(Item4Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item4Name.Text, Item4Price.Text.Split(" ")[0], Item4Quantity.Text));
            }
            if (Convert.ToUInt64(Item5Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item5Name.Text, Item5Price.Text.Split(" ")[0], Item5Quantity.Text));
            }
            if (Convert.ToUInt64(Item6Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item6Name.Text, Item6Price.Text.Split(" ")[0], Item6Quantity.Text));
            }
            if (Convert.ToUInt64(Item7Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item7Name.Text, Item7Price.Text.Split(" ")[0], Item7Quantity.Text));
            }
            if (Convert.ToUInt64(Item8Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item8Name.Text, Item8Price.Text.Split(" ")[0], Item8Quantity.Text));
            }
            if (Convert.ToUInt64(Item9Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item9Name.Text, Item9Price.Text.Split(" ")[0], Item9Quantity.Text));
            }
            if (Convert.ToUInt64(Item10Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item10Name.Text, Item10Price.Text.Split(" ")[0], Item10Quantity.Text));
            }
            if (Convert.ToUInt64(Item11Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item11Name.Text, Item11Price.Text.Split(" ")[0], Item11Quantity.Text));
            }
            if (Convert.ToUInt64(Item12Quantity.Text) > 0)
            {
                items.Add(new OrderItem(Item12Name.Text, Item12Price.Text.Split(" ")[0], Item12Quantity.Text));
            }

            for (int i = 0; i < items.Count; i++)
            {
                Debug.WriteLine(items[i].Name + ", " + items[i].Price + ", " + items[i].Units + ", " + items[i].Total);
            }

            try
            {
                using var httpClient = new HttpClient();

                // Replace <port> with the actual port number where your ASP.NET Core API is running
                var response = await httpClient.PostAsJsonAsync("https://localhost:7281/api/orders", items);

                if (response.IsSuccessStatusCode)
                {
                    // Order successfully placed
                    Console.WriteLine("Order placed successfully!");
                }
                else
                {
                    // Handle error response
                    Console.WriteLine($"Failed to place order. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error placing order: {ex.Message}");
            }

            await Navigation.PushAsync(new OrderDetailsPage(items));
            }

        }

    }
