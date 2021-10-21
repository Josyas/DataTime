# DataTime

<br/>• Representa um INSTANTE
<br/>• É um tipo valor (struct)
<br/>• Agenda:
<br/>• Representação interna
<br/>• Instanciação: construtores, builders / conversão String -> DateTime
<br/>• Formatação: DateTime -> String

<br/>O tipo de valor DateTime representa datas e horários com valores que variam de 00:00:00 (meia-noite), 1 de janeiro de 0001 Anno Domini (Era Comum) até 11:59:59 P.M., 31 de dezembro de 9999 (C.E.) no calendário gregoriano.
<br/>Fonte: <br/>https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx


# Representação interna

<br/>• Um objeto DateTime internamente armazena:
<br/>• O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de 
<br/>janeiro do ano 1 da era comum

<br/>DateTime d1 = DateTime.Now;
<br/>Console.WriteLine(d1);
<br/>Console.WriteLine(d1.Ticks);


