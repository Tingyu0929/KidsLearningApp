namespace KidsLearningApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        var commandParameter = (sender as ImageButton)?.CommandParameter as string;

        // 在這裡處理按鈕點擊事件的邏輯
        // 例如，你可以導航到相應的詳細頁面，傳遞類別名稱作為參數
        if (!string.IsNullOrEmpty(commandParameter))
        {
            Navigation.PushAsync(new KidsLearningDetailPage(commandParameter));
        }
    }
}