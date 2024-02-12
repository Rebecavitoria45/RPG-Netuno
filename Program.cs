using System.Globalization;
int tentativas = 0;
string emailLogin;
string tipoPersonagem = "";
string ferramenta="";
int vida=0;
int mana=0;
double velocidadeAtaque=0;
double velocidadeMontaria=0;
int tempoDescanso=0;
string montaria= "";
Console.WriteLine("Seja bem vindo ao RPG Netuno");
Console.WriteLine("--------Cadastre-se---------");
Console.WriteLine("Digite seu Nome completo");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("Digite sua Data de nascimento");
string dataNascimento = Console.ReadLine();
DateTime dataConvertida = DateTime.ParseExact(dataNascimento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
DateTime dataAtual= DateTime.Now;
TimeSpan diferenca = dataAtual - dataConvertida;
int idade = diferenca.Days / 365; 
if(idade<18)
{
throw new Exception("Idade não permitida para jogar");
}

Console.WriteLine("Digite seu Email");
string emailCadastro = Console.ReadLine();

Console.WriteLine("Digite sua Senha");
string senhaCadastro = Console.ReadLine();
if(senhaCadastro.Length<8){
   throw new Exception( "A senha deve ter no minimo 8 caracteres");
}
Console.WriteLine("Confirme sua senha");
string confirmeSenha = Console.ReadLine();
if(confirmeSenha!=senhaCadastro){
    throw new Exception("Senha diferente da colocada anteriormente");
}
Console.WriteLine("Informações salvas!");
Console.Clear();

Console.WriteLine("--------Login---------");
do{
 Console.WriteLine("Digite o email que você cadastrou:");
  emailLogin = Console.ReadLine();  
}while(emailLogin!=emailCadastro);

while(tentativas<3)
{
Console.WriteLine("Digite a senha que você cadastrou:");
string senhalogin = Console.ReadLine();
if(senhalogin!=senhaCadastro){
    Console.WriteLine("Senha invalida");
    tentativas++;
}
else{
break;}
}
if(tentativas>=3){
    throw new Exception("Usuario não cadastrado");

}

Console.Clear();
Console.WriteLine("--------RPG Netuno---------");
Console.WriteLine("Escolha uma classe para seu Personagem");
Console.WriteLine("1.Paladino");
Console.WriteLine("2.Atirador");
Console.WriteLine("3.Guerreiro");
Console.WriteLine("4.Bárbaro");
Console.WriteLine("5.Arqueiro");

switch (Console.ReadLine())
    {
        case "1":
          tipoPersonagem = "Paladino";
           Console.WriteLine("Escolha a ferramenta entre lança e escudo");
           ferramenta = Console.ReadLine();
           vida=85;
           mana=35;
           velocidadeAtaque= 1.25;
            break;
          case "2":
         tipoPersonagem = "Atirador"; 
          ferramenta = "arma";
          vida=90;
          mana=50;
          velocidadeAtaque=5.5;
            break;
          case "3":
           tipoPersonagem = "Guerreiro"; 
            ferramenta = "Espada e Escudo";
             vida=50;
             mana=20;
            velocidadeAtaque=3.2;
            break;
          case "4":
           tipoPersonagem = "Bárbaro"; 
            Console.WriteLine("Escolha a ferramenta entre Machado ou Marreta");
           ferramenta = Console.ReadLine();
             vida=70;
             mana=25;
             velocidadeAtaque=2.2;
            break;
         case "5":
           tipoPersonagem = "Arqueiro"; 
            ferramenta = "Arco";
             vida=55;
            mana=50;
            velocidadeAtaque=3.9;
            break;
        default:
           throw new Exception("Personagem inexistente");
           
    }

  Console.WriteLine("--------Cadastre as caracteristicas Fisicas do personagem---------");
 Console.WriteLine("Escolha a cor dos cabelos");
 string corCabelo= Console.ReadLine();
  Console.WriteLine("Escolha a cor da pele");
   string corPele= Console.ReadLine();
  Console.WriteLine("Escolha a cor da roupa");  
   string corRoupa= Console.ReadLine();

 Console.Clear();
 Console.WriteLine("--------Escolha a montaria---------");
Console.WriteLine("1.Cavalo");
Console.WriteLine("2.Leão");
Console.WriteLine("3.Rinoceronte");
Console.WriteLine("4.Raposa");
Console.WriteLine("5.Dragão");

switch (Console.ReadLine())
    {
        case "1":
          montaria = "Cavalo";
          velocidadeMontaria=10;
          tempoDescanso=2;
            break;
         case "2":
          montaria = "Leão";
          velocidadeMontaria=35;
          tempoDescanso=10;
            break;
         case "3":
        montaria = "Rinoceronte";
        velocidadeMontaria=25;
          tempoDescanso=6;
            break;
        case "4":
           montaria = "Raposa";
           velocidadeMontaria=19;
          tempoDescanso=8;
            break;
         case "5":
          montaria = "Dragão";
          velocidadeMontaria=40;
          tempoDescanso=10;
            break;
        default:
           throw new Exception ("Montaria inexistente");
    }
    Console.Clear();
     Console.WriteLine($"--------Seu Personagem:{tipoPersonagem}---------");
     Console.WriteLine("Caracteristicas:");
     Console.WriteLine("Vida:"+vida);
     Console.WriteLine("Mana:"+mana);
     Console.WriteLine("Velocidade ataque:"+velocidadeAtaque);
     Console.WriteLine("Cor da pele:"+corPele);
     Console.WriteLine("Cor do cabelo:"+corCabelo);
     Console.WriteLine("Cor da roupa:"+corRoupa);
     Console.WriteLine("Ferramentas:");
      Console.WriteLine(ferramenta);
     Console.WriteLine("Montaria:"); 
    Console.WriteLine(montaria);  
    Console.WriteLine("Velocidade montaria:"+velocidadeMontaria + "m/s");
    Console.WriteLine("Tempo descanso:"+tempoDescanso + "minutos");

   Console.WriteLine("AGORA ESTAMOS PRONTOS PARA INICIAR NOSSA AVENTURA!");




  

