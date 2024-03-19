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
      TextoResposta1="bate na porta com delicadeza.",
      TextoResposta2="da uma bicuda na porta com toda sua força.",
      TextoResposta3="segue o caminho pela floresta.",
      IdLevelResposta1=2,
      IdLevelResposta2=3000,
      IdLevelResposta3=3001,
      });
     historia.Add(new HistoriaStep()
    {
      Id = 2,
      Texto = "você é recebido por uma capivara humanoide bem vestida por sinal ( seu nome é Sr capivaldo)",
      TemResposta=false,
    });
    historia.Add(new HistoriaStep()
    {
      Id = 3000,
      Texto = "Sr capivaldo abre a porta com um machado e arranca sua cabeça",
      TemResposta=false,
      vcmorreu=true
    });
    historia.Add(new HistoriaStep()
    {
      Id = 3001,
      Texto = "você caminha por algum tempo e acaba morrendo de fome",
      TemResposta=false,
      vcmorreu=true
    });
     historia.Add(new HistoriaStep()
    {
      Id = 3,
      Texto = "Sr capivaldo te recebe em sua humilde residência, mas logo te pergunta o que aconteceu para você está perdido naquela hora da noite ele ressalta que naquelas horas era perigoso alguém estar andando sozinho por lá",
      TemResposta=false
    });
    historia.Add(new HistoriaStep()
    {
      Id = 4,
      Texto = "oq vc responde?",
      TemResposta=true,
      TextoResposta1=" você manda ele calar a boca, e pede para ficar em paz",
      TextoResposta2="você mente pra ele e diz que está ali só caminhando",
      TextoResposta3="explica para ele que acabou sofrendo um acidente e que tinha avistado uma casa e foi pedir ajuda",
      IdLevelResposta1=3002,
      IdLevelResposta2=5,
      IdLevelResposta3=5,
      });
      historia.Add(new HistoriaStep()
    {
      Id = 5,
      Texto = "Sr capivaldo te recebe em sua humilde residência, mas logo te pergunta o que aconteceu para você está perdido naquela hora da noite ele ressalta que naquelas horas era perigoso alguém estar andando sozinho por lá",
      TemResposta=false
    });
    historia.Add(new HistoriaStep()
    {
      Id = 6,
      Texto = "Após a conversa amigável que vocês tiveram, ele logo te mostra o quarto que você irá ficar.O quarto é bem aconchegante e espaçoso, no começo você acaba desconfiando pois tem mais quartos na casa e a maioria tem camas de casal, mas é nada de mais não é? Você está deitado confortavelmente pelo cansaço, você acaba dormindo profundamente. Mas Logo o seu longo descanso chega ao fim",
      TemResposta=false
    });
    historia.Add(new HistoriaStep()
    {
      Id = 3002,
      Texto = "você caminha por algum tempo e acaba morrendo de fome",
      TemResposta=false,
      vcmorreu=true
    });
historia.Add(new HistoriaStep()
    {
      Id = 7,
      Texto = "olá pessoa desconhecida, nossos desenvolvedores estamos trabalhando em uma segunda parte da nossa querida historia caso tenha alguma ideia para complementar entre em contato conosco acesse o e-mail alifersilva@gmail.com",
      TemResposta=true,
      TextoResposta1="voltar",
      TextoResposta2="voltar",
      TextoResposta3="voltar",
      IdLevelResposta1=0,
      IdLevelResposta2=0,
      IdLevelResposta3=0,
      });
    Iniciar();
  }
  //-------------------------------------------------------------------------------------------------------------------------------
     void Iniciar()
  {
    TrocaHistoriaStepAtual(0);
  }
  //-------------------------------------------------------------------------------------------------------------------------------
    void PreencherPagina()
  {
    labelTexto.Text = HistoriaStepAtual.Texto;
    
    if (HistoriaStepAtual.vcmorreu)
      Morte.IsVisible = true;
    else
      Morte.IsVisible = false;
    
    if (HistoriaStepAtual.TemResposta)
    {
      proximo.IsVisible = false;
      Resposta1.IsVisible = true;
      Resposta2.IsVisible = true;
      Resposta3.IsVisible = true;
      Resposta1.Text = HistoriaStepAtual.TextoResposta1;
      Resposta2.Text = HistoriaStepAtual.TextoResposta2;
      Resposta3.Text = HistoriaStepAtual.TextoResposta3;
    }
     else
    {
      proximo.IsVisible = true;
      Resposta1.IsVisible = false;
      Resposta2.IsVisible = false;
      Resposta3.IsVisible = false;
    }
  }
  //------------------------------------------------------------------------------------------------------------------------
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
//--------------------------------------------------------------------------------------------------------------------------    
//------------------------------------------------------------------------------------------------

  void Butao1(object sender, EventArgs args)
  {
    TrocaHistoriaStepAtual(HistoriaStepAtual.IdLevelResposta1);
  }

  //------------------------------------------------------------------------------------------------

  void Butao2(object sender, EventArgs args)
  {
    TrocaHistoriaStepAtual(HistoriaStepAtual.IdLevelResposta2);
  }

  //------------------------------------------------------------------------------------------------

  void Butao3(object sender, EventArgs args)
  {
    TrocaHistoriaStepAtual(HistoriaStepAtual.IdLevelResposta3);
  }

  //------------------------------------------------------------------------------------------------
 void Tryagain(object sender, EventArgs args)
  {
    Iniciar();
  }

  //------------------------------------------------------------------------------------------------

}
