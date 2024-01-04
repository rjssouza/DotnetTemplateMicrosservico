Comandos que devem ser executados para este template
* cd Working 
* dotnet build
* Mudar versao projeto 
**    <PackageVersion>1.0</PackageVersion>
* dotnet pack 

Caso ja tenha o template instalado executar:
* dotnet new uninstall Componentes.Utility.Templates

Instalar novo template
* dotnet new install .\bin\Release\Componentes.Utility.Templates.1.0.0.nupkg

Ao final vc devera ver o resultado 
Success: Componentes.Utility.Templates::1.0.0 installed the following templates:
Template Name                     Short Name     Language  Tags
--------------------------------  -------------  --------  ---------------------
Example templates: async project  microsservico  [C#]      Common/Console/WebApi

Apos essa instalação basta executar o novo comando:
dotnet new microsservico