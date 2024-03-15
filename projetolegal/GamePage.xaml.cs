namespace projetolegal;

public partial class GamePage : ContentPage
{
  //------------------------------------------------------------------------------------------------

  List<HistoriaStep> historia = new List<HistoriaStep>();
  HistoriaStep HistoriaStepAtual;

  //------------------------------------------------------------------------------------------------

	public GamePage()
	{
		InitializeComponent();

    historia.Add(new HistoriaStep()
    {
      Id = 0,
      Texto = "olá senhor forasteiro você infelizmente sofreu um acidente terrivel indo para um acampamento com os seus amigos pelo o acidente que ocorreu vc está desnorteado pelo impacto, quando sua visão começa a se acerta vc percebe a longe um pequeno chalé Ao seus olhos ele parece ser bem convidativo",
      TemResposta=false
    });
    historia.Add(new HistoriaStep()
    {
      Id = 1,
      Texto = "o que você prefere fazer?",
      TemResposta=true,
      TextoDaResposta01="bate na porta com delicadeza.",
      TextoDaResposta02="da uma bicuda na porta com toda sua força.",
      TextoDaResposta03="segue o caminho pela floresta.",
      IdLevelResposta01=2,
      IdLevelResposta02=3000,
      IdLevelResposta03=3001
    });
     historia.Add(new HistoriaStep()
    {
      Id = 2,
      Texto = "você é recebido por uma capivara humanoide bem vestida por sinal ( seu nome é Sr capivaldo)",
      TemResposta=false,
    });
    Iniciar();
  }
     
     void Iniciar()
  {
    TrocaHistoriaStepAtual(0);
  }
    void PreencherPagina()
  {
    labelTexto.Text = HistoriaStepAtual.Texto;
  }
void TrocaHistoriaStepAtual(int id)
  {
    HistoriaStepAtual = historia.Where(d => d.Id == id).First();
    PreencherPagina();
  }
void ProximoClicked(object sender, EventArgs args)
  {
    var proximoId = HistoriaStepAtual.Id + 1;
    TrocaHistoriaStepAtual(proximoId);
  }
    
}