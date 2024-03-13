namespace projetolegal;

public partial class GamePage : ContentPage
{
  //------------------------------------------------------------------------------------------------

  List<HistoryStep> historia = new List<HistoryStep>();
  HistoryStep HistoryStepAtual;

  //------------------------------------------------------------------------------------------------

	public GamePage()
	{
		InitializeComponent();

    historia.Add(new HistoryStep()
    {
      Id = 0,
      Texto = "oi tudo bom",
      TemResposta=false
    });
  
    }
}