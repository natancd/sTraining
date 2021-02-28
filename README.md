# sTraining

Projeto criado usando Windows Forms Apps com a linguagem C# (a implementar: SQL), .NET Framework em Visual Studio 2019.

Para executá-lo, basta baixar o repositório e rodar a solução na pasta "sTraining" (sTraning.sln).

Este projeto tem como função principal criar e listar usuários, salas de evento e espaços de café.
O usuário deverá informar um Nome e Sobrenome, Sala de Evento (com lotação) e um Espaço de Café.

Há validações apenas para que alguma os inputs não sejam nulos ou em branco.

Com os dados preenchidos, a pessoa cadastrada será listada na lista abaixo dos campos (todos obrigatórios).
Ao selecionar o usuário, os botões das Salas e dos Espaços estarão visíveis e todos os usuários que estiveram naquela Sala ou no Espaço serão listados (ainda há implementar).

Todos os dados serão inseridos em uma database local, podendo ser filtrados ao clicar no botão com o nome específico (filtro de acordo com o nome do botão clicado).

Com a futura implementação da database, é possível filtrar, também, a lotação de cada sala, para atender o requisito de ter diferença de no máximo uma pessoa por sala.
