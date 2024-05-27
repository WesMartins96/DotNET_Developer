using Calculadora.Services;

namespace CalculadoraTestes
{
    public class CalculadoraTests
    {
        private CalculadoraImp _calc;

        public CalculadoraTests() 
        { 
            _calc = new CalculadoraImp();
        }


        [Fact]
        public void DeveSomar5Com10ERetornar15()
        {
            //Arrange (monta o cenario)
            int num1 = 5;
            int num2 = 10;

            //Act (chamar a ação)
            int resultado = _calc.Somar(num1, num2);

            //Assert (validar se tem o resultado esperado)
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void DeveSomar5Com10ERetornar20()
        {
            //Arrange (monta o cenario)
            int num1 = 10;
            int num2 = 10;

            //Act (chamar a ação)
            int resultado = _calc.Somar(num1, num2);

            //Assert (validar se tem o resultado esperado)
            Assert.Equal(20, resultado);
        }


        [Fact]
        public void DeveVerificarSe4EhParERetornarVerdadeiro()
        {
            //Arrange
            int num = 4;

            //Act
            bool resultado = _calc.Ehpar(num);

            //Assert
            Assert.True(resultado);

        }


        //verificar se 2, 4, 6, 10 são Par de modo otimizado
        //Theory - conjunto de dados que vai validando a cada execução em um unico teste
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]
        public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int num) //paramentro num é o valor de InlineData, (PODEMOS USAR LISTAS)
        {
            //Arrange (neste caso não se usa Arrange)

            //Act
            bool resultado = _calc.Ehpar(num);

            //Assert
            Assert.True(resultado);
        }


        [Theory]
        [InlineData(new int[] { 2, 4 })]
        [InlineData(new int[] { 6, 8, 10 })]
        public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiroUsandoLista(int[] numeros) //Usando lista
        {
            //Arrange (neste caso não se usa Arrange)

            //Act / Assert (Neste caso é necessário "unir" Act e Assert) para avlidar cada elemento da lista

            //Poderiamos usar o Foreach abaixo, porem mais abaixo tem uma melhor opção
            //foreach (var item in numeros)
            //{
            //    Assert.True(_calc.Ehpar(item));
            //}

            //usando apenas uma linha de código para validação 
            Assert.All(numeros, x => Assert.True(_calc.Ehpar(x)));  //variavel x recebe o valor de InlineData
        }

    }
}