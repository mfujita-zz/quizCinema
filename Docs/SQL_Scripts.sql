create database quizCinema
use quizCinema

create table tb_jogador (
  id_jogador int identity not null,
  nome varchar(30) not null,
  sobrenome varchar(30),
  email varchar(50) not null
)


create table tb_perguntas (
  id_pergunta int identity not null,
  pergunta varchar(max),
  resposta_correta varchar(max),
  nivel varchar(10),
  pontos int,
  id_jogador int
)

insert into tb_jogador(nome, sobrenome, email) values ('Murilo','Fujita','murilofujita@gmail.com') 
select nome,sobrenome, email from tb_jogador where id_jogador = 1;
select * from tb_perguntas 
select sum(pontos) from tb_perguntas where id_jogador = 3