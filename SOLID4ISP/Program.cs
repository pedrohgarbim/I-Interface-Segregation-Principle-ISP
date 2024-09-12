// Interface Segregation Principle (ISP)
// Uma classe não deve ser forçada a implementar métodos que ela não usa.
// Isso significa que as interfaces devem ser específicas.



// Sem ISP (violando o princípio):
// a interface IWworker define varios metodos, mas nem todos os trabalhadores em questao
// fazem o que a interface pede 

Console.WriteLine("Humano trabalhando.");
Console.WriteLine("Humano comendo.");

Console.WriteLine("Robô trabalhando.");
Console.WriteLine("Robô comendo.");


// o problema que não respeita o princípio é que o eobo nao deveria implementaro metodo
//eat, eles nao precisam comer. Isso viola o ISP, para arruamar isso, deve se dividir a 
// interface em interfaces menores e específicas 


Console.WriteLine("Humano trabalhando.");
Console.WriteLine("Humano comendo.");


Console.WriteLine("Robô apenas trabalhando.");

// Agora, as classes HumanWorker e RobotWorker só implementam os métodos
// que fazem sentido para elas. Resoeitando assim o principio Interface Segregation 