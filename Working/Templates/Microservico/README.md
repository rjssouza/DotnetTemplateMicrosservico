# FAPCLP
Este projeto utiliza as seguintes dependencias:
* Node 18.14.0
* Dotnet Core 7.0 (ef core 7.0.5)
* Angular 15.1.5

Após a instalação dessas dependencias basta executar o migration seguindo abaixo:
* Para executar a migration do auth e dos chamados execute o comando:
* * Context/Pedidos
* * * dotnet ef --startup-project ..\..\Web\WebApi migrations add InitialCreate -o Data/Migrations	
* * * dotnet ef --startup-project ..\..\Web\WebApi database update  

Para a execução do site localmente é importante que tenha o WebApi e IdentityServer rodando juntos para isso execute os comandos
cd ..\..\Web\WebApi
dotnet run 

Caso queira debugar um dos serviços, basta selecionar o mesmo como projeto principal em sua IDE e executar, não e necessario executar o comando.

Publicação
Para publicar execute os comandos abaixo:
cd  Web\WebApi
dotnet publish -c Release -o C:\temp\publish\release\WebApi
