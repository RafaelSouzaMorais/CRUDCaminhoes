# CRUDCaminhoes

Após abrir a solution, deve-se abrir o arquivo "appsettings.json" e deve ser alterada a string de conexão na atributo "DefaultConnection" para o servidor de armazenamento sqlserver local.
O nome da base utilizada não precisa se um existe, pois a aplicação irá criar a base se ela não existir.
Após isso basta recuperar os pacotes, buildar a solution e executar a aplicação e vislumbrar a mágica.

Foi desenvolvido utilizando o VS2022 utilizando o framework .NetCORE com MVC, EnityFramework e SQLServerExpress 2015, mas não foi aplicado os testes unitarios(tenho pouquissimo conhecimento sobre isso), e utilizando as ferramentas de criação dos controles e visões automáticos sendo feitas as modificações necessarias para satisfazer o que foi requisitado.
