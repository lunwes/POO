using AbistrataCliente;

Teste t = new Teste();

ClienteFisico cf = new ClienteFisico(1, "Ana", 18, 100);
cf.Mostrar();
t.AvaliarIdadeCliente(cf);

ClienteJuridico cj = new ClienteJuridico(2, "Empresa", 46, 222);
cj.Mostrar();
t.AvaliarIdadeCliente(cj);