CREATE TABLE Messages (
    ID int NOT NULL,
    scadenza datetime NOT NULL,
    destinatario varchar(16) NOT NULL,
    testo varchar(1000) NOT NULL,
    titolo varchar(100) NOT NULL,
    PRIMARY KEY (ID)
);

INSERT INTO Messages (ID, scadenza, destinatario, testo, titolo) VALUES (1, '2020-11-30', 'MRRSSI79C01E388D', '__Questo è un messaggio di prova__', 'titolo messaggio di prova');
INSERT INTO Messages (ID, scadenza, destinatario, testo, titolo) VALUES (2, '2020-12-31', 'GDDAAR79C01E388D', '__Questo è un messaggio di prova 2__', 'titolo messaggio di prova 2');


