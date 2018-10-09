function HideElement(IdElemento)
{
	document.getElementById(IdElemento).style.display = 'none';
}

function ShowElement(IdElemento)
{
	var x = document.getElementById(IdElemento);

    if (x.style.display === "none") 
        x.style.display = "block";
}


// Funcionamento da calculadora 


var expression="";
var cont2 = 0;
var resultado = 0;
var operadores;
var valores;

function storeButtons(string)
{
	expression += string;
	document.getElementById("Resultado").value = expression;
}

function clearExpression()
{
	expression = "";
	document.getElementById("Resultado").value = expression;
}

function clearLastIndex()
{
	var cont = 1;

	if(document.getElementById("Resultado").value == "")
	{
		cont = 0;
		cont2 = 0;
	}
	else
	{
		expression = document.getElementById("Resultado").value;
		var foo = expression.substring(0, expression.length - cont);

		expression = foo;

		document.getElementById("Resultado").value = expression;
	}
}

function getExpressionAndCalculate()
{
	var  valor1, valor2;

	var textoDigitado = document.getElementById("Resultado").value;

	document.getElementById("Resultado").value = eval(textoDigitado);
	
	/*
    operador = textoDigitado.match(/[+]|[-]|[*]|[/]/);
    valores = textoDigitado.split(/[+]|[-]|[*]|[/]/);

    valor1 = Number(valores[0]);
	valor2 = Number(valores[1]);

    calculate(valor1, valor2);
	*/
}
/*
function calculate(valor1, valor2)
{

    if(operador == "+")
        resultado = (valor1 + valor2);
    else if (operador == "-")
    	resultado = (valor1 - valor2);
    else if (operador == "/")
    	resultado = (valor1 / valor2);
    else if (operador == "*")
    	resultado = (valor1 * valor2);


    document.getElementById("caixaTexto").value = eval(resultado);
    cont2++;
    expression = "";
}

*/



