# TasksApp


- Abrir o terminal

## Compilar o projeto

- docker-compose up -d --build

## Rodar o projeto

*http://localhost:{porta_definida_na_instancia_docker}/swagger/index.html

## Verificar os containers

- docker ps -a 

## Docker logs(para verificar algum possiveis problemas)

docker logs (id_do_projeto)

## Refinamento

* Seria bem interessante enviar os parametros para fazer integração com a API de autenticação, para um desenvolvimento mais real

## Melhorias

* Seria muito importante a instalação de uma ferramenta de observabilidade visual, sugiro Jeager, o Open Telemetry já está instalado no projeto