namespace ListPractice
{
    public partial class MainPage : ContentPage
    {
        public List<Food> Food = new()
        {
            new Food { 
                Name = "Apple",
                ImageName = "apple.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Banana",
                ImageName = "banana.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Coffe",
                ImageName = "coffee.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Coffee Cup",
                ImageName = "coffee_cup.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Coffee Latte",
                ImageName = "coffee_latte.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Cupkace",
                ImageName = "cupkace.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Juice Box",
                ImageName = "juice_box.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Green Luch Box",
                ImageName = "lunch_box_green.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Pink Lunch Box",
                ImageName = "lunch_box_pink.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Lunch",
                ImageName = "lunch.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Macaron",
                ImageName = "macaron.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Milk",
                ImageName = "milk.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Milk Box",
                ImageName = "milkBox.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Muffin",
                ImageName = "muffin.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Mug",
                ImageName = "mug.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Pear",
                ImageName = "pear.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Sandwich",
                ImageName = "sandwich.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
            new Food {
                Name = "Thermos",
                ImageName = "thermos.png",
                Sentence = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Maxime mollitia, "
            },
        };

        public MainPage()
        {
            InitializeComponent();
            LFood.ItemsSource = Food;
            
        }

        private void LFood_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var SelectedItem = e.SelectedItem as Food;
            //if (SelectedItem == null) return;
            //Navigation.PushAsync(new FoodDetailsPage(SelectedItem));
            //((ListView)sender).SelectedItem = null;
        }

        private void LFood_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SelectedItem = e.CurrentSelection.FirstOrDefault() as Food;
            if (SelectedItem == null) return;
            Navigation.PushAsync(new FoodDetailsPage(SelectedItem));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}