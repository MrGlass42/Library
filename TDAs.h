#pragma once

#include <iostream>

using namespace std;

// Esta Biblioteca tem como objetivo oferecer acesso ao uso de diferentes Tipos abstratos de Dados
// No momento suporta somente Pilha
// v1.0

// by Mr.Glass...

// Defines:

#define MAX 50
#define MAXFILA 100
#define MARCADOR -1

// PILHA
//------------------------------------------------------------------------------------------------------------------------------------

// Struct Pillha

typedef struct Stack 
{
	int pilha[MAX];
	int indice;
}Pilha;

// Protótipo das Funções de Pilha

void CreateStack(Stack *Pilha);
void Push(Stack *Pilha, int elemento);
int Pop(Stack *Pilha);
int StackTop(Stack *Pilha);
bool EmptyStack(Stack *Pilha);
bool FullStack(Stack *Pilha);


// Funções:

// Create Stack

void CreateStack(Stack *Pilha)
{
	Pilha->indice = MARCADOR;
}


// Push into the Stack
void Push(Stack *Pilha, int elemento)
{
	if (FullStack(Pilha))
	{
		cout << "\n\nA Pilha esta cheia\n\n*********OverFlow !!!!*********" << endl;
		system("pause");
	}
	else
		Pilha->pilha[++(Pilha->indice)] = elemento;
}

// Pop of the Stack

int Pop(Stack *Pilha)
{
	if (EmptyStack(Pilha))
	{
		cout << "\n\nA Pilha esta vazia\n\n*********UnderFlow !!!!*********" << endl;
		system("pause");
		return 0;
	}
	else
		return Pilha->pilha[(Pilha->indice)--];
}

// Top of the Stack

int Top(Stack *Pilha)
{
	if (EmptyStack(Pilha))
	{
		cout << "\n\nA Pilha esta vazia\n\n*********UnderFlow !!!!*********" << endl;
		system("pause");
		return 0;
	}
	else
		return Pilha->pilha[(Pilha->indice)];
}

bool EmptyStack(Stack *Pilha)
{
	if (Pilha->indice == MARCADOR)
		return true;
	else
		return false;
}

bool FullStack(Stack *Pilha)
{
	if (Pilha->indice == (MAX - 1))
		return true;
	else
		return false;
}

//------------------------------------------------------------------------------------------------------------------------------------

// FILA


// Struct Fila
typedef struct Queue
{
	int Queue[MAXFILA];
	int First;
	int Last;
};

// Protótipos das funções

void CreateQueue(Queue *Fila);
void PutIn(Queue *Fila, int elemento);
int PopOf(Queue *Fila);
bool EmptyQueue(Queue *Fila);
bool FullQueue(Queue *Fila);
int getFirst(Queue *Fila);
int PutAsFirst(Queue *Fila, int elemento);

// Start Queue

void CreateQueue(Queue *Fila)
{
	Fila->First = (MAXFILA - 1);
	Fila->Last = (MAXFILA - 1);
}

// Empty Queue

bool EmptyQueue(Queue *Fila)
{
	if (Fila->First == Fila->Last)
		return true;
	else
		return false;
}

// Full Queue

bool FullQueue(Queue *Fila)
{
	if (Fila->Last == (MAXFILA - 1))
		return (Fila->First == 0);
	else
		return (Fila->First == ((Fila->Last) + 1));
}

// Put in the Queue

void PutIn(Queue *Fila, int elemento)
{
	if (Fila->Last == (MAXFILA - 1))
		Fila->Last = 0;
	else
		(Fila->Last)++;
	if (Fila->Last == Fila->First)
	{
		cout << "\n\nA Fila esta cheia\n\n*********OverFlow !!!!*********" << endl;
		exit(1);
	}
	Fila->Queue[Fila->Last] = elemento;
}

// Pop of the Queue

int PopOf(Queue *Fila)
{
	if (EmptyQueue(Fila))
		return 0;
	if (Fila->First == (MAXFILA - 1))
		Fila->First = 0;
	else
		(Fila->First)++;
	return (Fila->Queue[Fila->First]);
}

// Get First Index

int getFirst(Queue *Fila)
{
	return Fila->First;
}

// Get Last Index

int PutAsFirst(Queue *Fila, int elemento)
{
	return Fila->First = elemento;
}

//------------------------------------------------------------------------------------------------------------------------------------