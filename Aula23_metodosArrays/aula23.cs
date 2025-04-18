/*02:41 - Binary Search

O Binary Search (Busca Binária) é um algoritmo de busca que vai dividindo uma array sempre pela metade, até encontrar o valor desejado. É como se pegássemos uma lista telefônica e a rasgássemos no meio. Desse jeito, não teríamos de procurar por um nome em toda lista, mas, sim, apenas em sua metade.
O que acontece nesse método, é que ele faz isso de maneira automática para nós.
Você diz em que array (vetor) quer encontrar um valor, e depois qual o valor que quer encontrar.
Se o código retornar um número menor do que 0, significa que o valor procurado não foi encontrado em nenhuma posição. Se for, retornará o seu índice (sua posição na array).

03:57 - Copy

O método Copy nos permite copiar os dados de uma array para outra.
Para isso, dizemos qual a array que queremos copiar; para qual array queremos passar os valores copiados; e quantos elementos que queremos copiar (usando o seu Length).

05:00 - CopyTo

O método CopyTo é parecido com o Copy, ou seja, também nos permite copiar as informações de uma array para a outra.
Para usá-lo, temos da chamá-lo a partir da array que queremos copiar; dizer para qual array queremos passar os valores copiados; e a partir de qual posicao da array que queremos copiar).

05:42 - GetLowerBound

(Não entendi muito bem em que cenário o usaríamos) O método GetLowerBound nos diz qual é o menor índice de nossa array.
Pelo o que entendi, sempre retornará 0, porque não podemos ter uma array com menos elementos do que 0.

07:09 - GetUpperBound

Pelo o que entendi, o método GetUpperBound é tipo o .Length. O que significa que ele nos diz até que índice vai nossa array (se tivermos 5 elementos, vai até a 4 - porque começamos a contar a partir do 0).

07:55 - GetValue

O método GetValue nos diz qual é o valor presente na posição que indicamos.
Por exemplo: se temos uma array do tipo string com os valores: "banana", "morango", "maça". Ao pedir o valor da posição 1, receberíamos a string "morango".

09:01 - IndexOf

O método IndexOf nos diz em qual posição da array está o valor que procuramos (mas sempre pegando sua primeira aparição).
Por exemplo: se temos uma array do tipo string com os valores: "banana", "morango", "banana". Ao pedirmos o índice do valor "banana", receberíamos a valor 0 (que é a sua primeira aparição na array).

09:41 - LastIndexOf

O método LastIndexOf é idêntico ao IndexOf. Porém, ao invés de nos dizer onde está a primeira aparição do valor, nos diz onde está sua última.
Por exemplo: se temos uma array do tipo string com os valores: "banana", "morango", "banana". Ao pedirmos o índice do valor "banana", receberíamos a valor 2 (que é a sua última aparição na array).

10:20 - Reverse

O método Reverse nos permite colocar os valores de uma array na ordem contrário.
Por exemplo: se temos uma array do tipo int com os valores: 3, 5, 1, 7. Ao usarmos o Reverse, teríamos uma array com os valores: 7, 1, 5, 3 (que são os mesmos que o anterior, mas ao contrário).

10:48 - SetValue

O método SetValue nos permite acessar uma posição específica da array e lhe dar um novo valor.
É como se fosse o: nomeDaArray[posicaoDesejada] = novoValor.
Para usá-lo, temos de dizer a posição que queremos acessar, e seu novo valor.

11:46 - Sort

O método Sort nos permite organizar em ordem crescente os valores de uma array.
Por exemplo: se temos uma array do tipo int com os valores: 3, 5, 1, 7. Ao usarmos o Sort, teríamos uma array com os valores: 1, 3, 5, 7 (que são os mesmos que o anterior, mas na ordem correta).

Muito obrigado ao professor Bruno por todas suas aulas e carinho, e a você por ter lido até aqui :)*/