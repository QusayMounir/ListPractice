namespace ListPractice;

public partial class FoodDetailsPage : ContentPage
{
	public FoodDetailsPage(Food food)
	{
		InitializeComponent();
		LblFoodName.Text = food.Name;
		LblSentence.Text = food.Sentence;
		ImgFood.Source = food.ImageName;
	}
}