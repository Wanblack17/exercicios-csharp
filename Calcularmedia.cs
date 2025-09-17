//Código responsavel por calcular a média do aluno e mostrar se ele foi aprovado ou não

using System;
class HelloWorld {
  static void Main() {
    mensagem("Quantas Atividades foram realizadas?");
    string resposta = Console.ReadLine();
    int quantAtividade = Convert.ToInt32(resposta);
    double soma = 0.0;
    double media = 0.0;
    for(int i = 1; i<=quantAtividade; i++) {
        mensagem($"Qual foi a nota tirada na atividade {i}? ");
        string nota = Console.ReadLine();
        double nota1 = Convert.ToDouble(nota);
        soma += nota1;
    
  }
  media = soma/quantAtividade;
 if(media>5){
       mensagem($"A sua média foi de {media:F2}, parabéns!! você está aprovado");
 }
 else if (media==5){
     mensagem($"A sua média foi de {media:F2}, você está de recuperação!");
 }
 else {
     mensagem($"A sua média foi de {media:F2}, infelizmente você está reprovado");
 }
  
}static void mensagem(string texto){
      Console.WriteLine(texto);
  }}
