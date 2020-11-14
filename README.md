# Curso de C# - CFB Cursos

Continuar na aula: 16

### Observações
[Preparando ambiente Visual Studio para rodar C#](https://www.youtube.com/watch?v=dVzJ3bx68FA&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=1)

* `csc <nomeArquivo.cs>` - Para fazer um executavel do programa. (**Compilar** o programa)
* `./<nomeArquivo>` - **Executar** o Programa.
* **`dotnet new console`** - Cria toda **Estrutura** (program.cs.....)
* `static int num` - Variaveis **globais**(static)
* `const int num;` - **const** = variavel constante.
* `enum DiasSemana = {segunda, ...}` 
   * `DiasSemana ds = DiasSemana.Domingo`
   * `DiasSemana ds = (DiasSemana)3` - Convertido (indice)
* Tipos de formataçoes:
   * `{0, 10}` - indice 0 com 10 de espaçamento.
   * `{0, 10:c}` - indice 0 com 10 de espaçamento, **monetario** (R$)
   * `{0, 10:p}` - indice 0 com 10 de espaçamento, **porcentagem** (%)
* Conversão:
   * `int.Parse()` - Converter para inteiro.
   * `Convert.ToInt32()` - Converter para inteiro.
* BitWise
   * `num = num << 1` - Deslocamento para a esquerda -> **Dobra**
   * `num = num >> 1` - Deslocamento para a direita  -> **Divide**(metade). 
* Label
   * `inicio:` -> `goto inicio;`
* Array Unidimencional (vetor)
   * `int[] num = new int[5]` - array de 5 elementos, sem declarar
      * `n[0] = 1;` ...
   * `int[] num = new int[3] {1, 2, 3}` - array de 3 elementos ja declarados
   * `int[] num = {1, 2, 3, 4, 5}` - array de 5 elementos, sem declarar o tamanho.
* Array Bidimencional (matriz)
   * `int[,] matriz = new int [3,5]` - Matriz de 3 linhas e 5 colunas
      * `matriz[0,0] = 1` ...
   * `int[,] matriz = new int [2,2] { {1, 2},{3, 4} }` - já declarados
