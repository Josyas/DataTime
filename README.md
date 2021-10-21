# DataTime

<br/>• Representa um INSTANTE
<br/>• É um tipo valor (struct)
<br/>https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx
<br/>• Agenda:
<br/>• Representação interna
<br/>• Instanciação: construtores, builders / conversão String -> DateTime
<br/>• Formatação: DateTime -> String


# Representação interna

<br/>• Um objeto DateTime internamente armazena:
<br/>• O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de 
<br/>janeiro do ano 1 da era comum

<br/>DateTime d1 = DateTime.Now;
<br/>Console.WriteLine(d1);
<br/>Console.WriteLine(d1.Ticks);
